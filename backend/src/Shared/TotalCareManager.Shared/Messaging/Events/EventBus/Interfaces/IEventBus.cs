using TotalCareManager.Shared.Messaging.Events.IntegrationEvents.Interfaces;

namespace TotalCareManager.Shared.Messaging.Events.EventBus.Interfaces
{
    public interface IEventBus : IDisposable
    {
        Task Publish(IIntegrationEvent @event);
    }
}