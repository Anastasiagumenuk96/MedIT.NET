using MedIT.Identity.Application.Interfaces.Infrastructure.Managers;
using MedIT.Identity.Infrastructure.Managers;
using Microsoft.Extensions.DependencyInjection;

namespace MedIT.Identity.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddHttpContextAccessor();
        services.AddScoped<IMedItSignInManager, MedItSignInManager>();
        services.AddScoped<IMedItUserManager, MedItUserManager>();

        return services;
    }
}