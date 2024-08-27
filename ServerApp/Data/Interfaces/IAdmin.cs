using ServerApp.Data.Entities;

namespace ServerApp.Data.Interfaces
{
    public interface IAdmin
    {
        IAdminBase<Track> Track { get; }
        IAdminBase<EditBlock> EditBlock { get; }
        IAdminBase<MarkBlock> MarkBlock { get; }
        IAdminBase<Mark> Mark { get; }
        IAdminBase<Field> Field { get; }
        IAdminBase<Table> Table { get; }
        IAdminBase<Column> Column { get; }
    }
}
