using TotalCareManager.Shared.Messaging.Events.IntegrationEvents.Interfaces;

namespace TotalCareManager.Shared.Messaging.Events.IntegrationEvents.Implementations
{
    public abstract class IntegrationEvent : IIntegrationEvent
    {
        public IntegrationEvent()
        {
            OccuredAt = DateTimeOffset.UtcNow;
        }

        public DateTimeOffset OccuredAt { get; set; }
    }
}