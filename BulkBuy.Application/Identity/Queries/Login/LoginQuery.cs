using BulkBuy.Application.Identity.Common;
using ErrorOr;
using MediatR;

namespace BulkBuy.Application.Identity.Queries.Login;
public record LoginQuery(
    string Email,
    string Password) : IRequest<ErrorOr<AuthenticationResult>>;