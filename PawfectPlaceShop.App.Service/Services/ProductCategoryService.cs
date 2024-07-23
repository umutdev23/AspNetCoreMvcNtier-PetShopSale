using AutoMapper;
using PawfectPlaceShop.App.Entity.Entities;
using PawfectPlaceShop.App.Entity.Services;
using PawfectPlaceShop.App.Entity.UnitOfWorks;
using PawfectPlaceShop.App.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Service.Services
{
    public class ProductCategoryService : IProductCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _map;

        public ProductCategoryService(IUnitOfWork unitOfWork, IMapper map)
        {
            _unitOfWork = unitOfWork;
            _map = map;
        }

        public async Task<ProductCategoryViewModel> GetById(int id)
        {
            var GetByIdCategory = await _unitOfWork.GetRepository<ProductCategory>().GetByIdAsync(id);
            return _map.Map<ProductCategoryViewModel>(GetByIdCategory);
        }

        async Task<List<ProductCategoryViewModel>> IProductCategoryService.GetAllAsync()
        {

            var GetCategory = await _unitOfWork.GetRepository<ProductCategory>().GetAllAsync();
            return _map.Map<List<ProductCategoryViewModel>>(GetCategory);
        }

     

       
        
    }
}
