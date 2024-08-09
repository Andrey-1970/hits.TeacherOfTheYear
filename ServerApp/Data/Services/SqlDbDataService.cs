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
        public async Task<UserInfo?> GetCurrentUserInfoAsync()
        {
            var username = await auth.GetUsernameAsync();
            return await Task.FromResult(context.UserInfos.FirstOrDefault(x => x.Username == username));
        }

        public async Task<IEnumerable<IdentifierVal>> GetIdentifierValsAsync()
        {
            var username = await auth.GetUsernameAsync();
            if (username == null) return [];

            var user = context.UserInfos.FirstOrDefault(x => x.Username == username);
            var vals = await context.IdentifierVals.ToArrayAsync();
            if (vals.Length == 0)
            {
                vals = await context.IdentifierTypes
                    .Select(idType => new IdentifierVal()
                    {
                        Id = Guid.NewGuid(),
                        UserInfo = user,
                        IdentifierType = idType
                    })
                    .ToArrayAsync();
                await context.IdentifierVals.AddRangeAsync(vals);
                await context.SaveChangesAsync();
            }
            return vals;
        }
    }
}
