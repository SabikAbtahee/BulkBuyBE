using BulkBuy.Api.Common.Errors;
using BulkBuy.Api.Common.Mapping;
using Microsoft.AspNetCore.Mvc.Infrastructure;

namespace BulkBuy.Api;

public static class DependencyInjection
{
    public static IServiceCollection AddPresentation(this IServiceCollection services)
    {
        services.AddControllers().AddJsonOptions(options =>
        {
            options.JsonSerializerOptions.PropertyNamingPolicy = null; // Preserve property names
        });
        services.AddSingleton<ProblemDetailsFactory, BulkBuyProblemDetailsFactory>();
        services.AddMappings();

        return services;
    }
}
