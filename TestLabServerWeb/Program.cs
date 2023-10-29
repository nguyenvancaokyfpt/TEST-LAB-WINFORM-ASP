using TestLabServerWeb.Hubs;

namespace TestLabServerWeb
{
    public class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddDistributedMemoryCache();
            builder.Services.AddSession(cfg =>
            {
                cfg.Cookie.Name = "testlab";
                cfg.IdleTimeout = new TimeSpan(0, 60, 0);
            });
            builder.Services.AddSignalR();

            var app = builder.Build();



            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseSession();

            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapHub<SignalrServer>("/signalrServer");

            app.Run();
        }
    }
}