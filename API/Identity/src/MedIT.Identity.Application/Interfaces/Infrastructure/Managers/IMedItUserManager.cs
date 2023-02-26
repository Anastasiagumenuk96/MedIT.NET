using MedIT.Identity.Domain.Entities;

namespace MedIT.Identity.Application.Interfaces.Infrastructure.Managers;

public interface IMedItUserManager
{
    Task<User?> FindByNameAsync(string userName);
    Task<IList<string>> GetRolesAsync(User user);
}