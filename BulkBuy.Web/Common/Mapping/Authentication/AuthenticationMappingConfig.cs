using BulkBuy.Application.Identity.Commands.Login;
using BulkBuy.Application.Identity.Commands.Register;
using BulkBuy.Application.Identity.Common;
using BulkBuy.Contracts.Identity;
using Mapster;

namespace BulkBuy.Api.Common.Mapping.Authentication;

public class AuthenticationMappingConfig : IRegister
{
    public void Register(TypeAdapterConfig config)
    {
        config.NewConfig<RegisterRequest, RegisterCommand>();
        config.NewConfig<LoginRequest, LoginCommand>();

        config.NewConfig<AuthenticationResult, AuthenticationResponse>()
            .Map(dest => dest.Id, src => src.User.Id)
            .Map(dest => dest.Name, src => src.User.UserName)
            .Map(dest => dest.Email, src => src.User.Email);
    }
}
