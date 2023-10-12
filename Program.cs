using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SmartEstimate.Components;
using SmartEstimate.Services;
using SmartEstimate.Modal;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddServerComponents();
builder.Services.AddSingleton<ModalService>();
builder.Services.AddSingleton<QuoteService>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

//app.UseWebOptimizer();
app.UseStaticFiles();

app.MapRazorComponents<App>()
    .AddServerRenderMode();

app.Run();
