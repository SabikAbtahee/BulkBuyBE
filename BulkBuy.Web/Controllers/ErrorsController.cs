using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace BulkBuy.Api.Controllers;

[Route("/error")]
[AllowAnonymous]
public class ErrorsController : ApiController
{
    public IActionResult Error()
    {
        Exception? exception = HttpContext.Features.Get<IExceptionHandlerFeature>()?.Error;
        return Problem(title: exception?.Message, statusCode: (int)HttpStatusCode.InternalServerError);

    }
}
