using JobPortal.PortalConfig;
using Microsoft.EntityFrameworkCore;
using PoratlServices.Config;
using PoratlServices.Implementations;
using PoratlServices.Interfaces;

namespace JobPortal
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddAutoMapper(typeof(MappingProfiles));
            builder.Services.AddDbContext<JpContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnStr")));
            builder.Services.AddScoped<IAccountService, AccountService>();
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Account}/{action=Login}/{id?}");

            app.Run();
        }
    }
}