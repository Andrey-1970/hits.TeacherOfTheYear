using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServerApp.Data.Entities;

namespace ServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<UserInfo> UserInfos { get; set; }
        public DbSet<IdentifierType> IdentifierTypes { get; set; }
        public DbSet<IdentifierVal> IdentifierVals { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentifierVal>().HasIndex(i => new { i.UserInfoId, i.IdentifierId }).IsUnique();

            UserInfo user1 = new() { Id = Guid.NewGuid(), Name = "User 1", Username = "admin@mail.ru" };
            UserInfo user2 = new() { Id = Guid.NewGuid(), Name = "User 2", Username = "user@mail.ru" };
            builder.Entity<UserInfo>().HasData([user1, user2]);

            IdentifierType idType1 = new() { Id = Guid.NewGuid(), Name = "SCOPUS", NeedValue1 = false };
            IdentifierType idType2 = new() { Id = Guid.NewGuid(), Name = "WOFSCI", NeedValue2 = false };
            builder.Entity<IdentifierType>().HasData([idType1, idType2]);
        }
    }
}
