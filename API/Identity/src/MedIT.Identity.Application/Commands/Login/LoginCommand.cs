using MediatR;
using MedIT.Identity.Application.Interfaces.Infrastructure.Managers;
using MedIT.Identity.Domain.Enums;

namespace MedIT.Identity.Application.Commands.Login;

public class LoginCommand : IRequest<LoginStatus>
{
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}

public class LoginCommandHandler : IRequestHandler<LoginCommand, LoginStatus>
{
    private readonly IMedItSignInManager _signInManager;
    private readonly IMedItUserManager _userManager;

    public LoginCommandHandler(
        IMedItSignInManager signInManager,
        IMedItUserManager userManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }

    public async Task<LoginStatus> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByNameAsync(request.UserName);

        if (user is null)
        {
            throw new Exception();
        }

        var signInResult = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);

        return signInResult.Succeeded
            ? LoginStatus.Success
            : LoginStatus.InvalidInput;
    }
}