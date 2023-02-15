using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using oop.AppDbContext;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var constring = builder.Configuration.GetConnectionString("DefaultConnection");


        builder.Services.AddControllersWithViews();
        // 1. Add Authentication Services
        builder.Services.AddAuthentication(options =>
        {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        }).AddJwtBearer(options =>
        {
            options.Authority = "https://dev-ii87cwbmy7f2mchv.us.auth0.com/";
            options.Audience = "https://api.wsei-asp-project.com";
        });
        builder.Services.AddDbContext<RecordDbContext>(options => options.UseSqlServer(constring));



        var app = builder.Build();



        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseHttpLogging();
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            // app.UseHsts();
        }


        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();


        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller}/{action=Index}/{id?}");

        app.MapFallbackToFile("index.html"); ;
        app.UseCors(builder => builder.WithOrigins("http://localhost:44432/").AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
        app.Run();
    }
}
