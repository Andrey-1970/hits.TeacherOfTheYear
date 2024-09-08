using System.Data;
using System.Reflection;
using System.Security;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Abstractions;
using ServerApp.Components;
using ServerApp.Data.Entities;
using ServerApp.Data.Interfaces;
using ServerApp.Data.Models.EditModel;
using ServerApp.Data.Models.MarkModel;
using ServerApp.Data.Models.ReviewModel;
using ServerApp.Data.Models.VoteModel;
using YourProject.Data.Services;

namespace ServerApp.Data.Services
{
    public class SqlDbDataService : IDataService
    {
        private readonly ApplicationDbContext context;
        private readonly AuthenticationStateProvider userStateProvider;
        private readonly UserManager<ApplicationUser> userManager;

        public SqlDbDataService(
            ApplicationDbContext _context, 
            AuthenticationStateProvider _userStateProvider, 
            UserManager<ApplicationUser> _userManager)
        {
            context = _context;
            userStateProvider = _userStateProvider;
            userManager = _userManager;
        }

        private async Task<UserInfo?> GetUserAsync()
        {
            var userState = await userStateProvider.GetAuthenticationStateAsync();
            if (userState == null || userState.User == null || userState.User.Identity == null)
            {
                throw new SecurityException("User is not authorizred to this action.");
            }
            return await context.UserInfos.FirstOrDefaultAsync(x => x.Username == userState.User.Identity!.Name!);
        }
        
        public async Task CreateCurrentUserInfoAsync(string username)
        {
            context.UserInfos.Add(new UserInfo() { Id = Guid.NewGuid(), Username = username });
            await context.SaveChangesAsync();
        }

        public async Task<string> GetApplicationStatusNameAsync()
        {
            var user = await GetUserAsync() ?? throw new UnauthorizedAccessException("User unauthorized.");
            return user.Applications.Count != 0 ? user.Applications.First().ApplicationStatus.Status : "Нет заявки";
        }

        public async Task<UserInfo?> GetCurrentUserInfoAsync()
        {
            return await GetUserAsync();
        }

        public async Task<CategoryModel[]> GetCategoriesAsync()
        {
            return await context.Categories.Select(e => new CategoryModel(e)).ToArrayAsync();
        }

        public async Task<EditModel> GetCurrentUserEditModelAsync()
        {
            var user = await GetUserAsync();
            var application = await context.ApplicationForms.FirstOrDefaultAsync(x => x.UserInfo == user) ?? new();
            return await Task.FromResult(new EditModel(application));
        }

        public async Task<TrackModel[]> GetTrackModelsAsync()
        {
            return await context.Tracks.Select(e => new TrackModel(e)).ToArrayAsync();
        }

        public async Task<IEnumerable<EditBlockModel>> GetEditBlockModelsAsync(Guid? trackId)
        {
            var user = await GetUserAsync() ?? throw new UnauthorizedAccessException("User unauthorized.");
            var track = await context.Tracks
                .FirstOrDefaultAsync(x => x.Id == trackId);
            var editBlocks = track?.EditBlocks.OrderBy(x => x.Number).Select(e => new EditBlockModel(e)).ToArray() ??
                             [];
            foreach (var editBlock in editBlocks)
            {
                editBlock.Status = user.Applications.FirstOrDefault()?.EditBlockStatusList
                    .FirstOrDefault(e => e.EditBlockId == editBlock.Id)?.Status ?? false;
            }

            return editBlocks;
        }

        public async Task<FieldModel[]> GetFieldModelsForEditBlockAsync(Guid? editBlockId)
        {
            var user = await GetUserAsync() ?? throw new UnauthorizedAccessException("User unauthorized.");
            var editBlock = await context.EditBlocks
                .FirstOrDefaultAsync(e => e.Id == editBlockId);
            return editBlock!.Fields.OrderBy(x => x.Number).Select(e => new FieldModel(e, user)).ToArray();
        }

        public async Task<TableModel[]> GetTableModelsForEditBlockAsync(Guid? editBlockId)
        {
            var user = await GetUserAsync() ?? throw new UnauthorizedAccessException("User unauthorized.");
            List<TableModel> res = [];
            var editBlock = await context.EditBlocks
                                .FirstOrDefaultAsync(e => e.Id == editBlockId) ??
                            throw new InvalidOperationException("EditBlock does not exist.");
            foreach (var table in editBlock.Tables.OrderBy(e => e.Number))
            {
                if (table.IsPrefilled)
                {
                    if (table.Rows.Any(r => r.CellVals.Any(c => c.ApplicationId ==
                                                                (user.Applications.FirstOrDefault() ??
                                                                 new ApplicationForm()).Id)) &&
                        (user.Applications.FirstOrDefault() ?? new ApplicationForm()).Id != Guid.Empty)
                    {
                        res.Add(new TableModel()
                        {
                            Id = table.Id,
                            Name = table.Name,
                            IsPrefilled = table.IsPrefilled,
                            Columns = table.Columns.OrderBy(c => c.Number).Select(e => new ColumnModel(e)).ToList(),
                            Rows = table.Rows
                                .Where(r => r.CellVals.Any(c => c.ApplicationId == user.Applications.First().Id))
                                .Select(r => new RowModel(r)).ToList()
                        });
                    }
                    else
                    {
                        res.Add(new TableModel()
                        {
                            Id = table.Id,
                            Name = table.Name,
                            IsPrefilled = table.IsPrefilled,
                            Columns = table.Columns.OrderBy(c => c.Number).Select(e => new ColumnModel(e)).ToList(),
                            Rows = table.Rows.Where(r => r.IsPrefilled).Select(r => new RowModel(r)).ToList()
                        });
                    }
                }
                else
                {
                    res.Add(new TableModel()
                    {
                        Id = table.Id,
                        Name = table.Name,
                        IsPrefilled = table.IsPrefilled,
                        Columns = table.Columns.OrderBy(c => c.Number).Select(e => new ColumnModel(e)).ToList(),
                        Rows = table.Rows
                            .Where(r => r.CellVals.Any(c =>
                                c.ApplicationId == (user.Applications.FirstOrDefault() ?? new ApplicationForm()).Id))
                            .Select(r => new RowModel(r)).ToList()
                    });
                }
            }

            return [.. res];
        }

        public async Task<RowModel> GetRowModelAsync(Guid? tableId)
        {
            var table = await context.Tables
                .FirstOrDefaultAsync(e => e.Id == tableId);
            return new RowModel()
            {
                Id = Guid.NewGuid(),
                Cells = table!.Columns.OrderBy(t => t.Number).Select(e => new CellModel()
                {
                    Id = Guid.NewGuid(),
                    ValueType = e.ValueType!.Name,
                    SelectValues = e.SelectValues.Select(sv => sv.Value).ToArray(),
                    ColumnId = e.Id,
                    IsRequired = e.IsRequired
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
            var user = await GetUserAsync() ?? throw new UnauthorizedAccessException("User unauthorized.");
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
                .FirstOrDefaultAsync(a => a.UserInfo.Id == user.Id);

            if (app == null)
            {
                app = new ApplicationForm
                {
                    Id = Guid.NewGuid(),
                    UserInfoId = user.Id,
                    TrackId = model.SelectedTrackId.Value,
                    CategoryId = model.SelectedCategoryId.HasValue ? model.SelectedCategoryId.Value : null,
                    ApplicationStatusId = context.ApplicationStatuses.FirstOrDefault(e => e.Number == 1)!.Id
                };

                user.Applications.Add(app);
                await context.ApplicationForms.AddAsync(app);
                await context.SaveChangesAsync();
            }
            else
            {
                app.TrackId = model.SelectedTrackId.Value;
                app.CategoryId = model.SelectedCategoryId;
                context.ApplicationForms.Update(app);
                await context.SaveChangesAsync();
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
                foreach (var row in tbl.Rows)
                {
                    row.TableId = tbl.Id;

                    var existingRow = await context.Rows
                        .FirstOrDefaultAsync(r =>
                            r.Id == row.Id && r.TableId == row.TableId &&
                            r.CellVals.Any(c => c.ApplicationId == app.Id));

                    if (existingRow == null)
                    {
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

            await context.SaveChangesAsync();

            if (model.SelectedEditBlockId != null)
            {
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
            }

            await context.SaveChangesAsync();
        }

        public async Task SetCurrentUserNameAsync()
        {
            var user = await GetUserAsync() ?? throw new UnauthorizedAccessException("User unauthorized.");
            user.Name = user.Applications.First().FieldVals.FirstOrDefault(e => e.Field!.Name == "ФИО")!.Value;
            context.Update(user);
            await context.SaveChangesAsync();
        }


        public async Task SetCurrentUserApplicationStatusWaitingForReviewedAsync()
        {
            var user = await GetUserAsync() ?? throw new UnauthorizedAccessException("User unauthorized.");
            var app = user.Applications.FirstOrDefault() ??
                      throw new InvalidOperationException("No application found for the current user.");
            var track = app.Track ?? throw new InvalidOperationException("No track found for the application.");
            var editBlocks = track.EditBlocks;

            if (app.ReviewerId != null)
            {
                app.ReviewerId = null;
                context.Update(app);

                await context.SaveChangesAsync();

                var markBlocks = track.MarkBlocks;

                foreach (var markBlock in markBlocks)
                {
                    var existingBlockReview = context.BlockReviews.FirstOrDefault(e =>
                        e.ApplicationId == app.Id && e.MarkBlockId == markBlock.Id);
                    if (existingBlockReview != null)
                    {
                        existingBlockReview.Commentary = string.Empty;
                        existingBlockReview.Status = false;
                        context.Update(existingBlockReview);
                    }
                }

                await context.SaveChangesAsync();
            }


            foreach (var editBlock in editBlocks)
            {
                var editBlockStatus = await context.EditBlockStatuses
                    .FirstOrDefaultAsync(e => e.ApplicationId == app.Id && e.EditBlockId == editBlock.Id);

                if (editBlockStatus == null || !editBlockStatus.Status)
                {
                    throw new InvalidOperationException(
                        $"EditBlock with ID '{editBlock.Id}' does not have a valid status for this application.");
                }
            }

            var newStatus = await context.ApplicationStatuses.FirstOrDefaultAsync(e => e.Number == 2) ??
                            throw new InvalidOperationException("Application status with number 2 not found.");
            app.ApplicationStatusId = newStatus.Id;
            context.Update(app);
            await context.SaveChangesAsync();
        }

        public async Task SetApplicationStatusReviewProcessAsync(Guid userId)
        {
            var user = await GetUserAsync() ?? throw new UnauthorizedAccessException("User unauthorized.");

            var participant = context.UserInfos
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
                    var existingBlockReview = context.BlockReviews.FirstOrDefault(e =>
                        e.ApplicationId == app.Id && e.MarkBlockId == markBlock.Id);
                    if (existingBlockReview == null)
                    {
                        var blockReview = new BlockReview()
                        {
                            Id = Guid.NewGuid(),
                            MarkBlockId = markBlock.Id,
                            ApplicationId = app.Id
                        };
                        context.Add(blockReview);
                    }
                }

                await context.SaveChangesAsync();
            }
        }

        public async Task<UserInfoModel[]> GetUserInfosModelsAsync()
        {
            var user = await GetUserAsync();
            var userInfos = await context.UserInfos
                .Where(e => e.Applications.Any(a =>
                    a.ApplicationStatus.Number == 2 || a.ApplicationStatus.Number == 3 && a.ReviewerId == user!.Id))
                .ToListAsync();

            var userInfoModels = userInfos
                .Select(e => new UserInfoModel(e))
                .ToArray();

            return userInfoModels; 
        }

        public async Task<ReviewMarkModel> GetUserMarkModelAsync(Guid userInfoId)
        {
            var application = await context.ApplicationForms
                .FirstOrDefaultAsync(x => x.UserInfoId == userInfoId) ?? new();
            var markModel = new ReviewMarkModel(application);
            var blockReviewModels = markModel.ReviewedBlocks.ToList();
            foreach (var markBlock in application.Track.MarkBlocks)
            {
                blockReviewModels.Add(new(application.BlockReviews.FirstOrDefault(e =>
                    e.ApplicationId == application.Id && e.MarkBlockId == markBlock.Id)!));
            }

            markModel.ReviewedBlocks = [.. blockReviewModels];
            return await Task.FromResult(markModel);
        }

        public async Task<MarkBlockModel[]> GetMarkBlockModelsAsync(Guid? trackId)
        {
            var track = await context.Tracks.FirstOrDefaultAsync(x => x.Id == trackId);
            return track?.MarkBlocks.OrderBy(x => x.Number).Select(e => new MarkBlockModel(e)).ToArray() ?? [];
        }

        public async Task<FieldModel[]> GetFieldModelsForMarkBlockAsync(Guid? markBlockId, Guid appId)
        {
            var user = context.ApplicationForms
                           .FirstOrDefaultAsync(e => e.Id == appId).Result!.UserInfo ??
                       throw new InvalidOperationException("User does not exist.");
            var markBlock = await context.MarkBlocks
                .FirstOrDefaultAsync(e => e.Id == markBlockId);
            return markBlock!.Fields.OrderBy(x => x.Number).Select(e => new FieldModel(e, user)).ToArray();
        }

        public async Task<TableModel[]> GetTableModelsForMarkBlockAsync(Guid? markBlockId, Guid appId)
        {
            var markBlock = await context.MarkBlocks
                                .FirstOrDefaultAsync(mb => mb.Id == markBlockId) ??
                            throw new InvalidOperationException("MarkBlock not found");
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
                }).ToArray();

            return tables;
        }

        public async Task ChangeBlockReviewStatus(Guid? markBlockId, Guid? appId)
        {
            var blockReview =
                context.BlockReviews.FirstOrDefault(e => e.MarkBlockId == markBlockId && e.ApplicationId == appId) ??
                throw new NullReferenceException("Current block review not find.");
            blockReview.Status = !blockReview.Status;
            context.Update(blockReview);
            await context.SaveChangesAsync();
        }

        public async Task SaveCommentReviewBlockAsync(Guid? markBlockId, Guid? appId, string? comment)
        {
            var blockReview =
                context.BlockReviews.FirstOrDefault(e => e.MarkBlockId == markBlockId && e.ApplicationId == appId) ??
                throw new NullReferenceException("Current block review not find.");
            blockReview.Commentary = comment;
            context.Update(blockReview);
            await context.SaveChangesAsync();
        }

        private async Task AutoSetMarksWithDynamicMethods(Guid appId)
        {
            var app = await context.ApplicationForms
                          .FirstOrDefaultAsync(e => e.Id == appId)
                      ?? throw new NullReferenceException("Current application not found.");

            foreach (var markBlock in app.Track.MarkBlocks)
            {
                foreach (var mark in markBlock.Marks)
                {
                    if (mark.IsAuto)
                    {
                        var methodName = mark.EvaluationMethodName;
                        var methodInfo = typeof(EvaluationMethods).GetMethod(methodName!,
                            BindingFlags.Static | BindingFlags.Public | BindingFlags.IgnoreCase);

                        if (methodInfo != null)
                        {
                            var result = (int?)methodInfo.Invoke(null,
                                [appId, mark.Id, mark.TableId, context]);

                            var markValRes = new MarkVal
                            {
                                Id = Guid.NewGuid(),
                                MarkId = mark.Id,
                                Mark = mark,
                                ApplicationId = app.Id,
                                Value = result
                            };

                            context.MarkVals.Add(markValRes);
                            await context.SaveChangesAsync();
                        }
                        else
                        {
                            Console.WriteLine($"Метод {methodName} не найден.");
                        }
                    }
                }
            }
        }

        public async Task ApproveApplicationFormAsync(Guid? applicationId)
        {
            var user = await GetUserAsync() ?? throw new UnauthorizedAccessException("User unauthorized.");
            var app = await context.ApplicationForms
                          .FirstOrDefaultAsync(e => e.Id == applicationId) ??
                      throw new NullReferenceException("Current application not found.");
            foreach (var markBlock in app.Track.MarkBlocks)
            {
                if (app.BlockReviews.FirstOrDefault(e => e.ApplicationId == app.Id && e.MarkBlockId == markBlock.Id)!
                        .Status == false)
                    throw new InvalidOperationException($"Does not have a valid status for this application.");
            }

            app.ApplicationStatusId = context.ApplicationStatuses.FirstOrDefault(e => e.Number == 4)!.Id;
            context.Update(app);
            await context.SaveChangesAsync();

            await AutoSetMarksWithDynamicMethods(app.Id);

            await userManager.AddToRoleAsync((await userManager.FindByEmailAsync(user.Username!))!,
                (context.Roles.FirstOrDefaultAsync(r => r.Name == "Participant").Result ??
                 throw new NullReferenceException("Not found role with name 'Participant'")).Name!);
        }

        public async Task RejectApplicationFormAsync(Guid? applicationId)
        {
            var app = await context.ApplicationForms
                          .FirstOrDefaultAsync(e => e.Id == applicationId) ??
                      throw new NullReferenceException("Current application not found.");
            foreach (var markBlock in app.Track.MarkBlocks)
            {
                if (app.BlockReviews.FirstOrDefault(e => e.ApplicationId == app.Id && e.MarkBlockId == markBlock.Id)!
                        .Status == false)
                    throw new InvalidOperationException($"Does not have a valid status for this application.");
            }

            app.ApplicationStatusId = context.ApplicationStatuses.FirstOrDefault(e => e.Number == 5)!.Id;
            context.Update(app);
            await context.SaveChangesAsync();
        }

        public async Task<TrackModel> GetTrackAsync(Guid? trackId)
        {
            return new TrackModel(await context.Tracks.FirstOrDefaultAsync(e => e.Id == trackId) ??
                                  throw new InvalidOperationException("Does not have track for this Id."));
        }

        public async Task<CategoryModel> GetCategoryAsync(Guid? categoryId)
        {
            return new CategoryModel(await context.Categories.FirstOrDefaultAsync(e => e.Id == categoryId) ??
                                     throw new InvalidOperationException("Does not have category for this Id."));
        }

        public async Task<UserInfoModel[]> GetUserInfosModelsAssesmentAsync()
        {
            var userInfos = await context.UserInfos
                .Where(e => e.Applications.Any(a => a.ApplicationStatus.Number == 4))
                .ToListAsync();

            var userInfoModels = userInfos
                .Select(e => new UserInfoModel(e))
                .ToArray();

            return userInfoModels;
        }

        public async Task<AssessmentModel> GetUserAssessmentModelAsync(Guid? userInfoId)
        {
            var user = await context.UserInfos
                           .FirstOrDefaultAsync(e => e.Id == userInfoId) ??
                       throw new UnauthorizedAccessException("User unauthorized.");

            var app = user.Applications.FirstOrDefault() ??
                      throw new InvalidOperationException("Application not found.");

            var assModel = new AssessmentModel(app);
            var markBlocks = context.Tracks
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
                        IsAuto = e.IsAuto,
                        ValId = markVal?.Id ?? Guid.NewGuid()
                    };
                }).ToList();

                resMarks.AddRange(markModels);
            }

            assModel.Marks = [.. resMarks];

            return assModel;
        }

        public async Task<MarkBlockModel[]> GetAssessmentMarkBlockModelsAsync(Guid? trackId, Guid? appId)
        {
            var track = await context.Tracks
                .FirstOrDefaultAsync(x => x.Id == trackId);
            var markBlocks = track?.MarkBlocks.OrderBy(x => x.Number).Select(e => new MarkBlockModel(e)).ToArray() ??
                             [];

            var maxSum = track!.MarkBlocks
                .SelectMany(mb => mb.Marks)
                .Sum(e => e.MaxValue) + 10; //todo: добавить поле оценки зрительских симпатий
            foreach (var markBlock in markBlocks)
            {
                var currentMarkBlock = track.MarkBlocks.FirstOrDefault(mb => mb.Id == markBlock.Id);

                if (currentMarkBlock != null)
                {
                    var sum = currentMarkBlock.Marks
                        .SelectMany(e => e.MarkVals.Where(mv => mv.ApplicationId == appId))
                        .Sum(mv => mv.Value) ?? 0;

                    markBlock.SummaryMarksBlock = sum!;

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
            var user = context.ApplicationForms
                           .FirstOrDefaultAsync(e => e.Id == appId).Result!.UserInfo ??
                       throw new InvalidOperationException("User does not exist.");
            var markBlock = await context.MarkBlocks
                .FirstOrDefaultAsync(e => e.Id == markBlockId);
            var fields = markBlock!.Fields.OrderBy(x => x.Number).Select(e => new FieldMarkModel(e, user)).ToArray();

            foreach (var field in fields)
            {
                field.Marks =
                [
                    .. context.Marks.Where(m => m.FieldId == field.Id).Select(m => new MarkModel()
                    {
                        Id = m.Id,
                        Name = m.Name,
                        Value = m.MarkVals.FirstOrDefault()!.Value ?? 0,
                        MaxValue = m.MaxValue,
                        IsAuto = m.IsAuto,
                        ValId = (m.MarkVals.FirstOrDefault() ?? new MarkVal()).Id
                    })
                ];
            }

            return fields;
        }

        public async Task<TableMarkModel[]> GetTableMarkModelsForMarkBlockAsync(Guid? markBlockId, Guid appId)
        {
            var markBlock = await context.MarkBlocks
                                .FirstOrDefaultAsync(mb => mb.Id == markBlockId) ??
                            throw new InvalidOperationException("MarkBlock not found");
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
                        Value = m.MarkVals.Any(e => e.ApplicationId == appId)
                            ? m.MarkVals.First(e => e.ApplicationId == appId).Value
                            : 0,
                        MaxValue = m.MaxValue,
                        IsAuto = m.IsAuto,
                        ValId = (m.MarkVals.FirstOrDefault(e => e.ApplicationId == appId) ?? new MarkVal()).Id
                    }).ToArray()
                }).ToArray();

            return tables;
        }

        public Task<MarkModel[]> GetMarkModelsForTable(Guid appId, Guid tableId)
        {
            return Task.FromResult(context.Tables
                .FirstOrDefault(e => e.Id == tableId)!.Marks.Select(m => new MarkModel()
                {
                    Id = m.Id,
                    Name = m.Name,
                    MaxValue = m.MaxValue,
                    IsAuto = m.IsAuto,
                    ValId = m.MarkVals.Any(mv => mv.ApplicationId == appId)
                        ? m.MarkVals.First(mv => mv.ApplicationId == appId).Id
                        : Guid.Empty,
                    Value = m.MarkVals.Any(mv => mv.ApplicationId == appId)
                        ? m.MarkVals.First(mv => mv.ApplicationId == appId).Value
                        : 0
                }).ToArray());
        }

        public async Task SaveMarkAsync(MarkModel mark, Guid appId)
        {
            //todo: отслеживание того, кто поставил оценку
            var existingMarkVal = context.MarkVals.FirstOrDefault(mv => mv.Id == mark.ValId);
            if (existingMarkVal == null)
            {
                var markRes = mark.ToEntity();
                markRes.ApplicationId = appId;
                context.MarkVals.Add(markRes);
            }
            else
            {
                existingMarkVal.Value = mark.Value;
                context.MarkVals.Update(existingMarkVal);
            }

            await context.SaveChangesAsync();
        }

        public async Task RatedApplicationAsync(Guid? appId)
        {
            var app = await context.ApplicationForms.FirstOrDefaultAsync(e => e.Id == appId) ??
                      throw new InvalidOperationException("App not found.");
            app.ApplicationStatus = (await context.ApplicationStatuses.FirstOrDefaultAsync(e => e.Number == 6))!;

            context.Update(app);
            await context.SaveChangesAsync();
        }

        public async Task<ListItemModel[]> GetListForVotingPageAsync(Guid trackId, Guid categoryId)
        {
            var user = await GetUserAsync();
            List<ListItemModel> res = [];

            var apps = context.ApplicationForms.Where(e =>
                    e.TrackId == trackId &&
                    e.CategoryId == categoryId &&
                    (e.ApplicationStatusId == context.ApplicationStatuses.FirstOrDefault(s => s.Number == 6)!.Id ||
                     e.ApplicationStatusId == context.ApplicationStatuses.FirstOrDefault(s => s.Number == 4)!.Id))
                .ToList();
            if (user != null && apps.Any(e => e.Votes.Any(v => v.VoterId == user.Id)))
            {
                var currentApp = apps.FirstOrDefault(e => e.Votes.Any(v => v.VoterId == user.Id));
                var curAppModel = new ListItemModel(currentApp!);
                curAppModel.IsVoted = true;
                res.Add(curAppModel);
                apps.Remove(currentApp!);
            }

            res.AddRange(apps.OrderBy(r => Guid.NewGuid()).Select(e => new ListItemModel(e)));
            return res.ToArray();
        }

        public async Task<VoteModel> GetVoteModelAsync(Guid appId)
        {
            var user = await GetUserAsync();
            var app = await context.ApplicationForms.FirstOrDefaultAsync(e => e.Id == appId);
            if (user == null)
            {
                return new VoteModel()
                {
                    Id = app.Id, FullName = app.UserInfo.Name, IsVoteOfThisApplication = false,
                    TotalVotes = app.Votes.Count
                };
            }
            else
            {
                return new VoteModel(app, user.Id);
            }
        }

        public async Task<FieldModel[]> GetFieldModelsForVotePageAsync(Guid appId)
        {
            var app = await context.ApplicationForms
                .FirstOrDefaultAsync(e => e.Id == appId);
            var user = app!.UserInfo;
            var listRes = context.Fields.OrderBy(f => f.Number).Where(e => e.IsDisplayedOnVotingPage)
                .Select(e => new FieldModel(e, user));
            return await listRes.ToArrayAsync();
        }

        public async Task<TableModel[]> GetTableModelsForVotePageAsync(Guid appId)
        {
            var app = await context.ApplicationForms
                .FirstOrDefaultAsync(e => e.Id == appId);

            var tables = context.Tables.Where(t => t.IsDisplayedOnVotingPage).OrderBy(t => t.Number).Select(t =>
                new TableModel
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
                });

            return [.. tables];
        }

        public async Task CastVoteAsync(Guid appId)
        {
            var user = await GetUserAsync() ?? throw new UnauthorizedAccessException("User unauthorized.");
            var app = await context.ApplicationForms.FirstOrDefaultAsync(e => e.Id == appId) ??
                      throw new InvalidOperationException("App not found.");

            if (context.Votes
                .Where(v => v.ApplicationForm.CategoryId == app.CategoryId && v.ApplicationForm.TrackId == app.TrackId)
                .Any(e => e.VoterId == user.Id))
            {
                var vote = context.Votes
                    .Where(v => v.ApplicationForm.CategoryId == app.CategoryId &&
                                v.ApplicationForm.TrackId == app.TrackId).First(e => e.VoterId == user.Id);
                vote.ApplicationFormId = appId;
                vote.VoteTime = DateTime.Now;
                context.Votes.Update(vote);
            }
            else
            {
                context.Votes.Add(new Vote()
                    { Id = Guid.NewGuid(), VoteTime = DateTime.Now, VoterId = user.Id, ApplicationFormId = app.Id });
            }

            await context.SaveChangesAsync();
        }

        public async Task<bool> VoteInThisCategory(Guid trackId, Guid categoryId)
        {
            try
            {
                var user = await GetUserAsync();
                return context.Votes.Any(e =>
                    e.VoterId == user.Id && e.ApplicationForm.TrackId == trackId &&
                    e.ApplicationForm.CategoryId == categoryId);
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}