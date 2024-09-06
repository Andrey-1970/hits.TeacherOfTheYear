using ServerApp.Data.Entities;
using ServerApp.Data.Models.EditModel;
using ServerApp.Data.Models.MarkModel;
using ServerApp.Data.Models.ReviewModel;
using ServerApp.Data.Models.VoteModel;

namespace ServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task CreateCurrentUserInfoAsync(string username);
        Task<string> GetApplicationStatusNameAsync();
        Task<UserInfo?> GetCurrentUserInfoAsync();
        Task<CategoryModel[]> GetCategoriesAsync();
        Task<EditModel> GetCurrentUserEditModelAsync();
        Task<IEnumerable<TrackModel>> GetTrackModelsAsync();
        Task<IEnumerable<EditBlockModel>> GetEditBlockModelsAsync(Guid? trackId);
        Task<FieldModel[]> GetFieldModelsForEditBlockAsync(Guid? editBlockId);
        Task<TableModel[]> GetTableModelsForEditBlockAsync(Guid? editBlockId);
        Task<RowModel> GetRowModelAsync(Guid? tableId);
        Task DeleteRowAsync(Guid rowId);
        Task SaveApplicationFormFromEditModelAsync(EditModel model);
        Task SetCurrentUserNameAsync();
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
        Task<CategoryModel> GetCategoryAsync(Guid? categoryId);

        //Новые методы для страницы оценки
        Task<UserInfoModel[]> GetUserInfosModelsAssesmentAsync();
        Task<AssessmentModel> GetUserAssessmentModelAsync(Guid? userInfoId);
        Task<MarkBlockModel[]> GetAssessmentMarkBlockModelsAsync(Guid? trackId, Guid? appId);
        Task<FieldMarkModel[]> GetFieldMarkModelsForMarkBlockAsync(Guid? markBlockId, Guid appId);
        Task<TableMarkModel[]> GetTableMarkModelsForMarkBlockAsync(Guid? markBlockId, Guid appId);
        Task<MarkModel[]> GetMarkModelsForTable(Guid appId, Guid tableId);
        Task SaveMarkAsync(MarkModel mark, Guid appId);
        Task RatedApplicationAsync(Guid? appId);
        Task<ListItemModel[]> GetListForVotingPageAsync(Guid trackId, Guid categoryId);
        Task<VoteModel> GetVoteModelAsync(Guid appId);
        Task<FieldModel[]> GetFieldModelsForVotePageAsync(Guid appId);
        Task<TableModel[]> GetTableModelsForVotePageAsync(Guid appId);
        Task CastVoteAsync(Guid appId);
        Task<FeedBack[]> GetFeedbacksAsync();
        Task SaveFeedbackAsync(FeedBack feedback);
        Task<FeedBack> GetFeedbackByIdAsync(Guid feedbackId);
    }
}
