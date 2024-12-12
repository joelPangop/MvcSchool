
using Microsoft.EntityFrameworkCore;
using MvcSchool.Repositories;

public class Program
{

    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.AddServiceDefaults();

        // Add services to the container.
        builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<MvcSchoolContext>(options =>
        options.UseMySql(
            builder.Configuration.GetConnectionString("DefaultConnection"),
            new MySqlServerVersion(new Version(8, 0, 32)) // Spécifiez la version exacte de votre MySQL
        ));

        var app = builder.Build();

        app.MapDefaultEndpoints();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}
//    public void ConfigureServices(IServiceCollection services)
//    {
//        services.AddDbContext<MvcSchoolContext>(options =>
//        options.UseMySql(
//            builder.Configuration.GetConnectionString("DefaultConnection"),
//            new MySqlServerVersion(new Version(8, 0, 32)) // Spécifiez la version exacte de votre MySQL
//        ));
//    }
//}