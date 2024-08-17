using Microsoft.EntityFrameworkCore;
using ServerApp.Data.Entities;
using ServerApp.Data.Interfaces;
using ServerApp.Data.Models;
using ServerApp.Data.Services.Extensions;

namespace ServerApp.Data.Services
{
    public class SqlDbDataService(ApplicationDbContext context, IAuthorization auth) : IDataService
    {
        public async Task<ApplicationForm?> GetCurrentUserApplicationAsync()
        {
            var user = await auth.GetUserAsync();
            var application = await context.ApplicationForms.FirstOrDefaultAsync(x => x.UserInfo == user) ?? new();
            return await Task.FromResult(application);
        }

        public async Task<UserInfo?> GetCurrentUserInfoAsync()
        {
            return await auth.GetUserAsync();
        }

        public async Task<Track?> GetTrackByIdAsync(Guid trackId)
        {
            return await context.Tracks.FirstOrDefaultAsync(x => x.Id == trackId);
        }

        public async Task<IEnumerable<Track>> GetTracksAsync()
        {
            return await context.Tracks.ToArrayAsync();
        }

        public async Task SaveApplicationFormAsync(ApplicationForm application)
        {
            application.UserInfo = await auth.GetUserAsync();
            context.ApplicationForms.Attach(application);
            await context.SaveChangesAsync();
        }

        public async Task<DemoEditModel> GetCurrentUserEditModelAsync()
        {
            var user = await auth.GetUserAsync();
            var application = await context.ApplicationForms.FirstOrDefaultAsync(x => x.UserInfo == user) ?? new();
            return await Task.FromResult(application.ToModel(context: context));
        }

        public async Task<IEnumerable<EditBlockModel>> GetEditBlocksModelByTrackId(Guid? trackId)
        {
            var track = await context.Tracks.FirstOrDefaultAsync(x => x.Id == trackId);
            return track?.EditBlocks.OrderBy(x => x.Number).Select(e => e.ToModel()) ?? [];
        }

        public async Task<InputModel[]> GetInputsModelByEditBlockId(Guid? editBlockId, Guid appId)
        {
            var editBlock = await context.EditBlocks.FirstOrDefaultAsync(e => e.Id == editBlockId);
            return editBlock.Fields.OrderBy(x => x.Number).Select(e => e.ToModel(appId)).ToArray();
        }
    }
}
