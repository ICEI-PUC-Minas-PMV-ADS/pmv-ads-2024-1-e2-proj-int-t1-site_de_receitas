using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileSystemGlobbing.Internal;
using SiteReceitas.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddRazorPages().AddRazorRuntimeCompilation();

builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.Configure<CookiePolicyOptions>(options => // Configura��o de cookies de sess�o do usu�rio (tempo de expira��o, etc) 
{
    // This lambda determines whether user consent for non-essential cookies is needed for a given request.
    options.CheckConsentNeeded = context => true; // Verifica se o consentimento do usu�rio � necess�rio
    options.MinimumSameSitePolicy = SameSiteMode.None; // Pol�tica de cookies
});

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme) // Configura��o de autentica��o do usu�rio
    .AddCookie(options =>
    {
        options.AccessDeniedPath = "/Usuarios/AccessDenied/"; // P�gina de acesso negado
        options.LoginPath = "/Usuarios/Login/"; // P�gina de login
    });

var app = builder.Build();

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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "aleatorio",
    pattern: "{controller=Usuario}/{action=Index}/{id?}");


app.Run();
