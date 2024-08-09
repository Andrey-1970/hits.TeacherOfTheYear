using Microsoft.AspNetCore.Components.Authorization;
using ServerApp.Data.Interfaces;
using System.Security;

namespace ServerApp.Data.Services
{
    public class AppAuthorization(AuthenticationStateProvider userStateProvider) : IAuthorization
    {
        public async Task<string> GetUsernameAsync()
        {
            var userState = await userStateProvider.GetAuthenticationStateAsync();
            if (userState == null || userState.User == null || userState.User.Identity == null)
            {
                throw new SecurityException("User is not authorizred to this action.");
            }
            return userState!.User!.Identity!.Name!;
        }
    }
}
