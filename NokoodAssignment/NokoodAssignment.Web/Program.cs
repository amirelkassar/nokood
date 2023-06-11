
using NokoodAssignment.Web.Extensions;

namespace NokoodAssignment.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.InitalizeApp();


            var app = builder.Build();

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Nokood APIs Docs");
            });

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllerRoute(name: "ApiRoute", pattern: "api/{controller}/{action}/{id?}");

            app.Run();
        }
    }
}