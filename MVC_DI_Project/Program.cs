using MVC_DI_Project;
using MVC_DI_Project.Data;

var builder = WebApplication.CreateBuilder(args);

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
