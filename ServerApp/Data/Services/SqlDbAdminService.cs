using Microsoft.EntityFrameworkCore;
using ServerApp.Data.Entities;
using ServerApp.Data.Interfaces;

namespace ServerApp.Data.Services
{
    public class SqlDbAdminService(ApplicationDbContext context) : IAdminService
    {
        public async Task<Track> GetTrackByIdAsync(Guid id)
        {
            return await Task.FromResult(context.Tracks.First(x => x.Id == id));
        }

        public async Task<IEnumerable<Track>> GetTracksAsync()
        {
            return await context.Tracks.ToArrayAsync();
        }

        public async Task RemoveTrackAsync(Track track)
        {
            context.Tracks.Remove(track);
            await context.SaveChangesAsync();
        }

        public async Task SaveTrackAsync(Track track)
        {
            context.Tracks.Attach(track);
            await context.SaveChangesAsync();
        }

        public async Task<EditBlock> GetEditBlockByIdAsync(Guid id)
        {
            return await Task.FromResult(context.EditBlocks.First(x => x.Id == id));
        }

        public async Task<IEnumerable<EditBlock>> GetEditBlocksAsync()
        {
            return await context.EditBlocks.ToArrayAsync();
        }

        public async Task RemoveEditBlockAsync(EditBlock EditBlock)
        {
            context.EditBlocks.Remove(EditBlock);
            await context.SaveChangesAsync();
        }

        public async Task SaveEditBlockAsync(EditBlock EditBlock)
        {
            context.EditBlocks.Attach(EditBlock);
            await context.SaveChangesAsync();
        }
    }
}