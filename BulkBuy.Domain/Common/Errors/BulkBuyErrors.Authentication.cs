using ErrorOr;

namespace BulkBuy.Domain.Common.Errors;
public static partial class BulkBuyErrors
{
    public static class Authentication
    {

        public static Error InvalidCredentails => Error.Validation(
            code: "User.InvalidCredentails",
            description: "Invalid Credentails");
    }
}
