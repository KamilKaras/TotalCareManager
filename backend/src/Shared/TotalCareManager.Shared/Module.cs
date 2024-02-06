using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TotalCareManager.Shared.DbAccess.Implementations;
using TotalCareManager.Shared.DbAccess.Interfaces;
using TotalCareManager.Shared.DomainEventDispatching.Implementations;
using TotalCareManager.Shared.DomainEventDispatching.Interfaces;
using TotalCareManager.Shared.Messaging.Command.Implementations;
using TotalCareManager.Shared.Messaging.Command.Interfaces;
using TotalCareManager.Shared.Messaging.Events.EventBus.Implementations;
using TotalCareManager.Shared.Messaging.Events.EventBus.Interfaces;

namespace TotalCareManager.Shared
{
    public static class Module
    {
        public static IServiceCollection AddShared<TDbContext>(this IServiceCollection services)
            where TDbContext : DbContext
        {
            services.AddSingleton<ICommandBus, CommandBus>();
            services.AddSingleton<IEventBus, EventBus>();
            services.AddScoped<IDomainEventsDispatcher, DomainEventsDispatcher>();
            services.AddScoped(typeof(IDomainEventsAccessor), typeof(DomainEventsAccessor<TDbContext>));
            services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork<TDbContext>));

            return services;
        }
    }
}