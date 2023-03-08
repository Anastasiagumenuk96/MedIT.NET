using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MedIT.Identity.API.Controllers;

[ApiController]
[Route("IdentityApi/[controller]")]
public class ApiController : ControllerBase
{
    private IMediator _mediator;

    protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<IMediator>();
}