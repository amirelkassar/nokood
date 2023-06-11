using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Versioning;
using Microsoft.OpenApi.Models;

namespace NokoodAssignment.Web.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static void InitalizeApp(this WebApplicationBuilder builder)
        {
            builder.Services.AddControllers();
            builder.Services.AddApiDocs();
            builder.Services.ConfigureApiVersioning();
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
