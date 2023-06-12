using NokoodAssignment.Web.Middlewares;

namespace NokoodAssignment.Web.Extensions
{
    public static class MiddlewaresExtensions
    {
        public static IApplicationBuilder UseDefaultUsers(this IApplicationBuilder app)
        {
            app.UseMiddleware<DefaultUsersMiddleware>();
            return app;
        }

        public static IApplicationBuilder UseCurrentUserService(this IApplicationBuilder app)
        {
            app.UseMiddleware<CurrentUserMiddleware>();
            return app;
        }

        public static IApplicationBuilder UseGlobalErrorHandler(this IApplicationBuilder app)
        {
            app.UseMiddleware<GlobalErrorHandlerMiddleware>();
            return app;
        }
    }
}
