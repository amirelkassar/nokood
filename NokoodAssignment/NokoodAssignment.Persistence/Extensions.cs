using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NokoodAssignment.Application.Base;
using NokoodAssignment.Persistence.DatabaseContext;
using NokoodAssignment.Persistence.Services;

namespace NokoodAssignment.Persistence
{
    public static class Extensions
    {
        private static IConfiguration Configuration;
        public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration configuration)
        {
            Configuration = configuration;
            services.AddDataAccess();
            services.AddIdentitySystem();
            return services;
        }

        private static IServiceCollection AddDataAccess(this IServiceCollection services)
        {
            services.AddDbContext<NokoodDBContext>(opts =>
            {
                opts.UseSqlServer(Configuration.GetConnectionString("Default"),
                    ssopts => ssopts.MigrationsAssembly(typeof(NokoodDBContext).Assembly.FullName));
                opts.EnableDetailedErrors();
                opts.EnableServiceProviderCaching();
                opts.EnableThreadSafetyChecks();
            });
            services.AddScoped<INokoodDBContext>(procider => procider.GetService<NokoodDBContext>());
            return services;
        }

        private static IServiceCollection AddIdentitySystem(this IServiceCollection services)
        {
            services.AddIdentityCore<IdentityUser>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 10;
                opts.Password.RequiredUniqueChars = 1;
                opts.Password.RequireNonAlphanumeric = true;
                opts.Password.RequireDigit = true;
                opts.Password.RequireLowercase = true;
                opts.Password.RequireUppercase = true;
            })
            .AddRoles<IdentityRole>()
            .AddErrorDescriber<IdentityErrorDescriber>()
            .AddEntityFrameworkStores<NokoodDBContext>();

            services.AddScoped<IAuthenticationService, AuthenticationService>();
            return services;
        }

    }
}
