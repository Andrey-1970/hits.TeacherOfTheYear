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
        private IDataService service = default!;
        private Mock<ApplicationDbContext> mockContext = default!;
        private Mock<IAuthorization> mockOfAuthorization = default!;


        [TestInitialize]
        public async Task Initialize()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
                .UseInMemoryDatabase($@"Data source=TestingDB")
                .Options;

            var context = new ApplicationDbContext(options);
            mockContext = new Mock<ApplicationDbContext>(options);

            await context.Database.EnsureDeletedAsync();
            await context.Database.EnsureCreatedAsync();

            if (context.Database.IsInMemory())
            {
                SeedData.Init(context);
            }

            var userInfo = context.UserInfos.First(x => x.Username == "user@mail.ru");

            mockOfAuthorization = new Mock<IAuthorization>();
            mockOfAuthorization.Setup(p => p.GetUserAsync())
                .Returns(Task.FromResult<UserInfo?>(userInfo));

            //service = new SqlDbDataService(context, mockOfAuthorization.Object);
        }

        [TestMethod]
        public async Task GetCurrentUserInfoValidAsync()
        {
            var userinfo = await service.GetCurrentUserInfoAsync();
            Assert.IsNotNull(userinfo);
            Assert.AreEqual("User 2", userinfo.Name);
        }

        [TestMethod]
        public async Task GetCurrentUserEditModelValidAsync()
        {
            var editModel = await service.GetCurrentUserEditModelAsync();
            Assert.IsNotNull(editModel);
        }

        [TestMethod]
        public async Task GetTrackModelsValidAsync()
        {
            var tracks = await service.GetTrackModelsAsync();
            Assert.IsNotNull(tracks);
        }

        [TestMethod]
        public async Task GetEditBlockModelsValidAsync()
        {
            var tracks = await service.GetTrackModelsAsync();
            var track = tracks.First();
            var editBlocks = await service.GetEditBlockModelsAsync(track.Id);
            Assert.IsNotNull(editBlocks);
        }

        [TestMethod]
        public async Task GetFieldsModelsValidAsync()
        {
            var tracks = await service.GetTrackModelsAsync();
            var track = tracks.First();
            var editBlocks = await service.GetEditBlockModelsAsync(track.Id);
            var editBlock = editBlocks.First();
            var fields = await service.GetFieldModelsForEditBlockAsync(editBlock.Id);
            Assert.IsNotNull(fields);
        }

        [TestMethod]
        public async Task GetTablesModelByEditBlockIdValidAsync()
        {
            var tracks = await service.GetTrackModelsAsync();
            var track = tracks.First();
            var editBlocks = await service.GetEditBlockModelsAsync(track.Id);
            var editBlock = editBlocks.First();
            var tables = await service.GetTableModelsForEditBlockAsync(editBlock.Id);
            Assert.IsNotNull(tables);
        }

        [TestMethod]
        public async Task GetSelectValuesValidAsync()
        {
            var tracks = await service.GetTrackModelsAsync();
            var track = tracks.First();
            var editBlocks = await service.GetEditBlockModelsAsync(track.Id);
            var editBlock = editBlocks.First(x => x.Name == "Категория участников");
            var fields = await service.GetFieldModelsForEditBlockAsync(editBlock.Id);
            Assert.AreEqual(6, fields.First().SelectValues.Count());
            Assert.AreEqual(0, fields.First(x => x.Name == "Ссылка на конкурсную работу").SelectValues.Count());
        }
    }
}
