using Application.Repositories.Interfaces;
using Infrastructure.Database;
using Infrastructure.Database.Repositories;
using Microsoft.EntityFrameworkCore;

namespace WebCar.StartupExtensions
{
    public static class ServiceStartupExtensions
    {
        public static IServiceCollection ConfigureAppDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("WebCar");

            services.AddDbContext<WebCarDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
                options.UseLoggerFactory(LoggerFactory.Create(builder => builder.AddDebug()));
            }, ServiceLifetime.Scoped);


            return services;
        }

        public static IServiceCollection ConfigureAppServices(this IServiceCollection services)
        {
            // Repositories
            services.AddScoped<ICarBrandRepository, CarBrandRepository>();
            services.AddScoped<ICarModelRepository, CarModelRepository>();
            services.AddScoped<ITireRepository, TireRepository>();

            return services;
        }
    }
}
