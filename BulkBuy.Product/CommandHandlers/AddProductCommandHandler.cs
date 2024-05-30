using System;
using BulkBuy.Core.BaseDtos;
using BulkBuy.Core.Interfaces;
using BulkBuy.ProductFeature.Commands;
using BulkBuy.ProductFeature.Dtos;
using BulkBuy.Core.Entities;

using MediatR;


namespace BulkBuy.ProductFeature.CommandHandlers
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, BaseCommandDto<ProductDto>>
    {
        private readonly IRepository _repository;

        public AddProductCommandHandler(IRepository repository)
        {
            _repository = repository;
        }

        public async Task<BaseCommandDto<ProductDto>> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            await _repository.SaveAsync<Product>(new Product()
            {
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                MinimumOrderLimit = request.MinimumOrderLimit,
                MinimumPurchaseQuantity = request.MinimumPurchaseQuantity,
                UnitOfMeasurement = request.UnitOfMeasurement
            });

            return new BaseCommandDto<ProductDto>
            {
                Data = new ProductDto(),
                Success = true,
                ErrorMessages = null,
                HttpStatusCode = 201
            };
        }
    }
}

