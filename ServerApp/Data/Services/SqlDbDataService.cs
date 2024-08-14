using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using ServerApp.Data.Entities;
using ServerApp.Data.Interfaces;
using System.Security;
using System.Security.Principal;

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
    }
}
