using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using ServerApp.Data.Entities;
using ServerApp.Data.Interfaces;
using System.Security;

namespace ServerApp.Data.Services
{
    public class AppAuthorization(AuthenticationStateProvider userStateProvider, ApplicationDbContext context) : IAuthorization
    {
        public async Task<UserInfo?> GetUserAsync()
        {
            var userState = await userStateProvider.GetAuthenticationStateAsync();
            if (userState == null || userState.User == null || userState.User.Identity == null)
            {
                throw new SecurityException("User is not authorizred to this action.");
            }
            return await context.UserInfos.FirstOrDefaultAsync(x => x.Username == userState.User.Identity!.Name!);
        }
    }
}
