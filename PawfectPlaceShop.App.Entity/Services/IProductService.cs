using PawfectPlaceShop.App.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Entity.Services
{
    
    public interface IProductService
    {
        Task<List<ProductViewModel>> GetAllAsync();
        Task<ProductViewModel> GetByIdAsync(int id);
        Task<List<ProductViewModel>> GetByCategoryId(int? id);
        Task<List<ProductViewModel>> GetByAnimalTypeId(int? id);
        Task DeleteAsync(ProductViewModel model);
        Task Update (ProductViewModel model);
        Task<List<ProductViewModel>> GetByCategoryandAnimalTypeId(int? categoryId, int? animaltypeId);

        Task Add(ProductViewModel model);

        Task<List<ProductViewModel>> GetSearch(string? search);
        Task<List<ProductViewModel>> GetSaleOffAsync();
        Task<List<ProductViewModel>> GetPopulerList();
        Task<List<ProductViewModel>> GetLastAsync();
    }
}
