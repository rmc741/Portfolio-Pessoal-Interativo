using Application.Handlers;
using Application.Interfaces.Handlers;
using Application.Interfaces.Services;
using Application.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public static class DependecyInjectionApi
    {
        public static IServiceCollection AddInfrastructureApi(this IServiceCollection services)
        {
            services.AddSingleton<IProjectHandler,ProjectHandler>();
            services.AddSingleton<IProjectService, ProjectService>();

            return services;
        }

        public static IServiceCollection AddOptionsApi(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
