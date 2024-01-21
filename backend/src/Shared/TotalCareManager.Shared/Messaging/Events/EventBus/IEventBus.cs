using TotalCareManager.Shared.Messaging.Events.IntegrationEvents;

namespace TotalCareManager.Shared.Messaging.Events.EventBus
{
    public interface IEventBus : IDisposable
    {
        Task Publish(IIntegrationEvent @event);
    }
}