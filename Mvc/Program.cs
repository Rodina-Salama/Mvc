namespace Mvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            // app.MapGet("/", () => "Hello World!");

            app.UseRouting();
            app.UseStaticFiles();
            #region MyRegion
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!");
            //    });
            //    endpoints.MapGet("/products", async context =>
            //    {
            //        await context.Response.WriteAsync("Products Page");
            //    });
            //});
            #endregion
            app.MapControllerRoute(
                name: "default",
                pattern : "/{Controller=Home}/{Action=Index}",
                defaults: new { Controller = "Home" , Action = "Index" });

            //app.Run(async (httpContext) =>
            //{
            //    await httpContext.Response.WriteAsync("Your Request Page not found");
            //} );

            app.Run();
        }
    }
}
