using AutoMapper;
using SMART.Web.OrderApi;
using Daemon.RazorUI.Modal; 
using SmartEstimate.Models;
using SmartEstimate.Components;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var mapperConfig = new MapperConfiguration(cfg =>
{
    cfg.AddProfile<SmartEstimateMappingProfile>();
});
IMapper mapper = mapperConfig.CreateMapper();
builder.Services.AddSingleton(mapper);
builder.Services.AddScoped<ModalService>();
// TODO: This should work as Scoped
builder.Services.AddSingleton<OrderApi>();
builder.Services.AddSingleton<ProjectApi>();
builder.Services.AddSingleton<ProjectStore>();
builder.Services.AddSingleton<ShipLocationApi>();
builder.Services.AddSingleton<ShipLocationStore>();


builder.WebHost.UseWebRoot("wwwroot");
builder.WebHost.UseStaticWebAssets();

builder.Services.AddRazorPages();

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