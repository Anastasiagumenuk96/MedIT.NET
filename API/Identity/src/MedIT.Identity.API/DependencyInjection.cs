﻿using MedIT.Identity.Infrastructure.Data;

namespace MedIT.Identity.API;

public static class DependencyInjection
{
    public static IServiceCollection AddIdentityApi(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddInfrastructureData(configuration);

        return services;
    }
}