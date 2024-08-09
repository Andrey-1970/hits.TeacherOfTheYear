namespace ServerApp.Data.Interfaces
{
    public interface IAuthorization
    {
        Task<string> GetUsernameAsync();
    }
}
