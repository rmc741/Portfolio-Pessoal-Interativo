using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public static class DependecyInjectionApi
    {
        public static IServiceCollection AddInfrastructureApi(this IServiceCollection services)
        {
            return services;
        }

        public static IServiceCollection AddOptionsApi(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
