using Microsoft.Extensions.Primitives;
using System.Net;

namespace Web.Api.Middlewares
{
    public class MyAuthMiddleware
    {
        private readonly RequestDelegate _next;
        public MyAuthMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        const string userName = "Username";
        const string userNameValue = "Admin";

        public async Task InvokeAsync(HttpContext context)
        {
            var request = context.Request;
            if (request.Headers.TryGetValue(userName, out StringValues value) && value == userNameValue)
            {
                await _next(context);
            }
            else
            {
                context.Response.Clear();
                context.Response.StatusCode = (int)HttpStatusCode.Unauthorized;
            }
        }
    }
}
