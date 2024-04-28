using MichelMichels.ViesSharp;
using MichelMichels.ViesSharp.Demo.Components;
using MichelMichels.ViesSharp.Demo.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddSingleton<IViesSharpClient, ViesSharpClient>()
    .AddScoped<IThemeService, ThemeService>();

// Add services to the container.
builder.Services
    .AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
