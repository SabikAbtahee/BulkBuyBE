using BulkBuy.Application.Identity.Common;
using ErrorOr;
using MediatR;

namespace BulkBuy.Application.Identity.Commands.Register;

public record RegisterCommand(
    string Name,
    string PhoneNumber,
    string Email,
    string Address,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;