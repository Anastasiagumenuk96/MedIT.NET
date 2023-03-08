using AutoMapper;
using MediatR;
using MedIT.Identity.Application.Interfaces.Infrastructure.Managers;
using MedIT.Identity.Domain.Entities;
using Microsoft.AspNetCore.Identity;

namespace MedIT.Identity.Application.Commands.Register;

public class RegisterCommand : IRequest<IdentityResult>
{
    public string UserName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, IdentityResult>
{
    private readonly IMedItUserManager _userManager;
    private readonly IMapper _mapper;

    public RegisterCommandHandler(
        IMedItUserManager userManager,
        IMapper mapper)
    {
        _userManager = userManager;
        _mapper = mapper;
    }

    public async Task<IdentityResult> Handle(RegisterCommand command, CancellationToken cancellationToken)
    {
        var user = _mapper.Map<User>(command);

        if (user is not null)
        {
            return await _userManager.CreateAsync(user, command.Password);
        }

        throw new Exception();
    }
}