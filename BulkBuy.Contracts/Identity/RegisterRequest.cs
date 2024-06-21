namespace BulkBuy.Contracts.Identity;

public record RegisterRequest(string Name, string Email, string PhoneNumber, string Address, string Password);
