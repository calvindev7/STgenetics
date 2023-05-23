using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using STgenetics.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<STgeneticsContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("STgeneticsContext") ?? throw new InvalidOperationException("Connection string 'STgeneticsContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
