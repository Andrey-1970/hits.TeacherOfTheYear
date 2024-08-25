using ServerApp.Data.Entities;

namespace ServerApp.Data.Interfaces
{
    public interface ICommon
    {
        ITest<Track> Tracks { get; }
        ITest<EditBlock> EditBlocks { get; }
    }
}
