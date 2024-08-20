﻿using Microsoft.EntityFrameworkCore;
using ServerApp.Components;
using ServerApp.Data.Entities;
using ServerApp.Data.Interfaces;
using ServerApp.Data.Models;

namespace ServerApp.Data.Services
{
    public class SqlDbDataService(ApplicationDbContext context, IAuthorization auth) : IDataService
    {
        public async Task<UserInfo?> GetCurrentUserInfoAsync()
        {
            return await auth.GetUserAsync();
        }

        public async Task<EditModel> GetCurrentUserEditModelAsync()
        {
            var user = await auth.GetUserAsync();
            var application = await context.ApplicationForms.FirstOrDefaultAsync(x => x.UserInfo == user) ?? new();
            return await Task.FromResult(new EditModel(application));
        }

        public async Task<IEnumerable<TrackModel>> GetTrackModelsAsync()
        {
            return await Task.FromResult(context.Tracks.Select(e => new TrackModel(e)));
        }

        public async Task<IEnumerable<EditBlockModel>> GetEditBlockModelsAsync(Guid? trackId)
        {
            var track = await context.Tracks.Include(track => track.EditBlocks)
                .FirstOrDefaultAsync(x => x.Id == trackId);
            return track?.EditBlocks.OrderBy(x => x.Number).Select(e => new EditBlockModel(e)) ?? [];
        }

        public async Task<FieldModel[]> GetFieldModelsAsync(Guid? editBlockId)
        {
            var user = await auth.GetUserAsync();
            if (user == null)
            {
                throw new UnauthorizedAccessException("User unauthorized.");
            }

            var editBlock = await context.EditBlocks
                .Include(editBlock => editBlock.Fields).ThenInclude(field => field.FieldVals)
                .ThenInclude(fieldVal => fieldVal.Application).ThenInclude(applicationForm => applicationForm!.UserInfo)
                .Include(e => e.Fields).ThenInclude(e => e.ValueType)
                .Include(e => e.Fields).ThenInclude(e => e.SelectValues)
                .FirstOrDefaultAsync(e => e.Id == editBlockId);
            return editBlock!.Fields.OrderBy(x => x.Number).Select(e => new FieldModel(e, user)).ToArray();
        }

        public async Task<TableModel[]> GetTableModelsAsync(Guid? editBlockId)
        {
            var editBlock = await context.EditBlocks.Include(editBlock => editBlock.Tables)
                .FirstOrDefaultAsync(e => e.Id == editBlockId);
            return editBlock!.Tables.OrderBy(x => x.Number).Select(t => new TableModel(t)).ToArray();
        }

        public async Task SaveApplicationFormFromEditModelAsync(EditModel model)
        {
            var user = await auth.GetUserAsync();
            if (user == null)
            {
                throw new UnauthorizedAccessException("User unauthorized.");
            }

            if (model.SelectedTrackId == null)
            {
                throw new ArgumentException("SelectedTrackId is required.");
            }

            var trackExists = await context.Tracks.AnyAsync(t => t.Id == model.SelectedTrackId);
            if (!trackExists)
            {
                throw new InvalidOperationException($"Track with ID '{model.SelectedTrackId}' does not exist.");
            }

            var app = await context.ApplicationForms
                .Include(a => a.UserInfo)
                .FirstOrDefaultAsync(a => a.UserInfo!.Id == user.Id);

            if (app == null)
            {
                app = new ApplicationForm
                {
                    Id = Guid.NewGuid(),
                    UserInfoId = user.Id,
                    TrackId = model.SelectedTrackId.Value
                };

                user.Applications.Add(app);
                await context.ApplicationForms.AddAsync(app);
            }
            else
            {
                app.TrackId = model.SelectedTrackId.Value;
                context.ApplicationForms.Update(app);
            }

            await context.SaveChangesAsync();

            List<FieldVal> fieldVals = model.Fields.Select(f => f.ToEntity()).ToList();
            foreach (var fld in fieldVals)
            {
                fld.ApplicationId = app.Id;

                var existingFieldVal = await context.FieldVals
                    .FirstOrDefaultAsync(f => f.ApplicationId == fld.ApplicationId && f.FieldId == fld.FieldId);

                if (existingFieldVal == null)
                {
                    await context.FieldVals.AddAsync(fld);
                }
                else
                {
                    existingFieldVal.Value = fld.Value;
                    context.FieldVals.Update(existingFieldVal);
                }
            }

            List<Table> tables = model.Tables.Select(t => t.ToEntity()).ToList();
            foreach (var tbl in tables)
            {
                foreach (var row in tbl.Rows)
                {
                    row.TableId = tbl.Id;

                    var existingRow = await context.Rows.FindAsync(row.Id);
                    if (existingRow == null)
                    {
                        context.Rows.Add(row);
                    }
                    else
                    {
                        context.Entry(existingRow).CurrentValues.SetValues(row);
                        context.Rows.Update(existingRow);
                    }

                    foreach (var cell in row.CellVals)
                    {
                        cell.ApplicationId = app.Id;
                        cell.RowId = row.Id;

                        var existingCellVal = await context.CellVals.FindAsync(cell.Id);
                        if (existingCellVal == null)
                        {
                            context.CellVals.Add(cell);
                        }
                        else
                        {
                            existingCellVal.Value = cell.Value;
                            context.CellVals.Update(existingCellVal);
                        }
                    }
                }
            }

            await context.SaveChangesAsync();
        }
    }
}
