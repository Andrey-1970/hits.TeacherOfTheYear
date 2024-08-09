using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ServerApp.Data.Entities;

namespace ServerApp.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<ApplicationForm> ApplicationForms { get; set; }
        public DbSet<CellVal> CellVals { get; set; }
        public DbSet<Column> Columns { get; set; }
        public DbSet<EditBlock> EditBlocks { get; set; }
        public DbSet<Field> Fields { get; set; }
        public DbSet<FieldVal> FieldVals { get; set; }
        public DbSet<IdentifierType> IdentifierTypes { get; set; }
        public DbSet<IdentifierVal> IdentifierVals { get; set; }
        public DbSet<Mark> Marks { get; set; }
        public DbSet<MarkBlock> MarkBlocks { get; set; }
        public DbSet<MarkVal> MarkVals { get; set; }
        public DbSet<Row> Rows { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<UserInfo> UserInfos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<IdentifierType>().HasIndex(i => i.Name).IsUnique();
            builder.Entity<IdentifierVal>().HasIndex(i => new { i.UserInfoId, i.IdentifierId }).IsUnique();
            builder.Entity<MarkBlock>().HasIndex(i => i.Number).IsUnique();
            builder.Entity<MarkBlock>().HasIndex(i => i.Name).IsUnique();

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
