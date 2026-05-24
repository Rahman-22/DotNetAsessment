using Microsoft.EntityFrameworkCore;
using DotNetAsessment.Models;

var builder = WebApplication.CreateBuilder(args);

// 1. REGISTER SQLITE DATABASE
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite("Data Source=local_assessment.db"));

builder.Services.AddControllersWithViews();

var app = builder.Build();

// 2. AUTOMATICALLY INITIALIZE/CREATE DATABASE ON STARTUP
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    db.Database.EnsureCreated(); // Creates the file and seeds data if it doesn't exist
}

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
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