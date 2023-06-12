using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace NokoodAssignment.Application
{
    public static class Extensions
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(opts =>
            {
                opts.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly());
            });
            return services;
        }
    }
}
