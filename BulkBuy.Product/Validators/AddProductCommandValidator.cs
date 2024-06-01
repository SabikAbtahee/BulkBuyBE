using System;
using BulkBuy.ProductFeature.Commands;
using FluentValidation;

namespace BulkBuy.ProductFeature.Validators
{
	public class AddProductCommandValidator : AbstractValidator<AddProductCommand>
	{
		public AddProductCommandValidator()
		{
			RuleFor(x => x.Name)
				.NotEmpty()
				.WithMessage("Product Name Cannot be Empty");
		}
	}
}

