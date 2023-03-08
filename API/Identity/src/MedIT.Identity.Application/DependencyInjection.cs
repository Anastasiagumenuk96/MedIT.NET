using System.Reflection;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace MedIT.Identity.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        var executingAssembly = Assembly.GetExecutingAssembly();

        services.AddAutoMapper(executingAssembly);
        services.AddMediatR(executingAssembly);

        return services;
    }
}