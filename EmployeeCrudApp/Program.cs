
using EmployeeCrudApp.Components;
using EmployeeCrudApp.Interface.Employee;
using EmployeeCrudApp.MappingProfile;
using EmployeeCrudApp.Models;
using EmployeeCrudApp.Services.Employee;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using EmployeeCrudApp.MappingProfile;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddMudServices();
// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();
builder.Services.AddDbContext<PracticedbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("practicedb")));
builder.Services.AddTransient<PracticedbContext, PracticedbContext>();
//builder.Services.AddAutoMapper(typeof(MappingProfiles));

builder.Services.AddScoped<IEmployeeRepository, EmployeeService>();




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
//app.MapBlazorHub();
//app.MapFallbackToPage("/_Host");
//app.MapRazorPages();

app.Run();
