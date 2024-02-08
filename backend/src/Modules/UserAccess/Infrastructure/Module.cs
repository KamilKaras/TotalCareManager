using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TotalCareManager.Shared;
using TotalCareManager.Shared.DbAccess;
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
            var cs = configuration.GetConnectionString("DataBase");
            services.AddDbContext<UserAccessDbContext>(
                _dbContextBuilder =>
                {
                    _dbContextBuilder.UseNpgsql(cs,
                        builder => builder.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
                    _dbContextBuilder.EnableDetailedErrors();
                    _dbContextBuilder.ReplaceService<IValueConverterSelector, EntityIdValueConverterSelector>();
                });

            services.AddScoped<IClubRegistrationRepository, ClubRegistrationRepository>();

            return services;
        }
    }
}