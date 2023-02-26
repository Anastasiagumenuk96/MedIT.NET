using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace MedIT.Identity.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());

        return services;
    }
}