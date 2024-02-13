using Microsoft.EntityFrameworkCore;

namespace TotalCareManager.Shared.DomainEventDispatching.Interfaces
{
    public interface IDomainEventsDispatcher
    {
        Task DispatchEvents<T>(T context) where T : DbContext;
    }
}