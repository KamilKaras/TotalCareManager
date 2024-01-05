using Microsoft.Extensions.DependencyInjection;
using TotalCareManager.Shared.Domain;
using TotalCareManager.Shared.Messaging;

namespace TotalCareManager.Shared
{
    public static class Module
    {
        public static IServiceCollection AddBus(this IServiceCollection services)
        {
            services.AddSingleton<ICommandBus, CommandBus>();
            return services;
        }
    }
}