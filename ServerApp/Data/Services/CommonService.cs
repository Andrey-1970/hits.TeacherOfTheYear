using ServerApp.Data.Entities;
using ServerApp.Data.Interfaces;

namespace ServerApp.Data.Services
{
    public class CommonService(ApplicationDbContext context) : ICommon
    {
        public ITest<Track> Tracks => new TestService<Track>(context);

        public ITest<EditBlock> EditBlocks => new TestService<EditBlock>(context);
    }
}
