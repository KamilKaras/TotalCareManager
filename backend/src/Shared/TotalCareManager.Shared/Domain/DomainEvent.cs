namespace TotalCareManager.Shared.Domain
{
    public abstract class DomainEvent : IDomainEvent
    {
        public Guid Id => Guid.NewGuid();

        public DateTimeOffset OccurredOn => DateTimeOffset.UtcNow;
    }
}