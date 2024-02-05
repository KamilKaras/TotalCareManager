using MediatR;

namespace TotalCareManager.Shared.Domain.Interfaces
{
    public interface IDomainEvent : INotification
    {
        Guid Id { get; }
        DateTimeOffset OccurredOn { get; }
    }
}