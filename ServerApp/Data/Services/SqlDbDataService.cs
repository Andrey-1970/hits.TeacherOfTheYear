using Microsoft.EntityFrameworkCore;
using ServerApp.Data.Entities;
using ServerApp.Data.Interfaces;
using ServerApp.Data.Services.Extensions;
using ServerApp.Data.ViewModels;

namespace ServerApp.Data.Services
{
    public class SqlDbDataService(ApplicationDbContext context, IAuthorization auth) : IDataService
    {
        public async Task<ApplicationModel?> GetCurrentUserApplicationAsync()
        {
            var user = await auth.GetUserAsync();
            var application = await context.ApplicationForms.FirstOrDefaultAsync(x => x.UserInfo == user) ?? new();
            return application?.ToModel();
        }

        public async Task<UserInfo?> GetCurrentUserInfoAsync()
        {
            return await auth.GetUserAsync();
        }

        public async Task<TrackModel?> GetTrackByIdAsync(Guid trackId)
        {
            var track = await context.Tracks.FirstOrDefaultAsync(x => x.Id == trackId);
            return track!.ToModel();
        }

        public async Task<IEnumerable<TrackModel>> GetTracksAsync()
        {
            var tracks = await context.Tracks.ToArrayAsync();
            return tracks.Select(t => t.ToModel());
        }

        public async Task SaveApplicationFormAsync(ApplicationModel applicationModel)
        {
            var user = await auth.GetUserAsync();
            var application = await context.ApplicationForms.FirstOrDefaultAsync(x => x.Id == applicationModel.Id);

            if (application == null)
            {
                application = applicationModel.ToEntity();
                context.ApplicationForms.Add(application);
            }
            else
            {
                context.Entry(application).CurrentValues.SetValues(applicationModel);
                if (applicationModel.Track != null)
                {
                    application.Track = applicationModel.Track.ToEntity();
                }
            }

            application.UserInfo = user;

            await context.SaveChangesAsync();
        }
    }
}
