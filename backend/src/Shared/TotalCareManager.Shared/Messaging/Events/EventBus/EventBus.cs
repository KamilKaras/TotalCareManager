using MediatR;
using Microsoft.Extensions.DependencyInjection;
using TotalCareManager.Shared.Domain;

namespace TotalCareManager.Shared.Messaging.Events.EventBus
{
    public class EventBus : IEventBus
    {
        private readonly IServiceScopeFactory _scope;

        public EventBus(IServiceScopeFactory scope)
        {
            _scope = scope;
        }

        public void Dispose()
        {
        }

        public async Task Publish(IDomainEvent @event)
        {
            using var scope = _scope.CreateScope();
            var mediator = scope.ServiceProvider.GetRequiredService<IMediator>();

            await mediator.Publish(@event);
        }
    }
}