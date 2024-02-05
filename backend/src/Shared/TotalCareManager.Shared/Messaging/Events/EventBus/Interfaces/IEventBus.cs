using TotalCareManager.Shared.Domain.Interfaces;

namespace TotalCareManager.Shared.Messaging.Events.EventBus.Interfaces
{
    public interface IEventBus : IDisposable
    {
        Task Publish(IDomainEvent @event);
    }
}