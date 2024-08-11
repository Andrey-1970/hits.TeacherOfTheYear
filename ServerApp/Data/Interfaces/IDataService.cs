using ServerApp.Data.Entities;

namespace ServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<UserInfo?> GetCurrentUserInfoAsync();
    }
}
