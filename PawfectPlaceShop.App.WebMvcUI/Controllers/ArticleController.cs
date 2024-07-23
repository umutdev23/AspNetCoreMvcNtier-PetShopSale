using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PawfectPlaceShop.App.Entity.Services;
using PawfectPlaceShop.App.Entity.ViewModels;

namespace PawfectPlaceShop.App.WebMvcUI.Controllers
{
    public class ArticleController : Controller
    {
        private readonly IArticleService articleService;
        private readonly IArticleCategoryService articleCategoryService;
        private readonly IAccountService accountService;

        public ArticleController(IArticleService articleService, IAccountService accountService,  IArticleCategoryService articleCategoryService)
        {
            this.articleService = articleService;
            this.accountService = accountService;
            this.articleCategoryService = articleCategoryService;
        }





        public async Task<IActionResult> Index(int? articleId, string? search)
        {
            var AllArticle = await articleService.GetAll();
            ViewBag.ArticleCategories = await articleCategoryService.GetAllArticleCategoriesAsync();
            ViewBag.GetLastArticle = await articleService.GetLast();

            if (articleId != null)
            {
                AllArticle = await articleService.GetbyCategoryIdasync(articleId);
            }
            if (search != null)
            {
                AllArticle = await articleService.GetbySearch(search);

            }
            return View(AllArticle);
        }
        public async Task<IActionResult> Details(int detailsId)
        {
            var singleArticle = await articleService.Get(detailsId);
            ViewBag.GetLastArticles = await articleService.GetLast();

            return View(singleArticle);
        }
        [Authorize(Roles = "Author")]
        public async Task<IActionResult> Create()
        {
            var categories = await articleCategoryService.GetAllArticleCategoriesAsync();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(ArticleViewModel model, IFormFile formFile)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot//images", formFile.FileName);
            var stream = new FileStream(path, FileMode.Create);
            formFile.CopyTo(stream);
            model.PictureUrl = "/images/" + formFile.FileName;
            var user = accountService.Find(User.Identity.Name);
            model.UserId = user.Id;
            await articleService.Add(model);
            return RedirectToAction("Index");
        }

        public override bool Equals(object? obj)
        {
            return obj is ArticleController controller &&
                   EqualityComparer<IArticleCategoryService>.Default.Equals(articleCategoryService, controller.articleCategoryService);
        }
    }
}
