using AutoMapper;
using PawfectPlaceShop.App.DataAccess.UnitOfWorks;
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
    public class ArticleService : IArticleService
    {
        private readonly IUnitOfWork _uow;
        private readonly IMapper _mapper;
        public ArticleService(IUnitOfWork uow, IMapper mapper)
        {
            _uow = uow;
            _mapper = mapper;
        }
        public async Task<List<ArticleViewModel>> GetAll()
        {
            //_uow.GetRepository<Article>() -> Repository<Article> karşılık gelir.
            var list = await _uow.GetRepository<Article>().GetAllAsync();

            return _mapper.Map<List<ArticleViewModel>>(list);
        }
        public async Task Add(ArticleViewModel model)
        {
            await _uow.GetRepository<Article>().Add(_mapper.Map<Article>(model));
            await _uow.CommitAsync();   //SaveChangesAsync();
        }

        public async Task<ArticleViewModel> Get(int id)
        {
            var article = await _uow.GetRepository<Article>().GetByIdAsync(id);
            return _mapper.Map<ArticleViewModel>(article);
        }

        public async Task<List<ArticleViewModel>> GetbyCategoryIdasync(int? id)
        {
            var articleByCategoryId = await _uow.GetRepository<Article>().GetAll(p => p.ArticleCategoryId == id);
            return _mapper.Map<List<ArticleViewModel>>(articleByCategoryId);
        }

        public async Task<List<ArticleViewModel>> GetbySearch(string? search)
        {
            var articleByCategoryId = await _uow.GetRepository<Article>().GetAll(p => p.Title.ToLower().Contains(search.ToLower().Trim()));
            return _mapper.Map<List<ArticleViewModel>>(articleByCategoryId);

        }

        public async Task<List<ArticleViewModel>> GetLast()
        {


            var getLastArticle = await _uow.GetRepository<Article>().GetAll(
                orderby: q => q.OrderByDescending(p => p.CreatedDate)
            );


            var lastArticle = getLastArticle.Take(3).ToList();

            return _mapper.Map<List<ArticleViewModel>>(lastArticle);
        }
    }
}
