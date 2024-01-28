using Microsoft.EntityFrameworkCore;
using TotalCareManager.Shared.Domain;

namespace TotalCareManager.Shared.DomainEventDispatching
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