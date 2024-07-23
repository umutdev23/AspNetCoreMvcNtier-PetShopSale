using PawfectPlaceShop.App.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Entity.Services
{
    public interface IProductCategoryService
    {
        Task<List<ProductCategoryViewModel>> GetAllAsync();
        Task<ProductCategoryViewModel> GetById(int id);
    }
}
