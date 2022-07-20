using Microsoft.EntityFrameworkCore;
using oop.AppDbContext;

internal class Program
{
  private static void Main(string[] args)
  {
    var  MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
    var builder = WebApplication.CreateBuilder(args);
    var constring = builder.Configuration.GetConnectionString("DefaultConnection");
    
    builder.Services.AddControllersWithViews();
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


    app.MapControllerRoute(
        name: "default",
        pattern: "{controller}/{action=Index}/{id?}");

    app.MapFallbackToFile("index.html"); ;
      app.UseCors(builder => builder.WithOrigins("http://localhost:44432/").AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
    app.Run();
  }
}
