using Application.Handlers;
using Application.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public static class DependecyInjectionApi
    {
        public static IServiceCollection AddInfrastructureApi(this IServiceCollection services)
        {
            services.AddSingleton<IProjectHandler,ProjectHandler>();

            return services;
        }

        public static IServiceCollection AddOptionsApi(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
