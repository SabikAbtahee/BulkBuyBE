using BulkBuy.Domain.Entities;

namespace BulkBuy.Application.Identity.Common;

public record AuthenticationResult(User User, string Token);