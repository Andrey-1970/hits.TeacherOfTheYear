using ServerApp.Data.Entities;
using ServerApp.Data.ViewModels;

namespace ServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<ApplicationModel?> GetCurrentUserApplicationAsync();
        Task<UserInfo?> GetCurrentUserInfoAsync();
        Task<IEnumerable<TrackModel>> GetTracksAsync();
        Task<TrackModel?> GetTrackByIdAsync(Guid trackId);
        Task SaveApplicationFormAsync(ApplicationModel application);
    }
}
