using ServerApp.Data.Entities;
using ServerApp.Data.Models;

namespace ServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<UserInfo?> GetCurrentUserInfoAsync();
        Task<EditModel> GetCurrentUserEditModelAsync();
        Task<IEnumerable<TrackModel>> GetTrackModelsAsync();
        Task<IEnumerable<EditBlockModel>> GetEditBlockModelsAsync(Guid? trackId);
        Task<FieldModel[]> GetFieldModelsAsync(Guid? editBlockId);
        Task<TableModel[]> GetTableModelsAsync(Guid? editBlockId);
    }
}
