using Application.Handlers;
using Application.Interfaces.Handlers;
using Application.Interfaces.Services;
using Application.Mappings;
using Application.Services;
using Domain.Interface.Repository;
using Infra.Context;
using Infra.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace IoC
{
    public static class DependecyInjectionApi
    {
        public static IServiceCollection AddInfrastructureApi(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
             options.UseNpgsql(configuration.GetConnectionString("PortfolioDatabase"),
             b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IProjectHandler, ProjectHandler>();
            services.AddScoped<IProjectService, ProjectService>();

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<IProjectRepository, ProjectRepository>();

            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }

        public static IServiceCollection AddOptionsApi(this IServiceCollection services, IConfiguration configuration)
        {
            return services;
        }
    }
}
