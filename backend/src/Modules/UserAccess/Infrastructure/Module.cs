using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TotalCareManager.Shared;
using TotalCareManager.Shared.DbAccess;
using UserAccess.Aplication.Repositories.CompanyRegistrations;
using UserAccess.Aplication.Repositories.UserRegistrations;
using UserAccess.Infrastructure.Repositories.CompanyRegistrations;
using UserAccess.Infrastructure.Repositories.UserRegistrations;

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
            services.AddScoped<ICompanyRegistrationRepository, CompanyRegistrationRepository>();
            services.AddScoped<IUserRegistrationRepository, UserRegistrationRepository>();

            return services;
        }
    }
}