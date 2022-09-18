using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace NorthWindTest.Web.Middlewares
{
    public class ExceptionHandleMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILogger<ExceptionHandleMiddleware> _logger;

        public ExceptionHandleMiddleware(RequestDelegate next, ILogger<ExceptionHandleMiddleware> logger)
        {
            _next = next;
            _logger = logger;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
                InsertSuccessLog(context);
            }
            catch (Exception ex)
            {
                InsertFailLog(context, ex);
            }
        }

        private void InsertSuccessLog(HttpContext context)
        {
            _logger.LogTrace(context.TraceIdentifier);
        }

        private void InsertFailLog(HttpContext context, Exception ex)
        {
            _logger.LogError("", ex);
        }
    }
}
