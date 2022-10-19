using Contracts;
using LoggerService;
using Microsoft.Extensions.DependencyInjection;

namespace GamesStore.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                {
                    builder.WithOrigins("https://localhost.com")
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });
        }

        public static void ConfigureLoggerServive(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManager>();
        }
    }
}
