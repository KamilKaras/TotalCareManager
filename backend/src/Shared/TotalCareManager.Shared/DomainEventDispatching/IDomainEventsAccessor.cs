using TotalCareManager.Shared.Domain;

namespace TotalCareManager.Shared.DomainEventDispatching
{
    public interface IDomainEventsAccessor
    {
        IReadOnlyList<IDomainEvent> GetAllDomainEvents();

        void ClearAllDomainEvents();
    }
}