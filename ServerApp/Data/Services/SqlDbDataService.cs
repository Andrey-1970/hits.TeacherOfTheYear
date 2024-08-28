using System.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Abstractions;
using ServerApp.Components;
using ServerApp.Data.Entities;
using ServerApp.Data.Interfaces;
using ServerApp.Data.Models.EditModel;
using ServerApp.Data.Models.MarkModel;
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
            var user = await auth.GetUserAsync() ?? throw new UnauthorizedAccessException("User unauthorized.");
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
            var user = await auth.GetUserAsync() ?? throw new UnauthorizedAccessException("User unauthorized.");
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
            var user = await auth.GetUserAsync() ?? throw new UnauthorizedAccessException("User unauthorized.");
            List<TableModel> res = [];
            var editBlock = await context.EditBlocks.Include(editBlock => editBlock.Tables)
                .ThenInclude(table => table.Columns).Include(editBlock => editBlock.Tables)
                .ThenInclude(table => table.Rows).ThenInclude(row => row.CellVals)
                .FirstOrDefaultAsync(e => e.Id == editBlockId) ?? throw new InvalidOperationException("EditBlock does not exist.");
            foreach (var table in editBlock.Tables.OrderBy(e => e.Number))
            {
                if (table.IsPrefilled)
                {
                    if (table.Rows.Any(r => r.CellVals.Any(c => c.ApplicationId == user.Applications.First().Id)))
                    {
                        res.Add(new TableModel()
                        {
                            Id = table.Id,
                            Name = table.Name,
                            IsPrefilled = table.IsPrefilled,
                            Columns = table.Columns.OrderBy(c => c.Number).Select(e => new ColumnModel(e)).ToList(),
                            Rows = table.Rows.Where(r => r.CellVals.Any(c => c.ApplicationId == user.Applications.First().Id)).Select(r => new RowModel(r)).ToList()
                        });
                    }
                    else
                    {
                        res.Add(new TableModel(table));
                    }
                }
                else
                {
                    res.Add(new TableModel(table));
                }
            }

            return res.ToArray();
        }

        public async Task<RowModel> GetRowModelAsync(Guid? tableId)
        {
            var table = await context.Tables.FirstOrDefaultAsync(e => e.Id == tableId);
            return new RowModel()
            {
                Id = Guid.NewGuid(),
                Cells = table!.Columns.OrderBy(t => t.Number).Select(e => new CellModel()
                {
                    Id = Guid.NewGuid(), ValueType = e.ValueType!.Name,
                    SelectValues = e.SelectValues.Select(e => e.Value).ToArray(),
                    ColumnId = e.Id
                }).ToList()
            };
        }

        public async Task DeleteRowAsync(Guid rowId)
        {
            var row = await context.Rows.FirstOrDefaultAsync(e => e.Id == rowId);
            if (row != null)
            {
                context.Rows.Remove(row);
                await context.SaveChangesAsync();
            }
        }

        public async Task SaveApplicationFormFromEditModelAsync(EditModel model)
        {
            var user = await auth.GetUserAsync() ?? throw new UnauthorizedAccessException("User unauthorized.");
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
                    TrackId = model.SelectedTrackId.Value,
                    ApplicationStatusId = context.ApplicationStatuses.FirstOrDefault(e => e.Number == 1)!.Id
                };

                user.Applications.Add(app);
                await context.ApplicationForms.AddAsync(app);
                await context.SaveChangesAsync(); // Сохраняем, чтобы получить Id нового приложения
            }
            else
            {
                app.TrackId = model.SelectedTrackId.Value;
                context.ApplicationForms.Update(app);
                await context.SaveChangesAsync(); // Сохраняем, чтобы обновить приложение
            }

            // Обработка полей
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

            // Обработка таблиц
            List<Table> tables = model.Tables.Select(t => t.ToEntity()).ToList();

            foreach (var tbl in tables)
            {
                if (tbl.IsPrefilled)
                {
                    foreach (var row in tbl.Rows)
                    {
                        row.IsPrefilled = false;
                        row.Id = Guid.NewGuid();

                        foreach (var cell in row.CellVals)
                        {
                            cell.ApplicationId = app.Id;
                            cell.RowId = row.Id;
                            cell.Id = Guid.NewGuid();
                        }

                        context.Rows.Add(row);
                    }
                }
                else
                {
                    foreach (var row in tbl.Rows)
                    {
                        row.TableId = tbl.Id;

                        var existingRow = await context.Rows
                            .Include(r => r.CellVals) // Включаем ячейки для проверки ApplicationId
                            .FirstOrDefaultAsync(r =>
                                r.Id == row.Id && r.TableId == row.TableId &&
                                r.CellVals.Any(c => c.ApplicationId == app.Id));

                        if (existingRow == null)
                        {
                            // Генерация нового идентификатора для новой строки
                            row.Id = Guid.NewGuid();
                            row.IsPrefilled = false;

                            foreach (var cell in row.CellVals)
                            {
                                cell.Id = Guid.NewGuid();
                                cell.ApplicationId = app.Id;
                                cell.RowId = row.Id;
                            }

                            context.Rows.Add(row);
                        }
                        else
                        {
                            var existingCells = existingRow.CellVals.ToDictionary(c => c.Id);

                            foreach (var cell in row.CellVals)
                            {
                                if (existingCells.TryGetValue(cell.Id, out var existingCell))
                                {
                                    existingCell.Value = cell.Value;
                                    context.CellVals.Update(existingCell);
                                }
                                else
                                {
                                    cell.Id = Guid.NewGuid();
                                    cell.ApplicationId = app.Id;
                                    cell.RowId = existingRow.Id;
                                    context.CellVals.Add(cell);
                                }
                            }

                            context.Rows.Update(existingRow);
                        }
                    }
                }
            }

            await context.SaveChangesAsync();

            var editBlockStatus = await context.EditBlockStatuses
                .FirstOrDefaultAsync(
                    e => e.EditBlockId == model.SelectedEditBlockId!.Value && e.ApplicationId == app.Id);

            if (editBlockStatus == null)
            {
                context.EditBlockStatuses.Add(new EditBlockStatus()
                {
                    Id = Guid.NewGuid(),
                    EditBlockId = model.SelectedEditBlockId!.Value,
                    ApplicationId = app.Id,
                    Status = true
                });
            }

            await context.SaveChangesAsync();
        }


        public async Task SetCurrentUserApplicationStatusWaitingForReviewedAsync()
        {
            var user = await auth.GetUserAsync() ?? throw new UnauthorizedAccessException("User unauthorized.");
            var app = user.Applications.FirstOrDefault() ?? throw new InvalidOperationException("No application found for the current user.");
            var track = app.Track ?? throw new InvalidOperationException("No track found for the application.");
            var editBlocks = track.EditBlocks;

            foreach (var editBlock in editBlocks)
            {
                var editBlockStatus = await context.EditBlockStatuses
                    .FirstOrDefaultAsync(e => e.ApplicationId == app.Id && e.EditBlockId == editBlock.Id);

                if (editBlockStatus == null || !editBlockStatus.Status)
                {
                    throw new InvalidOperationException($"EditBlock with ID '{editBlock.Id}' does not have a valid status for this application.");
                }
            }

            var newStatus = await context.ApplicationStatuses.FirstOrDefaultAsync(e => e.Number == 2) ?? throw new InvalidOperationException("Application status with number 2 not found.");
            app.ApplicationStatusId = newStatus.Id;
            context.Update(app);
            await context.SaveChangesAsync();
        }

        public async Task SetApplicationStatusReviewProcessAsync(Guid userId)
        {
            var user = await auth.GetUserAsync() ?? throw new UnauthorizedAccessException("User unauthorized.");

            var participant = context.UserInfos
                                  .Include(userInfo => userInfo.Applications)
                                  .ThenInclude(applicationForm => applicationForm.Track)
                                  .ThenInclude(track => track.MarkBlocks).Include(userInfo => userInfo.Applications)
                                  .ThenInclude(applicationForm => applicationForm.ApplicationStatus)
                                  .FirstOrDefault(e => e.Id == userId) ??
                              throw new NullReferenceException("Current user not found.");

            var app = participant.Applications.FirstOrDefault() ??
                      throw new NullReferenceException("Current application not found.");

            var newStatus = await context.ApplicationStatuses
                                .FirstOrDefaultAsync(e => e.Number == 3) ??
                            throw new InvalidOperationException("Application status with number 3 not found.");
            if (app.ApplicationStatus != newStatus)
            {
                app.ApplicationStatus = newStatus;
                app.ReviewerId = user.Id;
                context.Update(app);
                await context.SaveChangesAsync();

                foreach (var markBlock in app.Track.MarkBlocks)
                {
                    var blockReview = new BlockReview()
                    {
                        Id = Guid.NewGuid(),
                        MarkBlockId = markBlock.Id,
                        ApplicationId = app.Id
                    };
                    context.Add(blockReview);
                }

                await context.SaveChangesAsync();
            }
        }

        public async Task<UserInfoModel[]> GetUserInfosModelsAsync()
        {
            var user = await auth.GetUserAsync();
            var userInfos = await context.UserInfos
                .Where(e => e.Applications.Any(a => a.ApplicationStatus.Number == 2 || a.ApplicationStatus.Number == 3 && a.ReviewerId == user!.Id))
                .Include(userInfo => userInfo.Applications)
                .ThenInclude(applicationForm => applicationForm.ApplicationStatus)
                .ToListAsync();

            var userInfoModels = userInfos 
                .Select(e => new UserInfoModel(e))
                .ToArray();

            return userInfoModels;        
        }
        
        public async Task<ReviewMarkModel> GetUserMarkModelAsync(Guid userInfoId)
        {
            var application = await context.ApplicationForms.Include(applicationForm => applicationForm.Track)
                .ThenInclude(track => track.MarkBlocks).Include(applicationForm => applicationForm.BlockReviews).FirstOrDefaultAsync(x => x.UserInfoId == userInfoId) ?? new();
            var markModel = new ReviewMarkModel(application);
            var blockReviewModels = markModel.ReviewedBlocks.ToList();
            foreach (var markBlock in application.Track.MarkBlocks)
            {
                blockReviewModels.Add(new (application.BlockReviews.FirstOrDefault(e =>
                    e.ApplicationId == application.Id && e.MarkBlockId == markBlock.Id)!));
            }

            markModel.ReviewedBlocks = blockReviewModels.ToArray();
            return await Task.FromResult(markModel);
        }
        
        public async Task<MarkBlockModel[]> GetMarkBlockModelsAsync(Guid? trackId)
        {
            var track = await context.Tracks.Include(track => track.MarkBlocks)
                .FirstOrDefaultAsync(x => x.Id == trackId);
            return track?.MarkBlocks.OrderBy(x => x.Number).Select(e => new MarkBlockModel(e)).ToArray() ?? [];
        }
        
        public async Task<FieldModel[]> GetFieldModelsForMarkBlockAsync(Guid? markBlockId, Guid appId)
        {
            var user = context.ApplicationForms.Include(applicationForm => applicationForm.UserInfo)
                .FirstOrDefaultAsync(e => e.Id == appId).Result!.UserInfo;
            if (user == null)
            {
                throw new InvalidOperationException("User does not exist.");
            }

            var markBlock = await context.MarkBlocks
                .Include(markBlock => markBlock.Fields).ThenInclude(field => field.FieldVals)
                .ThenInclude(fieldVal => fieldVal.Application).ThenInclude(applicationForm => applicationForm!.UserInfo)
                .Include(e => e.Fields).ThenInclude(e => e.ValueType)
                .Include(e => e.Fields).ThenInclude(e => e.SelectValues)
                .FirstOrDefaultAsync(e => e.Id == markBlockId);
            return markBlock!.Fields.OrderBy(x => x.Number).Select(e => new FieldModel(e, user)).ToArray() ?? [];
        }
        
        public async Task<TableModel[]> GetTableModelsForMarkBlockAsync(Guid? markBlockId, Guid appId)
        {
            var markBlock = await context.MarkBlocks
                .Include(mb => mb.Tables)
                .ThenInclude(t => t.Rows)
                .ThenInclude(r => r.CellVals.Where(cv => cv.ApplicationId == appId))
                .ThenInclude(cellVal => cellVal.Column!)
                .Include(markBlock => markBlock.Tables).ThenInclude(table => table.Columns)
                .FirstOrDefaultAsync(mb => mb.Id == markBlockId);

            if (markBlock == null)
            {
                throw new InvalidOperationException("MarkBlock not found");
            }

            var tables = markBlock.Tables
                .OrderBy(t => t.Number)
                .Select(t => new TableModel
                {
                    Id = t.Id,
                    Name = t.Name,
                    Columns = t.Columns.OrderBy(c => c.Number).Select(e => new ColumnModel(e)).ToList(),
                    Rows = t.Rows
                        .Where(r => r.CellVals.OrderBy(c => c.Column!.Number).Any(cv => cv.ApplicationId == appId))
                        .Select(r => new RowModel
                        {
                            Id = r.Id,
                            Cells = r.CellVals
                                .OrderBy(c => c.Column!.Number)
                                .Where(cv => cv.ApplicationId == appId)
                                .Select(cv => new CellModel
                                {
                                    Id = cv.Id,
                                    Value = cv.Value,
                                    ColumnId = cv.ColumnId
                                }).ToList()
                        }).ToList()
                }).ToArray() ?? [];

            return tables;
        }

        public async Task ChangeBlockReviewStatus(Guid? markBlockId, Guid? appId)
        {
            var blockReview = context.BlockReviews.FirstOrDefault(e => e.MarkBlockId == markBlockId && e.ApplicationId == appId) ??
                              throw new NullReferenceException("Current block review not find.");
            blockReview.Status = !blockReview.Status;
            context.Update(blockReview);
            await context.SaveChangesAsync();
        }

        public async Task SaveCommentReviewBlockAsync(Guid? markBlockId, Guid? appId, string? comment)
        {
            var blockReview = context.BlockReviews.FirstOrDefault(e => e.MarkBlockId == markBlockId && e.ApplicationId == appId) ??
                              throw new NullReferenceException("Current block review not find.");
            blockReview.Commentary = comment;
            context.Update(blockReview);
            await context.SaveChangesAsync();
        }

        private async Task AutoSetMarks(Guid? appId)
        {
            var app = await context.ApplicationForms.Include(applicationForm => applicationForm.Track)
                          .ThenInclude(track => track.EditBlocks).Include(applicationForm => applicationForm.Track)
                          .ThenInclude(track => track.MarkBlocks).ThenInclude(markBlock => markBlock.Marks)
                          .ThenInclude(mark => mark.Field!).ThenInclude(field => field.FieldVals).FirstOrDefaultAsync(e => e.Id == appId)
                ?? throw new NullReferenceException("Current application not found.");
            MarkVal markValRes= new MarkVal() { ApplicationId = app.Id};
            foreach (var markBlock in app.Track.MarkBlocks)
            {
                foreach (var mark in markBlock.Marks)
                {
                    if (mark.IsAuto)
                    {
                        markValRes.Id = Guid.NewGuid();
                        markValRes.MarkId = mark.Id;
                        markValRes.Mark = mark;
                        switch (mark.Number)
                        {
                            case 1:
                            {
                                var vals = context.CellVals
                                    .Where(c => c.ApplicationId == appId && c.Row!.TableId == mark.TableId).ToArray();
                                int resval = 0;
                                foreach (var val in vals.Where(c => c.Column!.Name == "Итого (час.)"))
                                {
                                    resval += int.Parse(val.Value ?? "0");
                                }

                                markValRes.Value = resval switch
                                {
                                    >= 1 and <= 199 => 1,
                                    >= 200 and <= 399 => 2,
                                    >= 400 => 3,
                                    _ => 0
                                };
                                break;
                            }
                            case 2:
                            {
                                var vals = context.Rows.Where(r =>
                                    r.TableId == mark.TableId && r.CellVals.Any(c => c.ApplicationId == appId));
                                var resval = vals.Count();

                                markValRes.Value = resval switch
                                {
                                    1 => 1,
                                    >= 2 => 2,
                                    _ => 0
                                };
                                break;
                            }
                            case 3:
                            {
                                var fld = mark.Field!.FieldVals.FirstOrDefault(e => e.ApplicationId == appId);
                                var val = int.Parse(fld!.Value ?? "0");

                                markValRes.Value = val switch
                                {
                                    1 => 1,
                                    2 => 2,
                                    3 => 3,
                                    4 => 4,
                                    >= 5 => 5,
                                    _ => 0
                                };
                                break;
                            }
                            case 4:
                            {
                                var fld = mark.Field!.FieldVals.FirstOrDefault(e => e.ApplicationId == appId);
                                var val = int.Parse(fld!.Value ?? "0");

                                markValRes.Value = val switch
                                {
                                    1 => 1,
                                    >= 2 => 2,
                                    _ => 0
                                };
                                break;
                            }
                            case 5:
                            {
                                var fld = mark.Field!.FieldVals.FirstOrDefault(e => e.ApplicationId == appId);
                                var val = int.Parse(fld!.Value ?? "0");

                                markValRes.Value = val switch
                                {
                                    1 => 2,
                                    >= 2 => 4,
                                    _ => 0
                                };
                                break;
                            }
                            case 6:
                            {
                                var rows = context.Rows.Where(r =>
                                    r.TableId == mark.TableId &&
                                    r.CellVals.Any(c => c.ApplicationId == appId));
                                var count = rows.Count();

                                markValRes.Value = count switch
                                {
                                    >= 1 and <= 2 => 1,
                                    >= 3 and <= 4 => 2,
                                    >= 5 and <= 6 => 3,
                                    >= 7 => 4,
                                    _ => 0
                                };
                                break;
                            }
                            case 7:
                            {
                                var rows = context.Rows.Where(r =>
                                    r.TableId == mark.TableId &&
                                    r.CellVals.Any(c => c.ApplicationId == appId));
                                var count = rows.Count();

                                markValRes.Value = count switch
                                {
                                    1 => 1,
                                    2 => 2,
                                    >= 3 => 5,
                                    _ => 0
                                };
                                break;
                            }
                            case 8:
                            {
                                var rows = context.Rows.Where(r =>
                                    r.TableId == mark.TableId &&
                                    r.CellVals.Any(c =>
                                        c.ApplicationId == appId && c.Column!.Name == "Наличие грифа" &&
                                        c.Value == "1") &&
                                    r.CellVals.Any(c =>
                                        c.ApplicationId == appId && c.Column!.Name == "Соавторы" &&
                                        (c.Value == null || c.Value == ""))
                                ).ToList();
                                var count = rows.Count;

                                markValRes.Value = count switch
                                {
                                    1 => 4,
                                    >= 2 => 5,
                                    _ => 0
                                };
                                break;
                            }
                            case 9:
                            {
                                var rows = context.Rows.Where(r =>
                                    r.TableId == mark.TableId &&
                                    r.CellVals.Any(c =>
                                        c.ApplicationId == appId && c.Column!.Name == "Наличие грифа" &&
                                        c.Value == "1") &&
                                    r.CellVals.Any(c =>
                                        c.ApplicationId == appId && c.Column!.Name == "Соавторы" &&
                                        (c.Value != null || c.Value != ""))
                                ).ToList();
                                var count = rows.Count;

                                markValRes.Value = count switch
                                {
                                    1 => 2,
                                    >= 2 => 3,
                                    _ => 0
                                };
                                break;
                            }
                            case 10:
                            {
                                var rows = context.Rows.Where(r =>
                                    r.TableId == mark.TableId &&
                                    r.CellVals.Any(c =>
                                        c.ApplicationId == appId && c.Column!.Name == "Наличие грифа" &&
                                        c.Value == "0") &&
                                    r.CellVals.Any(c =>
                                        c.ApplicationId == appId && c.Column!.Name == "Соавторы" &&
                                        (c.Value == null || c.Value == ""))
                                ).ToList();
                                var count = rows.Count;

                                markValRes.Value = count switch
                                {
                                    1 => 1,
                                    >= 2 => 2,
                                    _ => 0
                                };
                                break;
                            }
                            case 11:
                            {
                                var rows = context.Rows.Where(r =>
                                    r.TableId == mark.TableId &&
                                    r.CellVals.Any(c =>
                                        c.ApplicationId == appId && c.Column!.Name == "Наличие грифа" &&
                                        c.Value == "0") &&
                                    r.CellVals.Any(c =>
                                        c.ApplicationId == appId && c.Column!.Name == "Соавторы" &&
                                        (c.Value != null || c.Value != ""))
                                ).ToList();
                                var count = rows.Count;

                                markValRes.Value = count switch
                                {
                                    1 => 1,
                                    >= 2 => 2,
                                    _ => 0
                                };
                                break;
                            }
                            case 12:
                            {
                                var rows = context.Rows.Where(r =>
                                    r.TableId == mark.TableId &&
                                    r.CellVals.Any(c => c.ApplicationId == appId));
                                var count = rows.Count();

                                markValRes.Value = count switch
                                {
                                    >= 1 and <= 2 => 1,
                                    >= 3 and <= 4 => 2,
                                    >= 5 and <= 6 => 3,
                                    >= 7 => 4,
                                    _ => 0
                                };
                                break;
                            }
                            case 13:
                            {
                                var fld = mark.Field!.FieldVals.FirstOrDefault(e => e.ApplicationId == appId);
                                var val = fld!.Value;

                                markValRes.Value = val switch
                                {
                                    "Доцент" => 2,
                                    "Профессор" => 5,
                                    _ => 0
                                };
                                break;
                            }
                            case 14:
                            {
                                var rows = context.Rows.Where(r =>
                                    r.TableId == mark.TableId &&
                                    r.CellVals.Any(c => c.ApplicationId == appId));
                                var count = rows.Count();

                                markValRes.Value = count switch
                                {
                                    1 => 1,
                                    >= 2 => 2,
                                    _ => 0
                                };
                                break;
                            }
                            case 15:
                            {
                                var anyRows = context.Rows.Any(r =>
                                    r.TableId == mark.TableId &&
                                    r.CellVals.Any(c => c.ApplicationId == appId));

                                markValRes.Value = anyRows ? 2 : 0;
                                break;
                            }
                            case 16:
                            {
                                var rows = context.Rows.Where(r =>
                                    r.TableId == mark.TableId &&
                                    r.CellVals.Any(c => c.ApplicationId == appId));
                                var count = rows.Count();

                                markValRes.Value = count switch
                                {
                                    1 => 1,
                                    2 => 2,
                                    3 => 3,
                                    4 => 4,
                                    >= 5 => 5,
                                    _ => 0
                                };
                                break;
                            }
                            case 17:
                            {
                                var row = context.Rows.Include(row => row.CellVals)
                                    .ThenInclude(cellVal => cellVal.Column).FirstOrDefault(r =>
                                        r.CellVals.Any(c =>
                                            c.ApplicationId == appId && c.Column!.Name == "Тип идентификатора" &&
                                            c.Value == "ScopusID")
                                    );
                                var val = int.Parse(row.CellVals.FirstOrDefault(c =>
                                    c.Column!.Name == "Индекс Хирша (за все время)")!.Value ?? "0");

                                markValRes.Value = val switch
                                {
                                    <= 1 => 0,
                                    4 => 4,
                                    >= 5 => 5,
                                    _ => 0
                                };
                                break;
                            }
                            case 18:
                            {
                                var row = context.Rows.Include(row => row.CellVals)
                                    .ThenInclude(cellVal => cellVal.Column).FirstOrDefault(r =>
                                        r.CellVals.Any(c =>
                                            c.ApplicationId == appId && c.Column!.Name == "Тип идентификатора" &&
                                            c.Value == "РИНЦ AuthorID")
                                    );
                                var val = int.Parse(row.CellVals.FirstOrDefault(c =>
                                    c.Column!.Name == "Индекс Хирша (за все время)")!.Value ?? "0");

                                markValRes.Value = val switch
                                {
                                    <= 1 => 0,
                                    4 => 4,
                                    >= 5 => 5,
                                    _ => 0
                                };
                                break;
                            }
                            case 19:
                            {
                                var fld = mark.Field!.FieldVals.FirstOrDefault(e => e.ApplicationId == appId);
                                var val = int.Parse(fld!.Value ?? "0");

                                markValRes.Value = val switch
                                {
                                    1 => 1,
                                    >= 2 => 2,
                                    _ => 0
                                };
                                break;
                            }
                            case 20:
                            {
                                var fld = mark.Field!.FieldVals.FirstOrDefault(e => e.ApplicationId == appId);
                                var val = int.Parse(fld!.Value ?? "0");

                                markValRes.Value = val switch
                                {
                                    1 => 2,
                                    >= 2 => 4,
                                    _ => 0
                                };
                                break;
                            }
                            case 21:
                            {
                                var rows = context.Rows.Where(r =>
                                    r.TableId == mark.TableId &&
                                    r.CellVals.Any(c =>
                                        c.ApplicationId == appId &&
                                        c.Column!.Name == "Статус (руководитель/исполнитель)" &&
                                        c.Value == "Руководитель")
                                ).ToList();
                                var count = rows.Count;

                                markValRes.Value = count switch
                                {
                                    >= 1 and <= 2 => 2,
                                    >= 3 => 4,
                                    _ => 0
                                };
                                break;
                            }
                            case 22:
                            {
                                var rows = context.Rows.Where(r =>
                                    r.TableId == mark.TableId &&
                                    r.CellVals.Any(c =>
                                        c.ApplicationId == appId &&
                                        c.Column!.Name == "Статус (руководитель/исполнитель)" &&
                                        c.Value == "Исполнитель")
                                ).ToList();
                                var count = rows.Count;

                                markValRes.Value = count switch
                                {
                                    >= 1 and <= 2 => 1,
                                    >= 3 => 2,
                                    _ => 0
                                };
                                break;
                            }
                            case 23:
                            {
                                var rows = context.Rows.Where(r =>
                                    r.TableId == mark.TableId &&
                                    r.CellVals.Any(c => c.ApplicationId == appId));
                                var count = rows.Count();

                                markValRes.Value = count switch
                                {
                                    1 => 1,
                                    >= 2 => 5,
                                    _ => 0
                                };
                                break;
                            }
                            case 24:
                            {
                                var anyRows = context.Rows.Any(r =>
                                    r.TableId == mark.TableId &&
                                    r.CellVals.Any(c => c.ApplicationId == appId));

                                markValRes.Value = anyRows ? 5 : 0;
                                break;
                            }
                        }
                        context.MarkVals.Add(markValRes);
                    }
                    await context.SaveChangesAsync();
                }
            }
        }

        public async Task ApproveApplicationFormAsync(Guid? applicationId)
        {
            var app = await context.ApplicationForms.Include(applicationForm => applicationForm.Track)
                          .ThenInclude(track => track.MarkBlocks)
                          .Include(applicationForm => applicationForm.BlockReviews).FirstOrDefaultAsync(e => e.Id == applicationId) ??
                      throw new NullReferenceException("Current application not found.");
            foreach (var markBlock in app.Track.MarkBlocks)
            {
                if (app.BlockReviews.FirstOrDefault(e => e.ApplicationId == app.Id && e.MarkBlockId == markBlock.Id)!.Status == false) 
                    throw new InvalidOperationException($"Does not have a valid status for this application.");
            }
            app.ApplicationStatusId = context.ApplicationStatuses.FirstOrDefault(e => e.Number == 4)!.Id;
            context.Update(app);
            await context.SaveChangesAsync();

            await AutoSetMarks(app.Id);

            //todo: Добавление пользователю роли "Participant"
        }

        public async Task RejectApplicationFormAsync(Guid? applicationId)
        {
            var app = await context.ApplicationForms.Include(applicationForm => applicationForm.Track)
                          .ThenInclude(track => track.MarkBlocks)
                          .Include(applicationForm => applicationForm.BlockReviews).FirstOrDefaultAsync(e => e.Id == applicationId) ??
                      throw new NullReferenceException("Current application not found.");
            foreach (var markBlock in app.Track.MarkBlocks)
            {
                if (app.BlockReviews.FirstOrDefault(e => e.ApplicationId == app.Id && e.MarkBlockId == markBlock.Id)!.Status == false) 
                    throw new InvalidOperationException($"Does not have a valid status for this application.");
            }
            app.ApplicationStatusId = context.ApplicationStatuses.FirstOrDefault(e => e.Number == 5)!.Id;
            context.Update(app);
            await context.SaveChangesAsync();
        }

        public async Task<TrackModel> GetTrackAsync(Guid? trackId)
        {
            return new TrackModel(await context.Tracks.FirstOrDefaultAsync(e => e.Id == trackId) ?? throw new InvalidOperationException("Does not have track for this Id."));
        }
        
        public async Task<UserInfoModel[]> GetUserInfosModelsAssesmentAsync()
        {
            var user = await auth.GetUserAsync();
            var userInfos = await context.UserInfos
                .Where(e => e.Applications.Any(a => a.ApplicationStatus.Number == 4))
                .Include(userInfo => userInfo.Applications)
                .ThenInclude(applicationForm => applicationForm.ApplicationStatus)
                .ToListAsync();

            var userInfoModels = userInfos 
                .Select(e => new UserInfoModel(e))
                .ToArray();

            return userInfoModels;        
        }

        public async Task<AssessmentModel> GetUserAssessmentModelAsync(Guid? userInfoId)
        {
            var user = await context.UserInfos
                           .Include(userInfo => userInfo.Applications)
                           .ThenInclude(applicationForm => applicationForm.Track)
                           .FirstOrDefaultAsync(e => e.Id == userInfoId) ?? 
                       throw new UnauthorizedAccessException("User unauthorized.");

            var app = user.Applications.FirstOrDefault() ?? 
                      throw new InvalidOperationException("Application not found.");

            var assModel = new AssessmentModel(app);
            var markBlocks = context.Tracks
                                 .Include(t => t.MarkBlocks)
                                 .ThenInclude(mb => mb.Marks)
                                 .ThenInclude(m => m.MarkVals)
                                 .FirstOrDefault(e => e.Id == app.Track.Id)?.MarkBlocks ?? 
                             throw new InvalidOperationException("Track not found");

            var resMarks = assModel.Marks.ToList();
            foreach (var markBlock in markBlocks)
            {
                var markModels = markBlock.Marks.Select(e =>
                {
                    var markVal = e.MarkVals.FirstOrDefault(mv => mv.ApplicationId == app.Id);
                    return new MarkModel()
                    {
                        Id = e.Id,
                        Name = e.Name,
                        Value = markVal?.Value ?? 0,
                        MaxValue = e.MaxValue,
                        IsAuto = e.IsAuto
                    };
                }).ToList();

                resMarks.AddRange(markModels);
            }

// Присваиваем результат обратно в assModel
            assModel.Marks = resMarks.ToArray();

            return assModel;
        }
        
        public async Task<MarkBlockModel[]> GetAssessmentMarkBlockModelsAsync(Guid? trackId, Guid? appId)
        {
            var track = await context.Tracks.Include(track => track.MarkBlocks)
                .ThenInclude(markBlock => markBlock.Marks).ThenInclude(mark => mark.MarkVals)
                .FirstOrDefaultAsync(x => x.Id == trackId);
            var markBlocks = track?.MarkBlocks.OrderBy(x => x.Number).Select(e => new MarkBlockModel(e)).ToArray() ?? [];
            
            var maxSum = track!.MarkBlocks
                .SelectMany(mb => mb.Marks)
                .Sum(e => e.MaxValue) + 10; //todo: добавить поле оценки зрительских симпатий
            foreach (var markBlock in markBlocks)
            {
                // Находим текущий MarkBlock
                var currentMarkBlock = track!.MarkBlocks.FirstOrDefault(mb => mb.Id == markBlock.Id);

                // Продолжаем только если текущий MarkBlock не null
                if (currentMarkBlock != null)
                {
                    // Суммируем значение баллов для текущего ApplicationId
                    var sum = currentMarkBlock.Marks
                        .SelectMany(e => e.MarkVals.Where(mv => mv.ApplicationId == appId))
                        .Sum(mv => mv.Value) ?? 0;

                    markBlock.SummaryMarksBlock = sum!;

                    // Продолжаем только если maxSum больше нуля
                    if (maxSum > 0)
                    {
                        markBlock.Procent = Math.Round((double)sum / maxSum * 100, 2);
                    }
                    else
                    {
                        markBlock.Procent = 0;
                    }
                }
                else
                {
                    markBlock.SummaryMarksBlock = 0;
                    markBlock.Procent = 0;
                }
            }

            return markBlocks;
        }
        
        public async Task<FieldMarkModel[]> GetFieldMarkModelsForMarkBlockAsync(Guid? markBlockId, Guid appId)
        {
            var user = context.ApplicationForms.Include(applicationForm => applicationForm.UserInfo)
                .FirstOrDefaultAsync(e => e.Id == appId).Result!.UserInfo;
            if (user == null)
            {
                throw new InvalidOperationException("User does not exist.");
            }

            var markBlock = await context.MarkBlocks
                .Include(markBlock => markBlock.Fields).ThenInclude(field => field.FieldVals)
                .ThenInclude(fieldVal => fieldVal.Application).ThenInclude(applicationForm => applicationForm!.UserInfo)
                .Include(e => e.Fields).ThenInclude(e => e.ValueType)
                .Include(e => e.Fields).ThenInclude(e => e.SelectValues)
                .FirstOrDefaultAsync(e => e.Id == markBlockId);
            var fields = markBlock!.Fields.OrderBy(x => x.Number).Select(e => new FieldMarkModel(e, user)).ToArray();

            foreach (var field in fields)
            {
                field.Marks = context.Marks.Where(m => m.FieldId == field.Id).Select(m => new MarkModel()
                {
                    Id = m.Id,
                    Name = m.Name,
                    Value = m.MarkVals.FirstOrDefault()!.Value ?? 0,
                    MaxValue = m.MaxValue,
                    IsAuto = m.IsAuto
                } ).ToArray();
            }

            return fields;
        }
        
        public async Task<TableMarkModel[]> GetTableMarkModelsForMarkBlockAsync(Guid? markBlockId, Guid appId)
        {
            var markBlock = await context.MarkBlocks
                .Include(mb => mb.Tables)
                .ThenInclude(t => t.Rows)
                .ThenInclude(r => r.CellVals.Where(cv => cv.ApplicationId == appId))
                .ThenInclude(cellVal => cellVal.Column!)
                .Include(markBlock => markBlock.Tables).ThenInclude(table => table.Columns)
                .Include(markBlock => markBlock.Tables).ThenInclude(table => table.Marks)
                .ThenInclude(mark => mark.MarkVals)
                .FirstOrDefaultAsync(mb => mb.Id == markBlockId);

            if (markBlock == null)
            {
                throw new InvalidOperationException("MarkBlock not found");
            }

            var tables = markBlock.Tables
                .OrderBy(t => t.Number)
                .Select(t => new TableMarkModel()
                {
                    Id = t.Id,
                    Name = t.Name,
                    Columns = t.Columns.OrderBy(c => c.Number).Select(e => new ColumnModel(e)).ToList(),
                    Rows = t.Rows
                        .Where(r => r.CellVals.OrderBy(c => c.Column!.Number).Any(cv => cv.ApplicationId == appId))
                        .Select(r => new RowModel
                        {
                            Id = r.Id,
                            Cells = r.CellVals
                                .OrderBy(c => c.Column!.Number)
                                .Where(cv => cv.ApplicationId == appId)
                                .Select(cv => new CellModel
                                {
                                    Id = cv.Id,
                                    Value = cv.Value,
                                    ColumnId = cv.ColumnId
                                }).ToList()
                        }).ToList(),
                    Marks = t.Marks.Select(m => new MarkModel()
                    {
                        Id = m.Id,
                        Name = m.Name,
                        Value = m.MarkVals.FirstOrDefault()!.Value ?? 0,
                        MaxValue = m.MaxValue,
                        IsAuto = m.IsAuto
                    }).ToArray()
                }).ToArray();

            return tables;
        }
        
        
    }
}
//todo: Метод для итога оценок
//todo: Методы для просчета оценок (при одобрении заявки)