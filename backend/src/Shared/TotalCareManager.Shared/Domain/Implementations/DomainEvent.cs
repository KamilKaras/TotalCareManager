using TotalCareManager.Shared.Domain.Interfaces;

namespace TotalCareManager.Shared.Domain.Implementations
{
    public abstract class DomainEvent : IDomainEvent
    {
        public Guid Id => Guid.NewGuid();

        public DateTimeOffset OccurredOn => DateTimeOffset.UtcNow;
    }
}