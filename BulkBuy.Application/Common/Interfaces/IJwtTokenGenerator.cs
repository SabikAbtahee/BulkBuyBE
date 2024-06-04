using BulkBuy.Domain.Entities;

namespace BulkBuy.Application.Common.Interfaces;
public interface IJwtTokenGenerator
{
    string GenerateToken(User user);
}
