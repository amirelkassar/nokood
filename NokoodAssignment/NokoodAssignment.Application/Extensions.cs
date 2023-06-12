﻿using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

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
