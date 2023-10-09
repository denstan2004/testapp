using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using testapp;
using testapp.DAL;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"));
});
builder.Services.InitializeRepositories();

builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
        options.AccessDeniedPath = new Microsoft.AspNetCore.Http.PathString("/Account/Login");
    });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();

    // Äîäàéòå URL-ïåðåàäðåñàö³þ äëÿ âñ³õ óðë³â íà âàø áàçîâèé URL
    app.Use((context, next) =>
    {
        context.Request.Scheme = "https"; // Àáî "http", â çàëåæíîñò³ â³ä ïðîòîêîëó
        context.Request.Host = new HostString("testappfuck.azurewebsites.net");
        return next();
    });
}
app.UseCors(builder => builder
    .WithOrigins("https://red-plant-098bd5010.3.azurestaticapps.net") // Розділіть по комах, якщо потрібно додати більше доменів 
    .AllowAnyHeader()
    .AllowAnyMethod()
);


app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();