using TotalCareManager.Shared.Domain.Interfaces;

namespace TotalCareManager.Shared.DomainEventDispatching.Interfaces
{
    public interface IDomainEventsAccessor
    {
        IReadOnlyList<IDomainEvent> GetAllDomainEvents();

        void ClearAllDomainEvents();
    }
}