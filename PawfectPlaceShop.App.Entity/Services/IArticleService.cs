using PawfectPlaceShop.App.Entity.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Entity.Services
{
    public interface IArticleService
    {
        Task<List<ArticleViewModel>> GetAll();
        Task<ArticleViewModel> Get(int id);
        Task<List<ArticleViewModel>> GetbyCategoryIdasync(int? id);
        Task<List<ArticleViewModel>> GetbySearch(string? search);
        Task Add(ArticleViewModel model);
        Task<List<ArticleViewModel>> GetLast();
    }
}
