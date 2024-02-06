using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TotalCareManager.Shared;
using UserAccess.Aplication.Repositories;
using UserAccess.Infrastructure.Repositories;

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
            services.AddDbContext<UserAccessDbContext>(
                _dbContextBuilder =>
                {
                    var cs = configuration.GetConnectionString("Database");
                    _dbContextBuilder.UseNpgsql(cs,
                        builder => builder.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
                    _dbContextBuilder.EnableDetailedErrors();
                });

            services.AddScoped<IClubRegistrationRepository, ClubRegistrationRepository>();

            return services;
        }
    }
}