using Contracts.Repositories;
using Contracts.Services;
using Entities.Context;
using Generics.Settings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repositories;
using Services;

namespace Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureServices(this IServiceCollection services)
        {
            services.AddControllers()
                .AddNewtonsoftJson(opt =>
                    opt.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
            services.ConfigureSqlContext();
            services.ConfigureWrappers();
        }

        public static void ConfigureSqlContext(this IServiceCollection services)
        {
            services.AddDbContext<DashboardContext>(options =>
            {
                options.UseSqlServer(Database.ConnectionString, opt => opt.EnableRetryOnFailure());
            });
        }

        public static void ConfigureWrappers(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
            services.AddScoped<IServiceWrapper, ServiceWrapper>();
        }
    }
}