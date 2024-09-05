using Microsoft.AspNetCore.Identity;

namespace ServerApp.Data
{
    // Add profile data for application users by adding properties to the ApplicationUser class
    public class ApplicationUser : IdentityUser
    {
        public DateTimeOffset LastEmailSentDate { get; set; }
    }

}
