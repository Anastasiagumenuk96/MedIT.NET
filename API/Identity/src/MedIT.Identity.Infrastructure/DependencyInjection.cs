using MedIT.Identity.Application.Interfaces;
using MedIT.Identity.Domain.Entities;
using MedIT.Identity.Infrastructure.Data.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MedIT.Identity.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        services.AddDbContext<IdentityDbContext>((provider, options) =>
        {
            options.UseNpgsql("", opt => opt.CommandTimeout(250));
        });

        services.AddIdentityCore<User>(options => options.SignIn.RequireConfirmedAccount = true)
            .AddRoles<IdentityRole<Guid>>()
            .AddEntityFrameworkStores<IdentityDbContext>();

        services.AddScoped<IIdentityDbContext>(provider => provider.GetRequiredService<IdentityDbContext>());

        services.AddScoped<DbContext, IdentityDbContext>();

        return services;
    }
}