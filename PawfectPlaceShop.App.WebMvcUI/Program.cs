using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PawfectPlaceShop.App.DataAccess.Contexts;

using PawfectPlaceShop.App.DataAccess.Identity;
using PawfectPlaceShop.App.Service.Extensions;


var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<PetShopDbContext>(
    options => options.UseSqlServer(
        builder.Configuration.GetConnectionString("ConnStr")));
builder.Services.AddExtensions();

builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30); 
    options.Cookie.HttpOnly = true; 
    options.Cookie.IsEssential = true; 
});

builder.Services.AddHttpContextAccessor();
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
app.UseSession();
app.UseAuthorization();


   
    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
app.MapControllerRoute(
  name: "custom",
  pattern: "{controller=Home}/{action=Index}/{ArticleCategoryId?}");
app.MapControllerRoute(
  name: "custom",
  pattern: "{controller=Home}/{action=Index}/{DetailsId?}");
app.MapControllerRoute(
  name: "custom",
  pattern: "{controller=Home}/{action=Index}/{productId?}");

app.MapControllerRoute(
    name: "custom",
    pattern: "{controller=Home}/{action=Index}/{animalTypeId?}/{productCategoryId?}");
app.MapControllerRoute(
      name: "areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );
app.MapControllerRoute(
      name: "areas",
      pattern: "{controller=Home}/{action=Index}/{id?}/{area=Admin}"
    );
app.MapControllerRoute(
      name: "area",
      pattern: "{controller=Home}/{action=Index}/{area=Admin}"
    );
app.MapControllerRoute(
      name: "area",
      pattern: "{controller=Product}/{action=Index}/{area=Admin}"
    );

//app.MapControllerRoute(
//    name: "areas",
//    pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");

//app.MapControllerRoute(
//    name: "area",
//   pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}");


app.Run();
