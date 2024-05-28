using BulkBuy.Commands.Identity;
using BulkBuy.Identity.Interfaces;
using BulkBuy.Identity.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.Identity.Extensions
{
    public static class IdentityExtensions
    {
        public static void AddIdentityCollection(this IServiceCollection services)
        {
            services.AddMediatR(res => res.RegisterServicesFromAssembly(typeof(LoginCommand).Assembly));
            services.AddScoped<IIdentity, IdentityService>();

        }
    }
}
