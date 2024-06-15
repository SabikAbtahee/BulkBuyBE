using BulkBuy.Application.Common.Interfaces;
using BulkBuy.Application.Identity.Common;
using BulkBuy.Application.Identity.Services;
using BulkBuy.Domain.Common.Errors;
using BulkBuy.Domain.Entities;
using ErrorOr;
using MediatR;
namespace BulkBuy.Application.Identity.Commands.Register;


public class RegisterCommandHandler : IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResult>>
{
    private readonly IRepository _repository;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly AuthenticationService _authenticationService;

    public RegisterCommandHandler(IRepository repository, IJwtTokenGenerator jwtTokenGenerator, AuthenticationService authenticationService)
    {
        _repository = repository;
        _jwtTokenGenerator = jwtTokenGenerator;
        _authenticationService = authenticationService;
    }

    public async Task<ErrorOr<AuthenticationResult>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        var user = await _repository.GetItemAsync<User>(x => x.Email == request.Email);

        if (user is not null)
            return BulkBuyErrors.UserError.DuplicateEmail;

        var newUser = _authenticationService.PrepareCustomerUser(request);
        var newPerson = _authenticationService.PrepareCustomerPerson(request, newUser.Id);
        await _authenticationService.SaveUser(newUser);
        await _authenticationService.SavePerson(newPerson);

        var token = _jwtTokenGenerator.GenerateToken(newUser);

        return new AuthenticationResult(newUser, token, token);
    }
}
