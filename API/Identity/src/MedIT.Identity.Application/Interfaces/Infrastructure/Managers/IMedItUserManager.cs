using MedIT.Identity.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace MedIT.Identity.Application.Interfaces.Infrastructure.Managers;

public interface IMedItUserManager
{
    Task<IdentityResult> CreateAsync(User user, string password);
    Task<User?> FindByNameAsync(string userName);
    Task<IList<string>> GetRolesAsync(User user);
}