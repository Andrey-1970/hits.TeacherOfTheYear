using ServerApp.Data.Entities;

namespace ServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<ApplicationForm?> GetCurrentUserApplicationAsync();
        Task<UserInfo?> GetCurrentUserInfoAsync();
        Task<IEnumerable<Track>> GetTracksAsync();
        Task SaveApplicationFormAsync(ApplicationForm application);
    }
}
