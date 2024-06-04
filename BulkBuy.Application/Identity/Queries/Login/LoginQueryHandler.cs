using BulkBuy.Application.Identity.Common;
using ErrorOr;
using MediatR;

namespace BulkBuy.Application.Identity.Queries.Login;
public class LoginQueryHandler : IRequestHandler<LoginQuery, ErrorOr<AuthenticationResult>>
{
    public Task<ErrorOr<AuthenticationResult>> Handle(LoginQuery request, CancellationToken cancellationToken) => throw new NotImplementedException();
}
