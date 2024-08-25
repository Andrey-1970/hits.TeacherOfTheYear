using ServerApp.Data.Entities;
using ServerApp.Data.Interfaces;

namespace ServerApp.Data.Services
{
    public class AdminService(ApplicationDbContext context) : IAdmin
    {
        public IAdminBase<Track> Track => new AdminBaseService<Track>(context);

        public IAdminBase<EditBlock> EditBlock => new AdminBaseService<EditBlock>(context);

        public IAdminBase<MarkBlock> MarkBlock => new AdminBaseService<MarkBlock>(context);

        public IAdminBase<Mark> Mark => new AdminBaseService<Mark>(context);

        public IAdminBase<Field> Field => new AdminBaseService<Field>(context);
    }
}
