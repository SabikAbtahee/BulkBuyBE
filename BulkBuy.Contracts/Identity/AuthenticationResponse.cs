namespace BulkBuy.Contracts.Identity;

public record AuthenticationResponse(Guid Id, string Name, string Email, string Token);