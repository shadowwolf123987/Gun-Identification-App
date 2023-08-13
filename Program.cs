using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<Gun_Identification_App.Data.DBContext>(x => x.UseSqlServer("Data Source=laptop-94o8d071;Initial Catalog=GunIdTool;Persist Security Info=True;Trust Server Certificate=True;User ID=admin;Password=2xBz=kd!npJ"));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
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
