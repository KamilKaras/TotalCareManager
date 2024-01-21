using MediatR;

namespace TotalCareManager.Shared.Messaging.Events.IntegrationEvents
{
    public abstract class IntegrationEventHandler<TEvent> : INotificationHandler<TEvent>
        where TEvent : class, IIntegrationEvent
    {
        public Task Handle(TEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}