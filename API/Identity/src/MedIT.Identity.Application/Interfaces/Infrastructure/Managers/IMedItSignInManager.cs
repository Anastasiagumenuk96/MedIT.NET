using MedIT.Identity.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace MedIT.Identity.Application.Interfaces.Infrastructure.Managers;

public interface IMedItSignInManager
{
    Task<SignInResult> CheckPasswordSignInAsync(
        User user,
        string password,
        bool lockoutOnFailure);
}