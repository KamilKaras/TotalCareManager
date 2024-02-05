using Microsoft.EntityFrameworkCore;
using TotalCareManager.Shared.DbAccess.Interfaces;
using TotalCareManager.Shared.Domain;
using TotalCareManager.Shared.Exceptions;

namespace TotalCareManager.Shared.DbAccess.Implementations
{
    public abstract class DomainRepository<TEntity, TEntityId> : IDomainRepository<TEntity, TEntityId>
        where TEntity : Entity<TEntityId>
        where TEntityId : EntityId
    {
        protected readonly DbContext _dbContext;

        protected DomainRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbContext.AddAsync(entity);
        }

        public async Task<TEntity?> GetAsync(TEntityId id)
        {
            return await _dbContext.Set<TEntity>()
                .FirstOrDefaultAsync(f => f.Id == id);
        }
    }
}