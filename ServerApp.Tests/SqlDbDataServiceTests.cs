using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.EntityFrameworkCore;
using Moq;
using ServerApp.Data;
using ServerApp.Data.Entities;
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
        //private ApplicationDbContext context;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
#pragma warning restore CA1859 // Use concrete types when possible for improved performance

        [TestInitialize]
        public async Task Initialize()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase($@"Data source=TestingDB")
                .Options;
            var context = new ApplicationDbContext(options);
            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();
            if (context.Database.IsInMemory())
            {
                SeedData.Init(context);
            }

            var mockOfAuthenticationStateProvider = new Mock<IAuthorization>();
            mockOfAuthenticationStateProvider.Setup(p => p.GetUserAsync())
                .Returns(Task.FromResult<UserInfo?>(new UserInfo
                {
                    Username = "user@mail.ru",
                    Name = "User 2"
                }));

            service = new SqlDbDataService(context, mockOfAuthenticationStateProvider.Object);
        }
        [TestMethod]
        public async Task GetCurrentUserInfoValid()
        {
            var userinfo = await service.GetCurrentUserInfoAsync();
            Assert.IsNotNull(userinfo);
            Assert.AreEqual("User 2", userinfo.Name);
        }
        [TestMethod]
        public async Task GetTracksValid()
        {
            var tracks = await service.GetTracksAsync();
            Assert.IsNotNull(tracks);
            Assert.AreEqual(2, tracks.Count());
            Assert.IsNotNull(tracks.FirstOrDefault(x => x.Number == 1));
            Assert.IsNotNull(tracks.FirstOrDefault(x => x.Number == 2));
        }
    }
}