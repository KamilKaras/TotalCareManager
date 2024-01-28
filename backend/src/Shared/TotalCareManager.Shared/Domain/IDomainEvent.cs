using MediatR;

namespace TotalCareManager.Shared.Domain
{
    public interface IDomainEvent : INotification
    {
        Guid Id { get; }
        DateTimeOffset OccurredOn { get; }
    }
}