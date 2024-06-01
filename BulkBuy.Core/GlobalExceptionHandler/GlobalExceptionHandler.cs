using System;
using System.Diagnostics;
using BulkBuy.Core.BaseDtos;
using BulkBuy.Core.Interfaces;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace BulkBuy.Core.GlobalExceptionHandler
{
    public class GlobalExceptionHandler : IExceptionHandler
    {
        private readonly ILoggerManager _logger;

        public GlobalExceptionHandler(ILoggerManager logger)
        {
            _logger = logger;
        }

        public ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
        {
            var traceId = Activity.Current?.Id ?? httpContext.TraceIdentifier;
            _logger.LogError($"Global Error Occured.TraceId:{traceId}");
            
                //(new BaseDto() { StatusCode = 500, Message = "Internal Server Error", Success = false }).ToString()


            //await Results.Problem(
            //    statusCode:500,
            //    title:"gg").ExecuteAsync(httpContext);

            return ValueTask.FromResult(true); 
        }
    }
}

