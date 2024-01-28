using Microsoft.Extensions.Logging;
using TotalCareManager.Shared.Messaging.Events.EventBus;

namespace TotalCareManager.Shared.DomainEventDispatching
{
    public sealed class DomainEventsDispatcher : IDomainEventsDispatcher
    {
        private readonly IEventBus _eventBus;
        private readonly IDomainEventsAccessor _domainEventsAccessor;
        private readonly ILogger<DomainEventsDispatcher> _logger;

        public DomainEventsDispatcher(
            IEventBus eventBus,
            IDomainEventsAccessor domainEventsAccessor,
            ILogger<DomainEventsDispatcher> logger)
        {
            _eventBus = eventBus;
            _domainEventsAccessor = domainEventsAccessor;
            _logger = logger;
        }

        public async Task DispatchEvents()
        {
            var events = _domainEventsAccessor.GetAllDomainEvents();

            _logger.LogInformation("DomianEventDispatcher access events amount {count}", events.Count);

            foreach (var @event in events)
            {
                var name = @event.GetType()
                    .FullName;
                try
                {
                    await _eventBus.Publish(@event);

                    _logger.LogInformation("Norification {name} published", name);
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Domain Event {name} disparching error", name);
                }
            }

            _domainEventsAccessor.ClearAllDomainEvents();
        }
    }
}