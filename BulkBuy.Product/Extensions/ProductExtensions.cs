using System;
using Microsoft.Extensions.DependencyInjection;
using System.Security.Principal;
using BulkBuy.ProductFeature.Commands;

namespace BulkBuy.ProductFeature.Extensions
{

    public static class ProductExtensions
    {
        public static void AddProductCollection(this IServiceCollection services)
        {
            services.AddMediatR(res => res.RegisterServicesFromAssembly(typeof(AddProductCommand).Assembly));
            //services.AddScoped<IIdentity, IdentityService>();

        }
    }
}

