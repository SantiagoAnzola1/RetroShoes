using Microsoft.AspNetCore.Authentication.Cookies;
using System.Web.Services.Description;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddCookie(o => {
                    o.LoginPath = "/Home/LogIn";
                    o.AccessDeniedPath = "/Home /LogIn";
                });

            
  
builder.Services.AddControllersWithViews();
builder.Services.AddRazorPages();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseStaticFiles();




app.MapRazorPages();
app.MapDefaultControllerRoute();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();


app.MapControllerRoute(
    name: "Pedido",
    pattern: "{area:exists}/{controller=Pedido}/{action=Pedido}/{id?}");


app.MapControllerRoute(
    name: "Filtros",
    pattern: "{area:exists}/{controller=Filtros}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Marcas",
    pattern: "{area:exists}/{controller=Marcas}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
