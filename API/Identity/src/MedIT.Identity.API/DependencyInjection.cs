using MedIT.Identity.Infrastructure;

namespace MedIT.Identity.API;

public static class DependencyInjection
{
    public static IServiceCollection AddIdentityApi(this IServiceCollection services)
    {
        services.AddInfrastructure();

        return services;
    }
}