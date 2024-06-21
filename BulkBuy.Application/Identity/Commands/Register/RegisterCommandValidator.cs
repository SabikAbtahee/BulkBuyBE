using BulkBuy.Domain.Common.Constants;
using FluentValidation;

namespace BulkBuy.Application.Identity.Commands.Register;
public class RegisterCommandValidator : AbstractValidator<RegisterCommand>
{
    public RegisterCommandValidator()
    {
        RuleFor(x => x.Name).NotEmpty();
        RuleFor(x => x.Email).NotEmpty().EmailAddress();
        RuleFor(x => x.PhoneNumber)
            .NotEmpty()
            .Matches(BulkBuyConstants.PhoneNumberRegex).WithMessage("Invalid phone number format");
        ;
        RuleFor(x => x.Password)
            .NotEmpty()
            .Matches(BulkBuyConstants.PasswordRegex)
            .WithMessage("Must Contain 1 Uppercase, 1 Lowercase, 1 Number, 1 Special Character, and at least 8 or more characters");
        RuleFor(x => x.Address).NotEmpty();

    }
}
