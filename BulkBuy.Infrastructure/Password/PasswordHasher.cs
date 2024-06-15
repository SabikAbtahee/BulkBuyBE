using BulkBuy.Application.Common.Interfaces;

namespace BulkBuy.Infrastructure.Password;
using BCrypt.Net;
using Microsoft.Extensions.Options;

public class PasswordHasher : IPasswordHasher
{

    private readonly PasswordSettings _passwordSettings;
    public PasswordHasher(IOptions<PasswordSettings> passwordSettings)
    {
        _passwordSettings = passwordSettings.Value;
    }
    public string EncryptPassword(string password)
    {
        return BCrypt.HashPassword(password, _passwordSettings.IterationCount);
    }
    public bool VerifyPassword(string password, string passwordHash)
    {
        return BCrypt.Verify(password, passwordHash);
    }
}
