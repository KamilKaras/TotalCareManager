using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TotalCareManager.Shared.DbAccess
{
    public static class DbInitializerExtension
    {
        public static IServiceCollection AddDBInitializer(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddEntityFramework<T>(this IServiceCollection services, IConfiguration configuration)
           where T : DbContext
        {
            var cs = configuration.GetConnectionString("DataBase");
            services.AddDbContext<T>(
                _dbContextBuilder =>
                {
                    _dbContextBuilder.UseNpgsql(cs,
                        builder => builder.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery));
                    _dbContextBuilder.EnableDetailedErrors();
                    _dbContextBuilder.ReplaceService<IValueConverterSelector, EntityIdValueConverterSelector>();
                });

            services.AddDBInitializer();
            return services;
        }
    }
}