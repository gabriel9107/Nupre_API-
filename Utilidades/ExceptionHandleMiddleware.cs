namespace Nupre_API.Utilidades
{
    public class ExceptionHandleMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionHandleMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await _next(httpContext);
            }
            catch (Exception ex)
            {
                await HandleException(ex, httpContext);
            }
        }

        private async Task HandleException(Exception ex, HttpContext httpContext)
        {


            if (ex is InvalidOperationException)
            {
                httpContext.Response.StatusCode = 400; //HTTP status code
                                                       //httpContext.Response.WriteAsync("Invalid operation");
                                                       //httpContext.Response.WriteAsync("Invalid operation");             
                await httpContext.Response.WriteAsJsonAsync(new ResponseModel
                {
                    Message = ex.Message,
                    StatusCode = 400,
                    Success = false
                });
            }
            else if (ex is ArgumentException)
            {
                await httpContext.Response.WriteAsync("Invalid argument");
            }
            else
            {
                await httpContext.Response.WriteAsync("Unknown error");
            }


        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class ExceptionHandleMiddlewareExtensions
    {
        public static IApplicationBuilder UseExceptionHandleMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionHandleMiddleware>();
        }
    }
}