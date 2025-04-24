
using Contracts;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Contracts;
using Services;

namespace api;
public static class ServiceExtensions
{
    /// <summary>
    /// Adds API services to the service collection
    /// </summary>
    /// <param name="services">The service collection</param>
    /// <returns>The service collection for chaining</returns>
    public static IServiceCollection AddApiServices(this IServiceCollection services)
    {
        // Add your API services here
        return services;
    }

    /// <summary>
    /// Configures CORS (Cross-Origin Resource Sharing) for the application
    /// </summary>
    public static IServiceCollection ConfigureCors(this IServiceCollection services, string policyName = "CorsPolicy", string[]? allowedOrigins = null)
    {
        services.AddCors(options =>
        {
            options.AddPolicy(policyName, builder =>
            {
                builder = builder.AllowAnyHeader()
                               .AllowAnyMethod();


                if (allowedOrigins != null && allowedOrigins.Length > 0)
                {
                    builder.WithOrigins(allowedOrigins);
                }
                else
                {
                    builder.AllowAnyOrigin();
                }
            });
        });

        return services;
    }

    public static IServiceCollection ConfigureIISIntegration(this IServiceCollection services)
    {
        services.Configure<IISOptions>(options =>
        {
            options.AutomaticAuthentication = true;
            options.ForwardClientCertificate = true;
        });

        return services;
    }

    public static void ConfigureRepositoryManager(this IServiceCollection services) =>
    services.AddScoped<IRepositoryManager, RepositoryManager>();

    public static void ConfigureServiceManager(this IServiceCollection services) =>
         services.AddScoped<IServiceManager, ServiceManager>();

    public static void ConfigureSqlContext(this IServiceCollection services,
        IConfiguration configuration) => services.AddDbContext<RepositoryContext>(opts =>
        opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

}
