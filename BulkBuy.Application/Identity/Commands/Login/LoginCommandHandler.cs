using BulkBuy.Application.Common.Interfaces;
using BulkBuy.Application.Identity.Common;
using BulkBuy.Application.Identity.Services;
using BulkBuy.Domain.Common.Errors;
using BulkBuy.Domain.Entities;
using ErrorOr;
using MediatR;

namespace BulkBuy.Application.Identity.Commands.Login;
public class LoginCommandHandler : IRequestHandler<LoginCommand, ErrorOr<AuthenticationResult>>
{
    private readonly IRepository _repository;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IPasswordHasher _passwordHasher;
    private readonly AuthenticationService _authenticationService;

    public LoginCommandHandler(IRepository repository, IJwtTokenGenerator jwtTokenGenerator, IPasswordHasher passwordHasher, AuthenticationService authenticationService)
    {
        _repository = repository;
        _jwtTokenGenerator = jwtTokenGenerator;
        _passwordHasher = passwordHasher;
        _authenticationService = authenticationService;
    }
    public async Task<ErrorOr<AuthenticationResult>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var user = await _repository.GetItemAsync<User>(x => x.Email == request.Email);

        if (user is null)
            return BulkBuyErrors.Authentication.InvalidCredentails;

        var isPasswordValid = _passwordHasher.VerifyPassword(request.Password, user.Password);

        if (isPasswordValid is not true)
            return BulkBuyErrors.Authentication.InvalidCredentails;

        var token = _jwtTokenGenerator.GenerateToken(user);
        // throw an event and do certain tasks with that event such as make login count increase, save refresh token in redis etc
        await _authenticationService.UpdateLoginInfoAfterLogin(user.Id);

        return new AuthenticationResult(user, token, token);
    }
}
