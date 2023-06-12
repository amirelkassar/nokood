
using NokoodAssignment.Web.Extensions;
using Serilog;
using Serilog.Ui.Web;

namespace NokoodAssignment.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.InitalizeApp();
            try
            {
                var app = builder.Build();
                app.UseSwagger();

                app.UseSwaggerUI(c =>
                {
                    c.SwaggerEndpoint("/swagger/v1/swagger.json", "Nokood APIs Docs");
                });
                app.UseSerilogUi(opts =>
                {
                    opts.RoutePrefix = "logs";
                });

                app.UseHttpsRedirection();

                app.UseAuthorization();

                app.MapControllerRoute(name: "ApiRoute", pattern: "api/{controller}/{action}/{id?}");

                app.Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "Nokood terminated unexpectedly!");
            }
            finally
            {
                Log.CloseAndFlush();
            }
           
        }
    }
}