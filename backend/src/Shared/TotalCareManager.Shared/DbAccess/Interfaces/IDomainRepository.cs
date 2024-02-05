using TotalCareManager.Shared.Domain;
using TotalCareManager.Shared.Exceptions;

namespace TotalCareManager.Shared.DbAccess.Interfaces
{
    public interface IDomainRepository<TEntity, TEntityId>
        where TEntity : Entity<TEntityId>
        where TEntityId : EntityId
    {
        Task<TEntity?> GetAsync(TEntityId id);

        Task AddAsync(TEntity entity);
    }
}