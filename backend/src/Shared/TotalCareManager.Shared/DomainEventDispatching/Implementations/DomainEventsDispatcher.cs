using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using TotalCareManager.Shared.DomainEventDispatching.Interfaces;

namespace TotalCareManager.Shared.DomainEventDispatching.Implementations
{
    public sealed class DomainEventsDispatcher : DomainEventsAccessor, IDomainEventsDispatcher
    {
        private readonly IPublisher _publisher;
        private readonly ILogger<DomainEventsDispatcher> _logger;

        public DomainEventsDispatcher(
            IPublisher publisher,
            ILogger<DomainEventsDispatcher> logger)
        {
            _publisher = publisher;
            _logger = logger;
        }

        public async Task DispatchEvents<T>(T context)
            where T : DbContext
        {
            var events = GetAllDomainEvents(context);

            _logger.LogInformation("DomianEventDispatcher access events amount {count}", events.Count);

            foreach (var @event in events)
            {
                var name = @event.GetType()
                    .FullName;
                try
                {
                    await _publisher.Publish(@event);

                    _logger.LogInformation("Notification {name} published", name);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Domain Event {name} disparching error", name);
                }
            }

            ClearAllDomainEvents(context);
        }
    }
}