using ServerApp.Data.Entities;

namespace ServerApp.Data.Interfaces
{
    public interface IAdminService
    {
        Task<IEnumerable<Track>> GetTracksAsync();
        Task<Track> GetTrackByIdAsync(Guid id);
        Task SaveTrackAsync(Track track);
        Task RemoveTrackAsync(Track track);

        Task<IEnumerable<EditBlock>> GetEditBlocksAsync();
        Task<EditBlock> GetEditBlockByIdAsync(Guid id);
        Task SaveEditBlockAsync(EditBlock EditBlock);
        Task RemoveEditBlockAsync(EditBlock EditBlock);
    }
}