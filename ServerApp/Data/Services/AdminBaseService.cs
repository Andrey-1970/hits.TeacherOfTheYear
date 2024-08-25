using ServerApp.Data.Entities;
using ServerApp.Data.Interfaces;

namespace ServerApp.Data.Services
{
    public class AdminBaseService<T>(ApplicationDbContext context) : IAdminBase<T> where T : BaseEntity
    {
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await Task.FromResult<IEnumerable<T>>(context.Set<T>());
        }

        public async Task<T> GetByIdAsync(Guid id)
        {
            return await Task.FromResult<T>(context.Set<T>().First(x => x.Id == id));
        }

        public async Task RemoveAsync(T item)
        {
            context.Set<T>().Remove(item);
            await context.SaveChangesAsync();
        }

        public async Task SaveAsync(T item)
        {
            context.Set<T>().Attach(item);
            await context.SaveChangesAsync();
        }
    }
}
