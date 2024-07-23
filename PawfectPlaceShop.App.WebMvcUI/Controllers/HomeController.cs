using Microsoft.AspNetCore.Mvc;
using PawfectPlaceShop.App.Entity.Entities;
using PawfectPlaceShop.App.Entity.Services;
using PawfectPlaceShop.App.WebMvcUI.Models;
using System.Diagnostics;

namespace PawfectPlaceShop.App.WebMvcUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAnimalTypeService _animalTypeService;
        private readonly IProductCategoryService _productCategoryService;
        private readonly IProductService _productService;
        private readonly IArticleService articleService;

        private readonly ILogger<HomeController> _logger;


        public HomeController(IAnimalTypeService animalTypeService, IProductCategoryService productCategoryService, IProductService productService, ILogger<HomeController> logger, IArticleService articleService)
        {
            _animalTypeService = animalTypeService;
            _productCategoryService = productCategoryService;
            _productService = productService;
            _logger = logger;
            this.articleService = articleService;
        }

        public async Task<IActionResult> Index(int? animalTypeId, int? productCategoryId,string? search)
        {
            var AllProducts = await _productService.GetAllAsync();

            ViewBag.Categories = await _productCategoryService.GetAllAsync();
            ViewBag.AnimalType = await _animalTypeService.GetAllAsync();
            ViewBag.SaleOff = await _productService.GetSaleOffAsync();
            ViewBag.LastProduct = await _productService.GetLastAsync();
            ViewBag.Populer = await _productService.GetPopulerList();
            ViewBag.GetLastArticle = await articleService.GetLast();

            if (productCategoryId != null && animalTypeId != null)
            {
                AllProducts = await _productService.GetByCategoryandAnimalTypeId(productCategoryId, animalTypeId);
                return View(AllProducts);
            };
            if (animalTypeId != null)
            {
                AllProducts = await _productService.GetByAnimalTypeId(animalTypeId);

                return View(AllProducts);
            }
            if (productCategoryId != null) {
                AllProducts = await _productService.GetByCategoryId(animalTypeId);
                return View(AllProducts);

            }
            if (search != null)
            {
                AllProducts = await _productService.GetSearch(search);
                return RedirectToAction("Index", "Product", new { search = search });
            }

            return View(AllProducts); }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Entity.Entities.ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

       

     
    }

