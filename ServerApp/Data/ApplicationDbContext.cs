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

            builder.Entity<IdentifierType>().HasIndex(i => i.Name).IsUnique();
            builder.Entity<IdentifierVal>().HasIndex(i => new { i.UserInfoId, i.IdentifierId }).IsUnique();

            builder.Entity<UserInfo>().HasData([
                new() { Id = Guid.NewGuid(), Name = "User 1", Username = "admin@mail.ru" },
                new() { Id = Guid.NewGuid(), Name = "User 2", Username = "user@mail.ru" },
            ]);

            builder.Entity<IdentifierType>().HasData([
                new() { Id = Guid.NewGuid(), Name = "SCOPUS", NeedValue1 = false },
                new() { Id = Guid.NewGuid(), Name = "WOFSCI", NeedValue2 = false },
                new() { Id = Guid.NewGuid(), Name = "ORCID" },
            ]);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }
    }
}
