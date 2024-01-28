namespace TotalCareManager.Shared.DomainEventDispatching
{
    public interface IDomainEventsDispatcher
    {
        Task DispatchEvents();
    }
}