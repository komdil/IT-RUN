using System.Diagnostics;

namespace Web.Api.Middlewares
{
    public class PerformanceHandlerMiddleware
    {
        private readonly RequestDelegate _next;

        public PerformanceHandlerMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                await _next(context);

            }
            finally
            {

                stopwatch.Stop();

                if (stopwatch.Elapsed.TotalSeconds > 10)
                {
                    Console.WriteLine("Request is taking more than 10 seconds.");
                }
            }
        }
    }
}
