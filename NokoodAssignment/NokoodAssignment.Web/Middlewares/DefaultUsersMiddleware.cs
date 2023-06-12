using Microsoft.AspNetCore.Identity;
using Serilog;

namespace NokoodAssignment.Web.Middlewares
{
    public class DefaultUsersMiddleware
    {
        private readonly RequestDelegate requestDelegate;

        public DefaultUsersMiddleware(RequestDelegate requestDelegate)
        {
            this.requestDelegate = requestDelegate;
        }

        public async Task InvokeAsync(HttpContext context, IConfiguration configuration, UserManager<IdentityUser> userManager)
        {
            if (!userManager.Users.Any())
            {
                Log.Information("Starting adding users...");
                var users = configuration.GetSection("UserSeeds").Get<IdentityUser[]>();
                if (users is not null && users.Length > 0)
                {
                    foreach (var user in users)
                    {
                        var creationRes = await userManager.CreateAsync(user, user.PasswordHash);
                        if (creationRes.Succeeded)
                        {
                            await userManager.AddToRoleAsync(user, "admins");
                        }
                    }
                }
                Log.Information("Users added");
            }

            await requestDelegate(context);
        }
    }
}
