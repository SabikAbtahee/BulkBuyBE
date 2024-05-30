using System;
using BulkBuy.Core.BaseDtos;
using BulkBuy.ProductFeature.Dtos;
using MediatR;

namespace BulkBuy.ProductFeature.Commands
{
	public class AddProductCommand : IRequest<BaseCommandDto<ProductDto>>
    {
		public string Name { get; set; }

		public string Description { get; set; }

		public int Price { get; set; }

		public int MinimumOrderLimit { get; set; }

		public int MinimumPurchaseQuantity { get; set; }

		public string UnitOfMeasurement { get; set; }

    }
}

