using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using PawfectPlaceShop.App.Entity.Services;
using PawfectPlaceShop.App.Entity.ViewModels;

namespace PawfectPlaceShop.App.WebMvcUI.Controllers
{
    public class ProductController : Controller
    {

        private readonly IAnimalTypeService _animalTypeService;
        private readonly IProductCategoryService _productCategoryService;
        private readonly IProductService _productService;
        private readonly IArticleCategoryService _categoryService;
        private readonly IAccountService _accountService;


        private readonly ILogger<HomeController> _logger;


        public ProductController(IAnimalTypeService animalTypeService, IProductCategoryService productCategoryService, IProductService productService, ILogger<HomeController> logger, IArticleCategoryService categoryService, IAccountService accountService)
        {
            _animalTypeService = animalTypeService;
            _productCategoryService = productCategoryService;
            _productService = productService;
            _logger = logger;
            _categoryService = categoryService;
            _accountService = accountService;
        }


        public async Task<IActionResult> Index(int? animalTypeId, int? productCategoryId,string? search)
        {
            var AllProducts = await _productService.GetAllAsync();

            ViewBag.Categories = await _productCategoryService.GetAllAsync();
            ViewBag.AnimalType = await _animalTypeService.GetAllAsync();
            ViewBag.SaleOff = await _productService.GetSaleOffAsync();
            ViewBag.LastProduct = await _productService.GetLastAsync();
            ViewBag.Populer = await _productService.GetPopulerList();
            if (search != null)
            {
                AllProducts = await _productService.GetSearch(search);
                return View(AllProducts);

            }
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
            if (productCategoryId != null)
            {
                AllProducts = await _productService.GetByCategoryId(animalTypeId);
                return View(AllProducts);

            }
          

            return View(AllProducts);
        }

        public async Task<IActionResult> Create()
        {
            var categories = await _productCategoryService.GetAllAsync();
            ViewBag.Categories = new SelectList(categories, "Id", "Name");

            var model = new ProductViewModel(); // Boş bir ProductViewModel örneği oluşturuyoruz

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Create(ProductViewModel model, IFormFile formFile)
        {
            if (ModelState.IsValid)
            {
                if (formFile != null && formFile.Length > 0)
                {
                    var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", formFile.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await formFile.CopyToAsync(stream);
                    }

                    model.ImageUrl = "/images/" + formFile.FileName;
                }

                var user = _accountService.Find(User.Identity.Name);
                model.Id = user.Id;

                // ProductService kullanarak yeni ürünü ekliyoruz
                await _productService.Add(new ProductViewModel
                {
                    Name = model.Name,
                    Description = model.Description,
                    Price = model.Price,
                    Stock = model.Stock,
                    ImageUrl = model.ImageUrl,
                    AnimalTypeId = model.AnimalTypeId,
                    ProductCategoryId = model.ProductCategoryId,
                    Id = model.Id // Kullanıcı ID'si
                });

                await _productService.Add(model);
                return View(model);
            }

            //var categories = await _categoryService.GetAll();
            //ViewBag.Categories = new SelectList(categories, "Id", "Name");
            return RedirectToAction("Admin");
        }
        //[HttpPost]
        //public async Task<IActionResult> Create(ProductViewModel model, IFormFile formFile)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        if (formFile != null && formFile.Length > 0)
        //        {
        //            var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/images", formFile.FileName);
        //            using (var stream = new FileStream(path, FileMode.Create))
        //            {
        //                await formFile.CopyToAsync(stream);
        //            }

        //            model.ImageUrl = "/images/" + formFile.FileName;
        //        }

        //        Kullanıcı ID'sini doğrudan model'e atayabiliriz
        //        var user = _accountService.Find(User.Identity.Name);
        //        model.Id = user.Id;

        //        ProductService kullanarak yeni ürünü ekliyoruz
        //       await _productService.AddAsync(model);

        //        return RedirectToAction("Admin");
        //    }

        //    var categories = await _categoryService.GetAll();
        //    ViewBag.Categories = new SelectList(categories, "Id", "Name");
        //    return RedirectToAction("Admin");
        //}


        public async Task<IActionResult> Details(int productId)
        {
            ViewBag.SameProduct =await _productService.GetLastAsync();
            var singleDetail = await _productService.GetByIdAsync(productId);
            return View(singleDetail);
        }

    }
}
