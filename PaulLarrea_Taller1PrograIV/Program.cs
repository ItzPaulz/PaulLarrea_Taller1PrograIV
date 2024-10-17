using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PaulLarrea_Taller1PrograIV.Data;
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<PaulLarrea_Taller1PrograIVContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("PaulLarrea_Taller1PrograIVContext") ?? throw new InvalidOperationException("Connection string 'PaulLarrea_Taller1PrograIVContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
