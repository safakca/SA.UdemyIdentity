using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using UdemyIdentity.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddMvc();
builder.Services.AddDbContext<Context>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnectionString")));
builder.Services.AddIdentity<AppUser, IdentityRole>(opt =>
{
    opt.Password.RequiredLength = 4;
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequireLowercase= false;
    opt.Password.RequireUppercase= false;
    opt.Password.RequireDigit= false;
}).AddEntityFrameworkStores<Context>();

var app = builder.Build();

app.UseDeveloperExceptionPage();
app.UseStatusCodePages();
app.UseStaticFiles();
 
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");
 
app.Run();
