using MVC_DI_Project;
using MVC_DI_Project.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<MVC_DI_ProjectContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("MVC_DI_ProjectContext") ?? throw new InvalidOperationException("Connection string 'MVC_DI_ProjectContext' not found.")));

builder.Services.AddControllersWithViews();

// ============== DI ================

builder.Services.AddSingleton<IComputerService, ComputerService>();
builder.Services.AddSingleton<IDatabase, ComputerDatabase>();

// ==================================

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
