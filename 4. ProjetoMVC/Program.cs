using _4._ProjetoMVC.Data;
using _4._ProjetoMVC.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
var conectionString = builder.Configuration["ConnectionStrings:SalesWebMvcContext"];

builder.Services.AddMySql<SalesWebMvcContext>(conectionString,
                        ServerVersion.AutoDetect(conectionString)
                    );

builder.Services.AddScoped<SeedingService>();

var app = builder.Build();


//usando SeedingServide
if (app.Environment.IsDevelopment())
{
    using (var serviceScope = app.Services.CreateScope())
    {
        var services = serviceScope.ServiceProvider;
        var meuSeed = services.GetRequiredService<SeedingService>();
        //Use the service
        meuSeed.Seed();
    }
}

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
