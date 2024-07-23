using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using PawfectPlaceShop.App.DataAccess.Contexts;
using PawfectPlaceShop.App.DataAccess.Identity;
using PawfectPlaceShop.App.DataAccess.Repositories;
using PawfectPlaceShop.App.DataAccess.UnitOfWorks;
using PawfectPlaceShop.App.Entity.Repositories;
using PawfectPlaceShop.App.Entity.Services;
using PawfectPlaceShop.App.Entity.UnitOfWorks;
using PawfectPlaceShop.App.Service.Mapping;
using PawfectPlaceShop.App.Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Service.Extensions
{
    public static class DependencyExtensions
    {
        public static void AddExtensions(this IServiceCollection services)
        {
            services.AddIdentity<AppUser, AppRole>(
    opt =>
    {
        opt.Password.RequireNonAlphanumeric = false;
        opt.Password.RequiredLength = 3;
        opt.Password.RequireLowercase = false;
        opt.Password.RequireUppercase = false;
        opt.Password.RequireDigit = false;

        opt.User.RequireUniqueEmail = true;  //aynı email adresinin girilmesine izin vermez.

        //opt.User.AllowedUserNameCharacters = "abcdefghijklmnoprstuvyzqw0123456789";  //Kullanıcı adı girilirken sadece bu karakterlere izin verir.

        opt.Lockout.MaxFailedAccessAttempts = 3; //default=5
        opt.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(1); //default=5
    }
).AddEntityFrameworkStores<PetShopDbContext>();

            services.ConfigureApplicationCookie(opt =>
            {
                opt.LoginPath = new PathString("/Account/Login");
                opt.LogoutPath = new PathString("/Account/Logout");
                //opt.AccessDeniedPath = new PathString("/Account/AccessDenied");
                opt.ExpireTimeSpan = TimeSpan.FromMinutes(10);
                opt.SlidingExpiration = true; //10 dk. dolmadan kullanıcı yeniden login olursa süre baştan başlar.

                opt.Cookie = new CookieBuilder()
                {
                    Name = "Identity.App.Cookie",
                    HttpOnly = true
                };
            });
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped(typeof(IAccountService), typeof(AccountService));
            services.AddScoped<IAnimalTypeService, AnimalTypeService>();
            services.AddScoped<IProductCategoryService, ProductCategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IArticleCategoryService, ArticleCategoryService>();
            services.AddScoped<IArticleService, ArticleService>();


            services.AddAutoMapper(typeof(MappingProfile));
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IAccountService, AccountService>();

;
        }
    }
}

