using Microsoft.AspNetCore.Mvc;

namespace PawfectPlaceShop.App.WebMvcUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
