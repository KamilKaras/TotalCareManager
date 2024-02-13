using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TotalCareManager.Shared;
using TotalCareManager.Shared.DbAccess;
using TotalCareManager.Shared.DomainEventDispatching.Implementations;
using TotalCareManager.Shared.DomainEventDispatching.Interfaces;
using UserAccess.Aplication.Repositories;
using UserAccess.Infrastructure.Repositories.ClubRegistrations;

namespace UserAccess.Infrastructure
{
    public static class Module
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddRepository(configuration);
            services.AddShared<UserAccessDbContext>();
            return services;
        }

        private static IServiceCollection AddRepository(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddEntityFramework<UserAccessDbContext>(configuration);
            services.AddScoped<IClubRegistrationRepository, ClubRegistrationRepository>();

            return services;
        }
    }
}