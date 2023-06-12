using Microsoft.AspNetCore.Identity;
using NokoodAssignment.Web.Middlewares;

namespace NokoodAssignment.Web.Extensions
{
    public static class MiddlewaresExtensions
    {
        public static IApplicationBuilder UseDefaultUsers(this IApplicationBuilder app)
        {
            app.UseMiddleware<AddUsersMiddleware>();
            return app;
        }

        public static IApplicationBuilder UseCurrentUserService(this IApplicationBuilder app)
        {
            app.UseMiddleware<UseCurrentUserMiddleware>();
            return app;
        }
    }
}
