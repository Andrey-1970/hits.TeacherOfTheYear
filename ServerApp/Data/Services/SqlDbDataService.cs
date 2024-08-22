using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Abstractions;
using ServerApp.Components;
using ServerApp.Data.Entities;
using ServerApp.Data.Interfaces;
using ServerApp.Data.Models.EditModel;
using ServerApp.Data.Models.ReviewModel;

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
            var user = await auth.GetUserAsync();
            if (user == null)
            {
                throw new UnauthorizedAccessException("User unauthorized.");
            }
            var track = await context.Tracks.Include(track => track.EditBlocks)
                .FirstOrDefaultAsync(x => x.Id == trackId);
            var editBlocks = track?.EditBlocks.OrderBy(x => x.Number).Select(e => new EditBlockModel(e)).ToArray() ?? [];
            foreach (var editBlock in editBlocks)
            {
                editBlock.Status = user.Applications.FirstOrDefault()?.EditBlockStatusList
                    .FirstOrDefault(e => e.EditBlockId == editBlock.Id)?.Status ?? false; 
            }

            return editBlocks;
        }
        public async Task<FieldModel[]> GetFieldModelsForEditBlockAsync(Guid? editBlockId)
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

        public async Task<TableModel[]> GetTableModelsForEditBlockAsync(Guid? editBlockId)
        {
            var editBlock = await context.EditBlocks.Include(editBlock => editBlock.Tables)
                .FirstOrDefaultAsync(e => e.Id == editBlockId);
            return editBlock!.Tables.OrderBy(x => x.Number).Select(t => new TableModel(t)).ToArray();
        }

        public async Task<RowModel> GetRowModelAsync(Guid? tableId)
        {
            var table = await context.Tables.FirstOrDefaultAsync(e => e.Id == tableId);
            return new RowModel()
            {
                Id = Guid.NewGuid(),
                Cells = table.Columns.Select(e => new CellModel()
                {
                    Id = Guid.NewGuid(), ValueType = e.ValueType.Name,
                    SelectValues = e.SelectValues.Select(e => e.Value).ToArray(),
                    ColumnId = e.Id
                }).ToArray()
            };
        }

        public async Task DeleteRowAsync(Guid rowId)
        {
            var row = await context.Rows.FirstOrDefaultAsync(e => e.Id == rowId);
            context.Rows.Remove(row);
            await context.SaveChangesAsync();
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

            await context.SaveChangesAsync();

            // Сохранение данных таблиц
            List<Table> tables = model.Tables.Select(t => t.ToEntity()).ToList();

            foreach (var tbl in tables)
            {
                foreach (var row in tbl.Rows)
                {
                    row.TableId = tbl.Id;

                    var existingRow = await context.Rows
                        .FirstOrDefaultAsync(r => r.Id == row.Id && r.TableId == row.TableId);

                    if(existingRow == null)
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
                        if(app == null)
                        {
                            throw new InvalidOperationException("ApplicationForm is null.");
                        }

                        if(cell == null)
                        {
                            throw new InvalidOperationException("CellVal instance is null.");
                        }

                        cell.ApplicationId = app.Id;
                        cell.RowId = row.Id;

                        var existingCellVal = await context.CellVals
                            .FirstOrDefaultAsync(c => c.Id == cell.Id && c.RowId == cell.RowId && c.ApplicationId == cell.ApplicationId);

                        if(existingCellVal == null)
                        {
                            context.CellVals.Add(cell);
                        }
                        else
                        {
                            existingCellVal.ColumnId = cell.ColumnId;
                            existingCellVal.Value = cell.Value;
                            context.CellVals.Update(existingCellVal);
                        }
                    }
                }
            }
            await context.SaveChangesAsync();
            var editBlockStatus = context.EditBlockStatuses.FirstOrDefault(e =>
                e.EditBlockId == model.SelectedEditBlockId!.Value && e.ApplicationId == model.ApplicationId);
            if (editBlockStatus == null)
            {
                context.EditBlockStatuses.Add(new EditBlockStatus()
                {
                    Id = Guid.NewGuid(), EditBlockId = model.SelectedEditBlockId!.Value,
                    ApplicationId = app.Id, Status = true
                });
            }

            await context.SaveChangesAsync();
        }

        public async Task<UserInfoModel[]> GetUserInfosModelsAsync()
        {
            return await context.UserInfos.Select(e => new UserInfoModel(e)).ToArrayAsync();
        }
        
        public async Task<MarkModel> GetUserMarkModelAsync(Guid userInfoId)
        {
            var application = await context.ApplicationForms.FirstOrDefaultAsync(x => x.UserInfoId == userInfoId) ?? new();
            return await Task.FromResult(new MarkModel(application));
        }
        
        public async Task<MarkBlockModel[]> GetMarkBlockModelsAsync(Guid? trackId)
        {
            var track = await context.Tracks.Include(track => track.MarkBlocks)
                .FirstOrDefaultAsync(x => x.Id == trackId);
            return track?.MarkBlocks.OrderBy(x => x.Number).Select(e => new MarkBlockModel(e)).ToArray() ?? [];
        }
        
        public async Task<FieldModel[]> GetFieldModelsForMarkBlockAsync(Guid? markBlockId)
        {
            var user = await auth.GetUserAsync();
            if (user == null)
            {
                throw new UnauthorizedAccessException("User unauthorized.");
            }

            var editBlock = await context.MarkBlocks
                .Include(markBlock => markBlock.Fields).ThenInclude(field => field.FieldVals)
                .ThenInclude(fieldVal => fieldVal.Application).ThenInclude(applicationForm => applicationForm!.UserInfo)
                .Include(e => e.Fields).ThenInclude(e => e.ValueType)
                .Include(e => e.Fields).ThenInclude(e => e.SelectValues)
                .FirstOrDefaultAsync(e => e.Id == markBlockId);
            return editBlock!.Fields.OrderBy(x => x.Number).Select(e => new FieldModel(e, user)).ToArray();
        }
        
        public async Task<TableModel[]> GetTableModelsForMarkBlockAsync(Guid? markBlockId)
        {
            var markBlock = await context.MarkBlocks.Include(markBlock => markBlock.Tables)
                .FirstOrDefaultAsync(e => e.Id == markBlockId);
            return markBlock!.Tables.OrderBy(x => x.Number).Select(t => new TableModel(t)).ToArray();
        }

        public async Task<ReviewBlockModel> GetReviewBlockModelAsync(Guid markBlockId)
        {
            var user = await auth.GetUserAsync();
            if (user == null)
            {
                throw new UnauthorizedAccessException("User unauthorized.");
            }
            
            return new ReviewBlockModel(user.Applications.First().BlockReviewStatusList
                .FirstOrDefault(e => e.MarkBlockId == markBlockId));
        }
    }
}
