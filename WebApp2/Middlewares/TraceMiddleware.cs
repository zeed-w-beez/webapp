using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using WebApp2.Options.Configuration;

namespace WebApp2.Middlewares
{
    public class TraceMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly AppConfigOptions _appConfigOptions;

        public TraceMiddleware(RequestDelegate next, IOptions<AppConfigOptions> optionsAccessor)
        {
            _next = next;
            _appConfigOptions = optionsAccessor.Value;
        }

        public async Task Invoke(HttpContext context)
        {
            if (context.Request.Query.ContainsKey(_appConfigOptions.Trace.TraceKey))
            {
                string traceInfo = "TraceInfo:\n";
                // todo: 如果请求里有特殊参数，则会在页面的最后打印出完整的 Trance Level 信息。

            }

            await _next(context);
        }
    }

    public static class TraceMiddlewareExtensions
    {
        public static IApplicationBuilder UseTrace(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<TraceMiddleware>();
        }
    }
}
