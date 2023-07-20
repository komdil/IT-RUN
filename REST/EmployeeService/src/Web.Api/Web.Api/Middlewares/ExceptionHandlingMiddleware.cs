using Microsoft.Extensions.Primitives;
using System.Net;
using System.Text;

namespace Web.Api.Middlewares
{
    public class ExceptionHandlingMiddleware
    {
        private readonly RequestDelegate _next;
      
        public ExceptionHandlingMiddleware(RequestDelegate next)
        {
            _next = next;
           
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var request = context.Request;

            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                context.Response.Clear();
                context.Response.StatusCode = (int)HttpStatusCode.UnprocessableEntity;
                await WriteErrorToResponse(context.Response);
            }
        }

        static async Task WriteErrorToResponse(HttpResponse response)
        {
            response.ContentType = "application/text";
            var content = "Internal server error";
            byte[] byteArray = Encoding.ASCII.GetBytes(content);
            await response.Body.WriteAsync(byteArray);
        }
    }
}
