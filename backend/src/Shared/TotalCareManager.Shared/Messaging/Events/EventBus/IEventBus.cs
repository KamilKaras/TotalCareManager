using TotalCareManager.Shared.Domain;

namespace TotalCareManager.Shared.Messaging.Events.EventBus
{
    public interface IEventBus : IDisposable
    {
        Task Publish(IDomainEvent @event);
    }
}