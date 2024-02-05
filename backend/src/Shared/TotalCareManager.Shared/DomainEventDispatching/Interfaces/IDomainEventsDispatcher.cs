namespace TotalCareManager.Shared.DomainEventDispatching.Interfaces
{
    public interface IDomainEventsDispatcher
    {
        Task DispatchEvents();
    }
}