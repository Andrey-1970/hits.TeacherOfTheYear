using Microsoft.AspNetCore.Identity;
using ServerApp.Data;

namespace ServerApp.Components.Account
{
    internal sealed class IdentityUserAccessor(UserManager<ApplicationUser> userManager, IdentityRedirectManager redirectManager)
    {
        public async Task<ApplicationUser> GetRequiredUserAsync(HttpContext context)
        {
            var user = await userManager.GetUserAsync(context.User);

            if (user is null)
            {
                redirectManager.RedirectToWithStatus("account/invalid-user", $"Ошибка: Невозможен вход пользователя с ID '{userManager.GetUserId(context.User)}'.", context);
            }

            return user;
        }
    }
}
