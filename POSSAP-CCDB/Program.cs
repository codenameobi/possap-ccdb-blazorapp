using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using POSSAP_CCDB.Data;
using Blazored.LocalStorage;
using POSSAP_CCDB.Data.State;
using Microsoft.JSInterop;
using POSSAP_CCDB.Interface;
using POSSAP_CCDB.Services;
using System.Net.Http.Headers;
using Fluxor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddSingleton<WeatherForecastService>();

builder.Services.AddHttpClient();
builder.Services.AddBlazoredLocalStorage();

builder.Services.AddFluxor(options => options.ScanAssemblies(typeof(Program).Assembly));

builder.Services.AddScoped<AppUser>();
builder.Services.AddScoped<UserState>();
builder.Services.AddScoped<LocalStorageService>();
builder.Services.AddScoped<IDashboardService, DashboardService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}


app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
