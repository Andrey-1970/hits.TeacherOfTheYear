using ServerApp.Data.Entities;
using ServerApp.Data.Models.EditModel;
using ServerApp.Data.Models.ReviewModel;

namespace ServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<UserInfo?> GetCurrentUserInfoAsync();
        Task<EditModel> GetCurrentUserEditModelAsync();
        Task<IEnumerable<TrackModel>> GetTrackModelsAsync();
        Task<IEnumerable<EditBlockModel>> GetEditBlockModelsAsync(Guid? trackId);
        Task<FieldModel[]> GetFieldModelsForEditBlockAsync(Guid? editBlockId);
        Task<TableModel[]> GetTableModelsForEditBlockAsync(Guid? editBlockId);
        Task<RowModel> GetRowModelAsync(Guid? tableId);
        Task DeleteRowAsync(Guid rowId);
        Task SaveApplicationFormFromEditModelAsync(EditModel model);
        Task SetCurrentUserApplicationStatusWaitingForReviewedAsync();
        Task<UserInfoModel[]> GetUserInfosModelsAsync();
        Task<MarkModel> GetUserMarkModelAsync(Guid userInfoId);
        Task<MarkBlockModel[]> GetMarkBlockModelsAsync(Guid? trackId);
        Task<FieldModel[]> GetFieldModelsForMarkBlockAsync(Guid? markBlockId, Guid appId);
        Task<TableModel[]> GetTableModelsForMarkBlockAsync(Guid? markBlockId, Guid appId);
    }
}
