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

        Task<IEnumerable<Mark>> GetMarksAsync();
        Task<Mark> GetMarkByIdAsync(Guid id);
        Task SaveMarkAsync(Mark mark);
        Task RemoveMarkAsync(Mark mark);

        Task<IEnumerable<Field>> GetFieldsAsync();
        Task<Field> GetFieldByIdAsync(Guid id);
        Task SaveFieldAsync(Field field);
        Task RemoveFieldAsync(Field field);
    }
}