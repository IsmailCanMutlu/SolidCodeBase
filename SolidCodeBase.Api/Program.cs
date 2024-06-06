using Microsoft.EntityFrameworkCore;
using SolidCodeBase.Api.Components;
using Microsoft.Extensions.DependencyInjection;
using SolidCodeBase.Core.Interfaces;
using SolidCodeBase.Core.Models;
using SolidCodeBase.Core.Services;
using SolidCodeBase.Data;
using SolidCodeBase.Data.Repositories;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

// Dependency Injection
builder.Services.AddTransient<IInvoiceService, InvoiceService>();
builder.Services.AddTransient<IBaseRepository<Invoice>, InvoiceRepository>();
builder.Services.AddTransient<IBaseRepository<User>, UserRepository>();

// Database connection
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));


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