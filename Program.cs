using MakeYourDiet.Data;
using MakeYourDiet.Extensions;
using MakeYourDiet.Interfaces;
using MakeYourDiet.Middleware;
using MakeYourDiet.Models;
using MakeYourDiet.Repositories;
using MakeYourDiet.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();
builder.Services.AddApplicationServices(builder.Configuration);
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IProductService, ProductService>();

var app = builder.Build();

app.UseMiddleware<ExceptionMiddleware>();
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();

app.UseCors(builder => builder
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowCredentials()
    .WithOrigins("http://localhost:4200"));

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action=Index}/{id?}");

app.MapFallbackToFile("index.html");


// using var scope = app.Services.CreateScope();
// var services = scope.ServiceProvider;
// try {
//     var context = services.GetRequiredService<DataContext>();
//     await context.Database.MigrateAsync();
//     await Seed.ClearConnections(context);
//     await Seed.SeedUsers();
// }
// catch (Exception ex)
// {
//     var logger = services.GetService<ILogger<Program>>();
//     logger.LogError(ex, "An error ocurred during migration");
// }

app.Run();
