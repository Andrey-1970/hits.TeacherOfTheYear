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
        public async Task GetTracksValid()
        {
            var tracks = await service.GetTracksAsync();
            Assert.IsNotNull(tracks);
            Assert.AreEqual(2, tracks.Count());
            Assert.IsNotNull(tracks.FirstOrDefault(x => x.Number == 1));
            Assert.IsNotNull(tracks.FirstOrDefault(x => x.Number == 2));
        }

        [TestMethod]
        public async Task GetFieldValValid()
        {
            var userinfo = await service.GetCurrentUserInfoAsync();
            var tracks = await service.GetTracksAsync();
            var track = tracks.First();
            var editBlock = track.EditBlocks.First();

            ApplicationForm application = new() { UserInfo = userinfo, Track = track };

            await service.SaveApplicationFormAsync(application);

            var app = await service.GetCurrentUserApplicationAsync();
            Field fld = editBlock.Fields.First();
            FieldVal value = new() { Application = app, Field = fld, Value = "1" };
            fld.FieldVals.Add(value);

            await service.SaveApplicationFormAsync(application);

            var field = editBlock.Fields.First();
            var val = field.FieldVals.First();

            Assert.IsNotNull(val);
            Assert.AreEqual(1, app!.FieldVals.Count);
        }

        [TestMethod]
        public async Task GetTrackByIdValid()
        {
            var tracks = await service.GetTracksAsync();
            var trackId = tracks.First().Id;
            var track = await service.GetTrackByIdAsync(trackId); // Используйте действительный ID
            Assert.IsNotNull(track);
        }

        [TestMethod]
        public async Task GetCurrentUserApplicationValid()
        {
            var application = await service.GetCurrentUserApplicationAsync();
            Assert.IsNotNull(application);
        }

        [TestMethod]
        public async Task GetCurrentUserEditModelValid()
        {
            var editModel = await service.GetCurrentUserEditModelAsync();
            Assert.IsNotNull(editModel);
        }

        [TestMethod]
        public async Task GetEditBlocksModelByTrackIdValid()
        {
            var tracks = await service.GetTracksAsync();
            var track = tracks.First();
            var editBlocks = await service.GetEditBlockModelsAsync(track.Id);
            Assert.IsNotNull(editBlocks);
        }

        [TestMethod]
        public async Task GetInputsModelByEditBlockIdValid()
        {
            var tracks = await service.GetTracksAsync();
            var track = tracks.First();
            var editBlock = track.EditBlocks.First(e => e.Name == "Деятельность");
            var inputs = await service.GetFieldModelsAsync(editBlock.Id);
            Assert.IsNotNull(inputs);
        }

        [TestMethod]
        public async Task GetTablesModelByEditBlockIdAsyncValid()
        {
            var tracks = await service.GetTracksAsync();
            var track = tracks.First();
            var editBlock = track.EditBlocks.First(e => e.Name == "Деятельность");
            var tables = await service.GetTableModelsAsync(editBlock.Id);
            Assert.IsNotNull(tables);
        }
    }
}
