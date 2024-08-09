using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using Moq;
using ServerApp.Data;
using ServerApp.Data.Interfaces;
using ServerApp.Data.Services;
using System.Security.Claims;

namespace ServerApp.Tests
{
    [TestClass]
    public class SqlDbDataServiceTests
    {
#pragma warning disable CA1859 // Use concrete types when possible for improved performance
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private IDataService service;
        private ApplicationDbContext context;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CA1859 // Use concrete types when possible for improved performance

        [TestInitialize]
        public void Initialize()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase($@"Data source=TestingDB")
                .Options;
            context = new ApplicationDbContext(options);
            context.Database.EnsureCreated();
            if (context.Database.IsInMemory())
            {
                SeedData.Init(context);
            }

            var mockOfAuthenticationStateProvider = new Mock<IAuthorization>();
            mockOfAuthenticationStateProvider.Setup(p => p.GetUsernameAsync()).Returns(Task.FromResult("user@mail.ru"));

            service = new SqlDbDataService(context, mockOfAuthenticationStateProvider.Object);
        }
        [TestCleanup]
        public void Cleanup()
        {
            this.context.Database.EnsureDeleted();
        }
        [TestMethod]
        public async Task GetCurrentUserInfoValid()
        {
            var userinfo = await service.GetCurrentUserInfoAsync();
            Assert.IsNotNull(userinfo);
            Assert.AreEqual("User 2", userinfo.Name);
        }
        [TestMethod]
        public async Task GetCurrentUserValsValid()
        {
            var vals = await service.GetIdentifierValsAsync();
            Assert.IsNotNull(vals);
            Assert.AreEqual(3, vals.Count());
        }
    }
}