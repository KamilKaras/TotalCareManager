using Microsoft.EntityFrameworkCore;
using TotalCareManager.Shared.Domain;
using TotalCareManager.Shared.Domain.Interfaces;
using TotalCareManager.Shared.DomainEventDispatching.Interfaces;

namespace TotalCareManager.Shared.DomainEventDispatching.Implementations
{
    internal sealed class DomainEventsAccessor<T> : IDomainEventsAccessor
        where T : DbContext
    {
        private readonly T _context;

        public DomainEventsAccessor(T context)
        {
            _context = context;
        }

        public void ClearAllDomainEvents()
        {
            _context.ChangeTracker.Entries<Entity>()
                .Where(w => w.Entity.DomainEvents.Any())
                .ToList()
                .ForEach(f => f.Entity.ClearDomainEvents());
        }

        public IReadOnlyList<IDomainEvent> GetAllDomainEvents()
        {
            var events = _context.ChangeTracker.Entries<Entity>()
                .Where(w => w.Entity.DomainEvents.Any())
                .SelectMany(sm => sm.Entity.DomainEvents)
                .ToList();

            return events;
        }
    }
}