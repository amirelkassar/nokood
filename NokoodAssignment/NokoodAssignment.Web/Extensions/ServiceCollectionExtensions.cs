using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.OpenApi.Models;
using NokoodAssignment.Application;
using NokoodAssignment.Application.Base;
using NokoodAssignment.Persistence;
using NokoodAssignment.Web.Handlers;
using Serilog;
using Serilog.Ui.MsSqlServerProvider;
using Serilog.Ui.Web;

namespace NokoodAssignment.Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void InitalizeApp(this WebApplicationBuilder builder)
        {
            builder.AddSerilog();
            builder.Services.AddApplication();
            builder.Services.AddPersistence(builder.Configuration);
            builder.Services.AddControllers();
            builder.Services.ComfigurteAuthentication();
            builder.Services.ConfigureAuthorization();
            builder.Services.AddCurrentUserService();
            builder.Services.AddApiDocs();
            builder.Services.ConfigureApiVersioning();
        }

        private static void AddSerilog(this WebApplicationBuilder builder)
        {
            var config = new ConfigurationBuilder()
               .AddJsonFile("appsettings.json")
               .Build();
            //Initialize Logger
            Log.Logger = new LoggerConfiguration()
                .ReadFrom.Configuration(config)
                .CreateLogger();
            Log.Information("Starting Nokood...");
            builder.Host.UseSerilog();

            builder.Services.AddSerilogUi(opts =>
            {
                opts.UseSqlServer(builder.Configuration.GetConnectionString("Logs"), "tb_logs");
            });
        }
        private static IServiceCollection ConfigureAuthorization(this IServiceCollection services)
        {
            services.AddAuthorization(opts =>
            {

            });
            return services;
        }
        private static IServiceCollection ComfigurteAuthentication(this IServiceCollection services)
        {
            services.AddAuthentication(opts =>
            {
                
            });
            return services;
        }
        private static IServiceCollection AddCurrentUserService(this IServiceCollection services)
        {
            services.AddScoped<ICurrentUser, CurrentUser>();
            return services;
        }
        private static IServiceCollection AddApiDocs(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen(c =>
            {
                c.IncludeXmlComments(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "nokoodapidocs.xml"));
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Version = "v1",
                    Title = "Nokood Api Docs",
                });
            });
            return services;
        }
        private static IServiceCollection ConfigureApiVersioning(this IServiceCollection services)
        {
            services.AddApiVersioning(config =>
            {
                config.DefaultApiVersion = new ApiVersion(1, 0);
                config.AssumeDefaultVersionWhenUnspecified = true;
                config.ReportApiVersions = true;
                config.ApiVersionReader = new HeaderApiVersionReader("api-version");
            });
            return services;
        }
    }
}
