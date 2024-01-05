namespace TotalCareManager.Shared.Domain
{
    public interface IDomainEvent
    {
        Guid Id { get; }
        DateTimeOffset OccurredOn { get; }
    }
}