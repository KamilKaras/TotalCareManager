using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TotalCareManager.Shared.DomainEventDispatching;
using TotalCareManager.Shared.Messaging.Command;
using TotalCareManager.Shared.Messaging.Events.EventBus;

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

            return services;
        }
    }
}