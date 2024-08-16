using ServerApp.Data.Entities;
using ServerApp.Data.Models;

namespace ServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<ApplicationForm?> GetCurrentUserApplicationAsync();
        Task<UserInfo?> GetCurrentUserInfoAsync();
        Task<IEnumerable<Track>> GetTracksAsync();
        Task<Track?> GetTrackByIdAsync(Guid trackId);
        Task SaveApplicationFormAsync(ApplicationForm application);
        Task<DemoEditModel> GetCurrentUserEditModelAsync();
        Task<IEnumerable<EditBlockModel>> GetEditBlocksModelByTrackId(Guid? trackId);
        Task<IEnumerable<InputModel>> GetInputsModelByEditBlockId(Guid? editBlockId);
    }
}
