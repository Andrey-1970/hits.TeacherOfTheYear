using ServerApp.Components.Pages;
using ServerApp.Components.Shared;
using ServerApp.Data.Entities;
using ServerApp.Data.Models.EditModel;
using ServerApp.Data.Models.InspectionModel;
using ServerApp.Data.Models.MarkModel;
using ServerApp.Data.Models.ReviewModel;
using ServerApp.Data.Models.VoteModel;

namespace ServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<string?> GetCropPhotoCurrentUserAsync();
        Task<string> GetCropPhotoAsync(Guid appId);
        Task<Components.Pages.ApplicationForm.PhotoData?> GetCurrentUserPhotoAsync();
        Task SavePhotoAsync(string base64Data, PhotoEditorModal.CropCoordinates cropCoordinates);
        Task<Guid?> GetCategoryIdFromEmail(string email);
        Task SaveExpertCategoryId(string email, Guid categoryId);
        Task DeleteUserInfoAsync(Guid userId);
        Task SetDatetimeNowForApplicationAync(Guid? appId);
        Task<List<string>?> GetCommentsForApplicationAsync(Guid? appId);
        Task DeleteApplicationAsync(Guid appId);
        Task WithdrawApplicationAsync(Guid appId);
        Task<ApplicationFormVoteModel> GetApplicationAsync(Guid applicationId, Guid? userId);
        Task CreateCurrentUserInfoAsync(string username);
        Task<string> GetApplicationStatusNameAsync();
        Task<UserInfo?> GetCurrentUserInfoAsync();
        Task<CategoryModel[]> GetCategoryModelsAsync();
        Task<EditModel> GetCurrentUserEditModelAsync();
        Task<TrackModel[]> GetTrackModelsAsync();
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
        Task ChangeBlockReviewStatusAsync(Guid? blockReviewId, Guid? appId);
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
        Task<MarkModel[]> GetMarkModelsForTableAsync(Guid appId, Guid tableId);
        Task SaveMarkAsync(MarkModel mark, Guid appId);
        Task RatedApplicationAsync(Guid appId);
        Task<ApplicationCardModel[]> GetApplicationCardModelsAsync(Guid trackId, Guid categoryId);
        Task<ApplicationFormVoteModel> GetVoteModelAsync(Guid appId);
        Task<FieldModel[]> GetFieldModelsForVotePageAsync(Guid appId);
        Task<TableModel[]> GetTableModelsForVotePageAsync(Guid appId);
        Task CastVoteAsync(Guid appId);
        bool VoteInThisCategoryAsync(Guid? trackId, Guid categoryId, Guid userId);
        Task<FeedBack[]> GetFeedbacksAsync();
        Task SaveFeedbackAsync(FeedBack feedback);
        Task<FeedBack> GetFeedbackAsync(Guid feedbackId);

        Task<Deadline> GetDeadlineAsync(string name);
        Task<string> GetStatusNameAsync(Guid statusId);
        Task<UserInfoModel[]> GetUserInfoModelsAsync(Guid? statusId);
        Task<ApplicationFormInspectionModel> GetApplicationFormInspectionModel(Guid appId);
    }
}
