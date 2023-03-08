using MedIT.Identity.Application.Commands.Register;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace MedIT.Identity.API.Controllers;

public class UsersController : ApiController
{
    [HttpPost("Register")]
    [AllowAnonymous]
    public async Task<ActionResult<IdentityResult>> Register(RegisterCommand command)
    {
        var result = await Mediator.Send(command);

        return Ok(result);
    }
}