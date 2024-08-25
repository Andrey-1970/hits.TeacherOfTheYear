using ServerApp.Data.Entities;

namespace ServerApp.Data.Interfaces
{
    public interface ITest<T> where T : BaseEntity
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(Guid id);
        Task SaveAsync(T item);
        Task RemoveAsync(T item);
    }
}
