using Application.Handlers;
using Application.Interfaces.Handlers;
using Application.Interfaces.Services;
using Application.Mappings;
using Application.Services;
using Domain.Interface.Repository;
using Infra.Context;
using Infra.Options;
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

            services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));

            services.AddScoped<IProjectHandler, ProjectHandler>();
            services.AddScoped<IProjectService, ProjectService>();
            services.AddScoped<IProjectRepository, ProjectRepository>();

            services.AddScoped<ICommentHandler, CommentHandler>();
            services.AddScoped<ICommentService, CommentService>();
            services.AddScoped<ICommentRepository, CommentRepository>();

            services.AddScoped<IAuthService>(provider =>
            {
                var iAuthProvider = provider.GetService<IAuthRepositorty>();
                var securityOptions = provider.GetService<SecurityOptions>();
                return new AuthService(iAuthProvider, securityOptions.SecretKey, securityOptions.Issuer, securityOptions.Audience);
            });
            services.AddScoped<IAuthHandler, AuthHandler>();
            services.AddScoped<IAuthRepositorty, AuthRepositorty>();

            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }

        public static IServiceCollection AddOptionsApi(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<SecurityOptions>(options =>
            {
                options.Issuer = configuration["Jwt:Issuer"];
                options.Audience = configuration["Jwt:Audience"];
                options.SecretKey = configuration["Jwt:SecretKey"];
            });

            return services;
        }
    }
}
