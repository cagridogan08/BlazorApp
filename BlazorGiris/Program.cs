using BlazorGiris;
using BlazorGiris.Data;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
//builder.Services.AddRazorPages();
//builder.Services.AddServerSideBlazor();
ConfigureServices(builder.Services);
//builder.Services.AddSingleton<WeatherForecastService>();
//builder.Services.AddSingleton<UserService>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

/// Custom definition of injection service AddSingleton method
static void ConfigureServices(IServiceCollection services)
{
    services.AddSingleton<UserService>();
    services.AddRazorPages();
    services.AddServerSideBlazor();
    
}
app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
