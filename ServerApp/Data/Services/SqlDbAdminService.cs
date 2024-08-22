using Microsoft.EntityFrameworkCore;
using ServerApp.Data.Entities;
using ServerApp.Data.Interfaces;

namespace ServerApp.Data.Services
{
    public class SqlDbAdminService(ApplicationDbContext context) : IAdminService
    {
        #region Tracks

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

        #endregion

        #region EditBlocks

        public async Task<EditBlock> GetEditBlockByIdAsync(Guid id)
        {
            return await Task.FromResult(context.EditBlocks.First(x => x.Id == id));
        }

        public async Task<IEnumerable<EditBlock>> GetEditBlocksAsync()
        {
            return await context.EditBlocks.ToArrayAsync();
        }

        public async Task RemoveEditBlockAsync(EditBlock editBlock)
        {
            context.EditBlocks.Remove(editBlock);
            await context.SaveChangesAsync();
        }

        public async Task SaveEditBlockAsync(EditBlock editBlock)
        {
            context.EditBlocks.Attach(editBlock);
            await context.SaveChangesAsync();
        }

        #endregion

        #region MarkBlocks

        public async Task<MarkBlock> GetMarkBlockByIdAsync(Guid id)
        {
            return await Task.FromResult(context.MarkBlocks.First(x => x.Id == id));
        }

        public async Task<IEnumerable<MarkBlock>> GetMarkBlocksAsync()
        {
            return await context.MarkBlocks.ToArrayAsync();
        }

        public async Task RemoveMarkBlockAsync(MarkBlock markBlock)
        {
            context.MarkBlocks.Remove(markBlock);
            await context.SaveChangesAsync();
        }

        public async Task SaveMarkBlockAsync(MarkBlock markBlock)
        {
            context.MarkBlocks.Attach(markBlock);
            await context.SaveChangesAsync();
        }

        #endregion
    }
}