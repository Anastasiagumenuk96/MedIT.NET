using MedIT.Identity.Application;
using MedIT.Identity.Infrastructure;
using MedIT.Identity.Infrastructure.Data;

namespace MedIT.Identity.API;

public static class DependencyInjection
{
    public static IServiceCollection AddIdentityApi(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddInfrastructureData(configuration);
        services.AddInfrastructure();
        services.AddApplication();

        return services;
    }
}