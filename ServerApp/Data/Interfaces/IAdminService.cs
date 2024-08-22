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
        Task SaveEditBlockAsync(EditBlock editBlock);
        Task RemoveEditBlockAsync(EditBlock editBlock);

        Task<IEnumerable<MarkBlock>> GetMarkBlocksAsync();
        Task<MarkBlock> GetMarkBlockByIdAsync(Guid id);
        Task SaveMarkBlockAsync(MarkBlock markBlock);
        Task RemoveMarkBlockAsync(MarkBlock markBlock);
    }
}