using Microsoft.EntityFrameworkCore;
using TotalCareManager.Shared.DbAccess.Interfaces;

namespace TotalCareManager.Shared.DbAccess.Implementations
{
    internal sealed class UnitOfWork<TDbContext> : IUnitOfWork
        where TDbContext : DbContext
    {
        public UnitOfWork(TDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        private TDbContext _dbContext { get; set; }

        public async Task SaveChangesAsync(CancellationToken cancellationToken)
        {
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}