using Microsoft.AspNetCore.Diagnostics;
using NokoodAssignment.Application.Dots;
using Serilog;

namespace NokoodAssignment.Web.Middlewares
{
    public class GlobalErrorHandlerMiddleware
    {
        private readonly RequestDelegate requestDelegate;

        public GlobalErrorHandlerMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            context.Response.StatusCode = StatusCodes.Status500InternalServerError;
            context.Response.ContentType = "application/json";
            var httperror = context.Features.Get<IExceptionHandlerFeature>();
            if (httperror != null)
            {
                Log.Error($"An application error occured {httperror.Error}");
                await context.Response.WriteAsJsonAsync(new ApiResponse<object>
                {
                    Success = false,
                    Message = $"An application error occured {httperror.Error}",
                    Code = StatusCodes.Status500InternalServerError,
                    Error = new object[] { new { Message = $"An application error occured {httperror.Error}" } }
                });
            }
            await requestDelegate.Invoke(context);
        }
    }
}
