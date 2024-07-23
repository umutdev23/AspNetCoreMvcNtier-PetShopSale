using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PawfectPlaceShop.App.Entity.Entities;
using PawfectPlaceShop.App.Entity.Services;
using PawfectPlaceShop.App.WebMvcUI.Models;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using PawfectPlaceShop.App.Entity.ViewModels;
using PawfectPlaceShop.App.WebMvcUI.Extensions;

namespace PawfectPlaceShop.App.WebMvcUI.Controllers
{
    public class BasketController : Controller
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public BasketController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        private List<BasketDetail> GetBasket()
        {
            return HttpContext.Session.GetJson<List<BasketDetail>>("sepet") ?? new List<BasketDetail>();
        }

        private void SaveBasket(List<BasketDetail> basket)
        {
            HttpContext.Session.SetJson("sepet", basket);
        }

        [HttpGet]
        public IActionResult ConfirmOrder()
        {
            if (!User.Identity.IsAuthenticated)
            {
                
                return RedirectToAction("Login", "Account");
            }
         
            var basket = GetBasket();
            if (basket == null || !basket.Any())
            {
                return RedirectToAction("Index");
            }

            var model = new ConfirmOrderViewModel
            {
                BasketItems = _mapper.Map<List<BasketItemViewModel>>(basket),
                Address = new AddressViewModel(),
                Subtotal = basket.Sum(s => s.ProductPrice * s.ProductQuantity),
                Total = basket.Sum(s => s.ProductPrice * s.ProductQuantity) * 1.30m // KDV dahil toplam
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult ConfirmOrder(ConfirmOrderViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var basketItems = GetBasket();
                model.BasketItems = _mapper.Map<List<BasketItemViewModel>>(basketItems);
                model.Subtotal = basketItems.Sum(s => s.ProductPrice * s.ProductQuantity);
                model.Total = model.Subtotal * 1.30m; // KDV dahil toplam

                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    TempData["ErrorMessage"] = (TempData["ErrorMessage"] ?? "") + error.ErrorMessage + "\n";

                }

                var basket = GetBasket();
                var orderDetails = new OrderConfirmedViewModel
                {
                    Address = model.Address,
                    CreditCard = model.CreditCard,
                    Subtotal = model.Subtotal,
                    Total = model.Total,
                    BasketItems = _mapper.Map<List<BasketItemViewModel>>(basket)
                };

                HttpContext.Session.SetJson("orderDetails", orderDetails);

                ClearBasket();

                return RedirectToAction("OrderConfirmed");

            }
            return View(model);

        }

        public IActionResult OrderConfirmed()
        {
            var orderDetails = HttpContext.Session.GetJson<OrderConfirmedViewModel>("orderDetails");
            if (orderDetails == null)
            {
                return RedirectToAction("Index");
            }

            return View(orderDetails);
        }

        public IActionResult Index()
        {
            var basket = GetBasket();
            TempData["ToplamAdet"] = basket.Sum(b => b.ProductQuantity);
            TempData["ToplamTutar"] = basket.Sum(b => b.ProductPrice * b.ProductQuantity).ToString();
            var toplamTutar = basket.Sum(b => b.ProductPrice * b.ProductQuantity);
            var kdvOrani = 0.30m;
            ViewBag.KdvliTutar = (toplamTutar * (1 + kdvOrani)).ToString("C");
            return View(basket);
        }

        [HttpPost]
        public IActionResult UpdateCart(int[] ids, int[] quantities)
        {
            var basket = GetBasket();
            for (int i = 0; i < ids.Length; i++)
            {
                var item = basket.FirstOrDefault(b => b.Id == ids[i]);
                if (item != null)
                {
                    item.ProductQuantity = quantities[i];
                }
            }

            SaveBasket(basket);

            var toplamTutar = basket.Sum(b => b.ProductPrice * b.ProductQuantity);
            TempData["ToplamTutar"] = toplamTutar.ToString("C");
            ViewBag.KdvliTutar = (toplamTutar * 1.30m).ToString("C");

            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Add(int id, int qnt)
        {
            var product = await _productService.GetByIdAsync(id);
            var basket = GetBasket();
            var existingItem = basket.FirstOrDefault(b => b.Id == id);
            if (existingItem != null)
            {
                existingItem.ProductQuantity += qnt;
            }
            else
            {
                var newItem = new BasketDetail
                {
                    Id = product.Id,
                    ProductName = product.Name,
                    ProductQuantity = qnt,
                    ProductPrice = product.Price
                };
                basket.Add(newItem);
            }
            SaveBasket(basket);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var basket = GetBasket();
            var itemToRemove = basket.FirstOrDefault(b => b.Id == id);
            if (itemToRemove != null)
            {
                basket.Remove(itemToRemove);
            }
            SaveBasket(basket);
            return RedirectToAction("Index");
        }

        public IActionResult ClearBasket()
        {
            HttpContext.Session.Remove("sepet");
            return RedirectToAction("Index");
        }
    }
}
