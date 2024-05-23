using MediatR;
using Microsoft.AspNetCore.Mvc;
using BaseCodeAutoSever.WebUi.Filters;

namespace BaseCodeAutoSever.WebUi.Controllers;

[ApiController]
[ApiExceptionFilter]
[Route("api/[controller]")]
public class ApiControllerBase : ControllerBase
{
    private ISender? _mediator;

    protected ISender Mediator => _mediator ??= HttpContext.RequestServices.GetRequiredService<ISender>();
}
