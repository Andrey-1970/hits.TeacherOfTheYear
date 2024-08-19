using Microsoft.EntityFrameworkCore;
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
            return await Task.FromResult(new EditModel(application, context));
        }
        
        public async Task<IEnumerable<TrackModel>> GetTrackModelsAsync()
        {
            return await Task.FromResult(context.Tracks.Select(e => new TrackModel(e)));
        }

        public async Task<IEnumerable<EditBlockModel>> GetEditBlockModelsAsync(Guid? trackId)
        {
            var track = await context.Tracks.Include(track => track.EditBlocks).FirstOrDefaultAsync(x => x.Id == trackId);
            return track?.EditBlocks.OrderBy(x => x.Number).Select(e => new EditBlockModel(e)) ?? [];
        }

        public async Task<FieldModel[]> GetFieldModelsAsync(Guid? editBlockId)
        {
            var editBlock = await context.EditBlocks.Include(editBlock => editBlock.Fields)
                .FirstOrDefaultAsync(e => e.Id == editBlockId);
            return editBlock!.Fields.OrderBy(x => x.Number).Select(e => new FieldModel(e)).ToArray();
        }

        public async Task<TableModel[]> GetTableModelsAsync(Guid? editBlockId)
        {
            var editBlock = await context.EditBlocks.Include(editBlock => editBlock.Tables)
                .FirstOrDefaultAsync(e => e.Id == editBlockId);
            return editBlock!.Tables.OrderBy(x => x.Number).Select(t => new TableModel(t)).ToArray();
        }

        public async Task SaveApplicationFormFromEditModelAsync(EditModel model)
        {
            
        }
    }
}
