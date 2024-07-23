using Microsoft.AspNetCore.Mvc;

namespace PawfectPlaceShop.App.WebMvcUI.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
