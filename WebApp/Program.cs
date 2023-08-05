using Microsoft.EntityFrameworkCore;
using WebApp.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();

var conString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DataContext>(options =>
    options.UseSqlServer(conString));

var app = builder.Build();

app.UseStaticFiles();
app.MapRazorPages();

app.Run();
