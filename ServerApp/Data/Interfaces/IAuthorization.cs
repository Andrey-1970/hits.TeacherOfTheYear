using ServerApp.Data.Entities;

namespace ServerApp.Data.Interfaces
{
    public interface IAuthorization
    {
        // Task<UserInfo?> GetUserAsync();
        Task<string> GetCurrentUserUsername();
    }
}
