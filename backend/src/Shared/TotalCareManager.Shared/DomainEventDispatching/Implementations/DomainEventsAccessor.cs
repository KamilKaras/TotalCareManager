using Microsoft.EntityFrameworkCore;
using TotalCareManager.Shared.Domain;
using TotalCareManager.Shared.Domain.Interfaces;

namespace TotalCareManager.Shared.DomainEventDispatching.Implementations
{
    public abstract class DomainEventsAccessor
    {
        protected void ClearAllDomainEvents<T>(T context)
            where T : DbContext
        {
            context.ChangeTracker.Entries<Entity>()
                .Where(w => w.Entity.DomainEvents.Any())
                .ToList()
                .ForEach(f => f.Entity.ClearDomainEvents());
        }

        protected IReadOnlyList<IDomainEvent> GetAllDomainEvents<T>(T context)
            where T : DbContext
        {
            var events = context.ChangeTracker.Entries<Entity>()
                .Where(w => w.Entity.DomainEvents.Any())
                .SelectMany(sm => sm.Entity.DomainEvents)
                .ToList();

            return events;
        }
    }
}