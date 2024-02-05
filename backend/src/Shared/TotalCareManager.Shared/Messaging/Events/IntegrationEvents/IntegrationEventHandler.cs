using MediatR;
using TotalCareManager.Shared.Domain.Interfaces;
using TotalCareManager.Shared.Messaging.Command.Interfaces;

namespace TotalCareManager.Shared.Messaging.Events.IntegrationEvents
{
    public abstract class IntegrationEventHandler<TEvent> : INotificationHandler<TEvent>
        where TEvent : class, IDomainEvent
    {
        protected readonly ICommandBus _comandBus;

        public IntegrationEventHandler(ICommandBus comandBus)
        {
            _comandBus = comandBus;
        }

        public Task Handle(TEvent notification, CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}