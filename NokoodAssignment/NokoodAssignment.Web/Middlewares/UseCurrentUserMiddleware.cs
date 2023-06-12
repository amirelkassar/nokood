using Microsoft.AspNetCore.Identity;
using NokoodAssignment.Application.Base;
using System.Security.Claims;

namespace NokoodAssignment.Web.Middlewares
{
    public class UseCurrentUserMiddleware
    {
        private readonly RequestDelegate requestDelegate;

        public UseCurrentUserMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context,ICurrentUser currentUser, UserManager<IdentityUser> userManager)
        {
            if (context.User?.Identity?.IsAuthenticated == true)
            {
                var userId = context.User.FindFirstValue(ClaimTypes.Sid);
                var user = await userManager.FindByIdAsync(userId);
                currentUser.InitalizeUser(user);
            }
            else
                currentUser.InitalizeUser(null);

            await requestDelegate.Invoke(context);
        }
    }
}
