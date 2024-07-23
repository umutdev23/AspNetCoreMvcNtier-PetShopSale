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
    public class ArticleCategoryService : IArticleCategoryService
    {
        private readonly IUnitOfWork unitOf;
        private readonly IMapper mapper;

        public ArticleCategoryService(IUnitOfWork unitOf, IMapper mapper)
        {
            this.unitOf = unitOf;
            this.mapper = mapper;
        }

        public async Task<List<ArticleCategoryViewModel>> GetAllArticleCategoriesAsync()
        {
            var ArticleCategories = await unitOf.GetRepository<ArticleCategory>().GetAllAsync();
            return mapper.Map<List<ArticleCategoryViewModel>>(ArticleCategories);
        }

        public async Task<ArticleCategoryViewModel> GetById(int id)
        {
            var ArticleCategories = await unitOf.GetRepository<ArticleCategory>().GetByIdAsync(id);
            return mapper.Map<ArticleCategoryViewModel>(ArticleCategories);
        }
    }
}
