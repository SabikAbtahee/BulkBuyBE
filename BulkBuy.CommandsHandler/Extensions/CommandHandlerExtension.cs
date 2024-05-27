using BulkBuy.CommandsHandler.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkBuy.CommandsHandler.Extensions
{
    public static class CommandHandlerExtension
    {
        public static void AddCommandsHandlerCollection(this IServiceCollection services)
        {
            services.AddMediatR(res => res.RegisterServicesFromAssembly(typeof(BulkBuyCommandsHandlerMediatrEntry).Assembly));
        }
    }
}
