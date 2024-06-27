using Netserv1.APIs;

namespace Netserv1;

public static class ServiceCollectionExtensions
{
    /// <summary>
    /// Add services to the container.
    /// </summary>
    public static void RegisterServices(this IServiceCollection services)
    {
        services.AddScoped<IMuliesService, MuliesService>();
    }
}
