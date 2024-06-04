using BulkBuy.Application.Identity.Common;
using ErrorOr;
using MediatR;

namespace BulkBuy.Application.Identity.Commands.Register;
public class RegisterCommandHandler : IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
{
    public Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand request, CancellationToken cancellationToken) => throw new NotImplementedException();
}
