using ErrorOr;

namespace BulkBuy.Domain.Common.Errors;
public static partial class BulkBuyErrors
{
    public static class UserError
    {
        public static Error DuplicateEmail => Error.Conflict(
            code: "User.DuplicateEmail",
            description: "Email is already in use");

        public static Error UserDoesNotExistGivenEmail => Error.NotFound(
            code: "User.UserDoesNotExistGivenEmail",
            description: "User does not exist given email");

    }
}
