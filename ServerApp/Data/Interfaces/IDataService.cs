using ServerApp.Data.Entities;

namespace ServerApp.Data.Interfaces
{
    public interface IDataService
    {
        Task<IEnumerable<UserInfo>> GetUserInfosAsync();
    }
}
