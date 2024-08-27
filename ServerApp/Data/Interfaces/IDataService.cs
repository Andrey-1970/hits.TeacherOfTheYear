using ServerApp.Data.Entities;
using ServerApp.Data.Models.EditModel;
using ServerApp.Data.Models.MarkModel;
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
        Task SetApplicationStatusReviewProcessAsync(Guid appId);
        Task<UserInfoModel[]> GetUserInfosModelsAsync();
        Task<ReviewMarkModel> GetUserMarkModelAsync(Guid userInfoId);
        Task<MarkBlockModel[]> GetMarkBlockModelsAsync(Guid? trackId);
        Task<FieldModel[]> GetFieldModelsForMarkBlockAsync(Guid? markBlockId, Guid appId);
        Task<TableModel[]> GetTableModelsForMarkBlockAsync(Guid? markBlockId, Guid appId);
        Task ChangeBlockReviewStatus(Guid? blockReviewId, Guid? appId);
        Task SaveCommentReviewBlockAsync(Guid? markBlockId, Guid? appId, string? comment);
        Task ApproveApplicationFormAsync(Guid? applicationId);
        Task RejectApplicationFormAsync(Guid? applicationId);
        Task<TrackModel> GetTrackAsync(Guid? trackId);
        
        //Новые методы для страницы оценки
        Task<AssessmentModel> GetUserAssessmentModelAsync(Guid? userInfoId);
        Task<MarkBlockModel[]> GetAssessmentMarkBlockModelsAsync(Guid? trackId);
        Task<FieldMarkModel[]> GetFieldMarkModelsForMarkBlockAsync(Guid? markBlockId, Guid appId);
        Task<TableMarkModel[]> GetTableMarkModelsForMarkBlockAsync(Guid? markBlockId, Guid appId);
    }
}
