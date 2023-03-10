using Bai1_Layout.Models;
using Bai1_Layout.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var connectionsString = builder.Configuration.GetConnectionString("QlbanValiContext");
builder.Services.AddDbContext<QlbanVaLiContext>(x => x.UseSqlServer(connectionsString));
builder.Services.AddScoped<ILoaiSpRepository, LoaiSpRepository>();
builder.Services.AddScoped<IQuocGiaRepository, QuocGiaRepository>();
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
