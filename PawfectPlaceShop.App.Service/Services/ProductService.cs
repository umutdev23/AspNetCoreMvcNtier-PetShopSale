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
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _map;

        public ProductService(IUnitOfWork unitOfWork, IMapper map)
        {
            _unitOfWork = unitOfWork;
            _map = map;
        }

        public async Task Add(ProductViewModel model)
        {
            await _unitOfWork.GetRepository<Product>().Add(_map.Map<Product>(model));
            await _unitOfWork.CommitAsync();
        }

        public async Task DeleteAsync(ProductViewModel model)
        {
             _unitOfWork.GetRepository<Product>().Delete(_map.Map<Product>(model));
            await _unitOfWork.CommitAsync();
        }

        public async Task<List<ProductViewModel>> GetAllAsync()
        {
           var ProductList =await _unitOfWork.GetRepository<Product>().GetAllAsync();
            return _map.Map<List<ProductViewModel>>(ProductList);
        }

      

       

        public async Task<ProductViewModel> GetByIdAsync(int id)
        {
            var GetById= await _unitOfWork.GetRepository<Product>().GetByIdAsync(id);

            return _map.Map<ProductViewModel>(GetById);
        }

        public async Task Update(ProductViewModel model)
        {
            _unitOfWork.GetRepository<Product>().Update(_map.Map<Product>(model));
            await _unitOfWork.CommitAsync();
        }

        public async Task<List<ProductViewModel>> GetByAnimalTypeId(int? id)
        {
            var GetByAnimalType = await _unitOfWork.GetRepository<Product>().GetAll(p => p.AnimalTypeId == id);
            return _map.Map<List<ProductViewModel>>(GetByAnimalType);
        }

        public async Task<List<ProductViewModel>> GetByCategoryandAnimalTypeId(int? categoryId,int? animaltypeId)
        {
            var GetByAllFilter = await _unitOfWork.GetRepository<Product>().GetAll(p => p.ProductCategoryId == categoryId && p.AnimalTypeId==animaltypeId);
            return _map.Map<List<ProductViewModel>>(GetByAllFilter);

        }

        public async Task<List<ProductViewModel>> GetByCategoryId(int? id)
        {
            var GetByCategoryId = await _unitOfWork.GetRepository<Product>().GetAll(p => p.ProductCategoryId == id);
            return _map.Map<List<ProductViewModel>>(GetByCategoryId);
        }

        public async Task<List<ProductViewModel>> GetSearch(string? search)
        {
            var GetSearch = await _unitOfWork.GetRepository<Product>().GetAll(p => p.Name.ToLower().Contains(search.ToLower().Trim()));
            return  _map.Map<List<ProductViewModel>>(GetSearch);

        }


        public async Task<List<ProductViewModel>> GetSaleOffAsync()
        {
            var getSaleOf = await _unitOfWork.GetRepository<Product>().GetAll(g => g.IsDiscount == true);
            return _map.Map<List<ProductViewModel>>(getSaleOf);
        }

        public async Task<List<ProductViewModel>> GetLastAsync()
        {
            var getLastProduct = await _unitOfWork.GetRepository<Product>().GetAll(
                orderby: q => q.OrderByDescending(p => p.CreatedDate)
            );

            // Take(10) çağrısını burada yaparak son 10 ürünü alıyoruz
            var lastProducts = getLastProduct.Take(9).ToList();

            return _map.Map<List<ProductViewModel>>(lastProducts);
        }

        public async Task<List<ProductViewModel>> GetPopulerList()
        {
            var PopulerList = await _unitOfWork.GetRepository<Product>().GetAll(p => p.IsPopuler == true);

            return _map.Map<List<ProductViewModel>>(PopulerList);
        }

        
    }
}
