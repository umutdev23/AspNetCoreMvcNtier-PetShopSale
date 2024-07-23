using PawfectPlaceShop.App.Entity.Entities;
using PawfectPlaceShop.App.Entity.UnitOfWorks;
using PawfectPlaceShop.App.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Entity.Services
{
    public interface IArticleCategoryService
    {
        Task<List<ArticleCategoryViewModel>> GetAllArticleCategoriesAsync();
        Task<ArticleCategoryViewModel> GetById(int id);


      }
    }

