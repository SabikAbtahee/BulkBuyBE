using BulkBuy.Api.Controllers;
using BulkBuy.Application.Identity.Commands.Register;
using BulkBuy.Application.Identity.Common;
using BulkBuy.Application.Identity.Queries.Login;
using BulkBuy.Contracts.Identity;
using ErrorOr;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BulkBuy.Identity.Controllers
{
    [Route("auth")]
    [AllowAnonymous]
    public class IdentityController : ApiController
    {
        private readonly ISender _mediator;
        private readonly IMapper _mapper;

        public IdentityController(
            ISender mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(LoginRequest request)
        {
            var query = _mapper.Map<LoginQuery>(request);
            ErrorOr<AuthenticationResult> authResult = await _mediator.Send(query);

            return authResult.Match(
                authResult => Ok(_mapper.Map<AuthenticationResponse>(authResult)),
                errors => Problem(errors));

        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(RegisterRequest request)
        {
            var command = _mapper.Map<RegisterCommand>(request);
            ErrorOr<AuthenticationResult> authResult = await _mediator.Send(command);
            return authResult.Match(
                authResult => Ok(_mapper.Map<AuthenticationResponse>(authResult)),
                errors => Problem(errors));
        }
    }
}
