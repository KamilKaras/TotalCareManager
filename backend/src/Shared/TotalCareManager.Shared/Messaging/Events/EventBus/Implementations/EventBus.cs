using MediatR;
using Microsoft.Extensions.DependencyInjection;
using TotalCareManager.Shared.Messaging.Events.EventBus.Interfaces;
using TotalCareManager.Shared.Messaging.Events.IntegrationEvents.Interfaces;

namespace TotalCareManager.Shared.Messaging.Events.EventBus.Implementations
{
    internal sealed class EventBus : IEventBus
    {
        private readonly IServiceScopeFactory _scope;

        public EventBus(IServiceScopeFactory scope)
        {
            _scope = scope;
        }

        public void Dispose()
        {
        }

        public async Task Publish(IIntegrationEvent @event)
        {
            using var scope = _scope.CreateScope();
            var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();

            await mediator.Publish(@event);
        }
    }
}