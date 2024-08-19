using Microsoft.EntityFrameworkCore;
using Moq;
using ServerApp.Data;
using ServerApp.Data.Entities;
using ServerApp.Data.Interfaces;
using ServerApp.Data.Services;

namespace ServerApp.Tests
{
    [TestClass]
    public class SqlDbDataServiceTests
    {
        private IDataService service;

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

            var userInfo = context.UserInfos.First(x => x.Username == "user@mail.ru");

            var mockOfAuthorization = new Mock<IAuthorization>();
            mockOfAuthorization.Setup(p => p.GetUserAsync())
                .Returns(Task.FromResult<UserInfo?>(userInfo));

            service = new SqlDbDataService(context, mockOfAuthorization.Object);
        }

        [TestMethod]
        public async Task GetCurrentUserInfoValid()
        {
            var userinfo = await service.GetCurrentUserInfoAsync();
            Assert.IsNotNull(userinfo);
            Assert.AreEqual("User 2", userinfo.Name);
        }

        [TestMethod]
        public async Task GetCurrentUserEditModelValid()
        {
            var editModel = await service.GetCurrentUserEditModelAsync();
            Assert.IsNotNull(editModel);
        }

        [TestMethod]
        public async Task GetTrackModelsValid()
        {
            var tracks = await service.GetTrackModelsAsync();
            Assert.IsNotNull(tracks);
        }

            [TestMethod]
        public async Task GetEditBlockModelsValid()
        {
            var tracks = await service.GetTrackModelsAsync();
            var track = tracks.First();
            var editBlocks = await service.GetEditBlockModelsAsync(track.Id);
            Assert.IsNotNull(editBlocks);
        }

        [TestMethod]
        public async Task GetFieldsModelsValid()
        {
            var tracks = await service.GetTrackModelsAsync();
            var track = tracks.First();
            var editBlocks = await service.GetEditBlockModelsAsync(track.Id);
            var editBlock = editBlocks.First();
            var inputs = await service.GetFieldModelsAsync(editBlock.Id);
            Assert.IsNotNull(inputs);
        }

        [TestMethod]
        public async Task GetTablesModelByEditBlockIdAsyncValid()
        {
            var tracks = await service.GetTrackModelsAsync();
            var track = tracks.First();
            var editBlocks = await service.GetEditBlockModelsAsync(track.Id);
            var editBlock = editBlocks.First();
            var tables = await service.GetTableModelsAsync(editBlock.Id);
            Assert.IsNotNull(tables);
        }
    }
}
