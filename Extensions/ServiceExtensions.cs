using Contracts.Repositories;
using Entities.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Repositories;

namespace Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureSqlContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetSection("ConnectionString:DashboardAPI").Value;

            services.AddDbContext<DashboardContext>(options =>
            {
                options.UseSqlServer(connectionString, opt => opt.EnableRetryOnFailure());
            });
        }

        public static void ConfigureWrappers(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}