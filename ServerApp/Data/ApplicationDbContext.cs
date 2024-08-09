using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServerApp.Data.Entities;

namespace ServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<UserInfo> UserInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserInfo>().HasData([
                new() { Id = Guid.NewGuid(), Name="User 1", Username="admin@mail.ru"},
                new() { Id = Guid.NewGuid(), Name="User 2", Username="user@mail.ru"},
            ]);
        }
    }
}
