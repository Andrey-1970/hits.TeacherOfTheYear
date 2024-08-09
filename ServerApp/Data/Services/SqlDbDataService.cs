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
        public async Task<IEnumerable<IdentifierType>> GetIdentifierTypesAsync()
        {
            return await context.IdentifierTypes.ToArrayAsync();
        }

        public async Task<IEnumerable<UserInfo>> GetUserInfosAsync()
        {
            var username = await auth.GetUsernameAsync();
            return await context.UserInfos.Where(x => x.Username == username).ToArrayAsync();
        }
    }
}
