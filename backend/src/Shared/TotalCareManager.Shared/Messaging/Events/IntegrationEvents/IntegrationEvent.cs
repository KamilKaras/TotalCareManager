namespace TotalCareManager.Shared.Messaging.Events.IntegrationEvents
{
    public class IntegrationEvent : IIntegrationEvent
    {
        public IntegrationEvent()
        {
            OccuredAt = DateTimeOffset.UtcNow;
        }

        public DateTimeOffset OccuredAt { get; set; }
    }
}