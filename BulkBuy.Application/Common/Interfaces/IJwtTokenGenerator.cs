using BulkBuy.Domain.Entities;

namespace BulkBuy.Application.Common.Interfaces;
public interface IJwtTokenGenerator
{
    string GenerateToken(User user);

    //string GenerateToken(RefreshToken refreshToken); // make a entity keep it in redis 
}
