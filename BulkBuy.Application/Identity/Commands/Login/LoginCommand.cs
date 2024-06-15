using BulkBuy.Application.Identity.Common;
using ErrorOr;
using MediatR;

namespace BulkBuy.Application.Identity.Commands.Login;
public record LoginCommand(
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;