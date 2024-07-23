using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using PawfectPlaceShop.App.Entity.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Service.Services
{
    public class BasketService : IBasketService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IProductService _productService;

        public BasketService(IHttpContextAccessor httpContextAccessor, IProductService productService)
        {
            _httpContextAccessor = httpContextAccessor;
            _productService = productService;
        }

        private ISession Session => _httpContextAccessor.HttpContext.Session;

        private List<BasketDetail> GetBasketFromSession()
        {
            var basketJson = Session.GetString("Basket");
            if (string.IsNullOrEmpty(basketJson))
            {
                return new List<BasketDetail>();
            }
            return JsonConvert.DeserializeObject<List<BasketDetail>>(basketJson);
        }

        private void SaveBasketToSession(List<BasketDetail> basket)
        {
            var basketJson = JsonConvert.SerializeObject(basket);
            Session.SetString("Basket", basketJson);
        }

        public List<BasketDetail> GetBasket()
        {
            return GetBasketFromSession();
        }

        public async Task AddToBasket(int productId, int quantity)
        {
            var basket = GetBasketFromSession();
            var product = await _productService.GetByIdAsync(productId);
            var existingItem = basket.FirstOrDefault(b => b.Id == productId);

            if (existingItem != null)
            {
                existingItem.ProductQuantity += quantity;
            }
            else
            {
                basket.Add(new BasketDetail
                {
                    Id = product.Id,
                    ProductName = product.Name,
                    ProductPrice = product.Price,
                    ProductQuantity = quantity
                });
            }

            SaveBasketToSession(basket);
        }

        public void UpdateBasketItem(int id, int quantity)
        {
            var basket = GetBasketFromSession();
            var existingItem = basket.FirstOrDefault(b => b.Id == id);

            if (existingItem != null)
            {
                existingItem.ProductQuantity = quantity;
            }

            SaveBasketToSession(basket);
        }

        public void RemoveFromBasket(int id)
        {
            var basket = GetBasketFromSession();
            var itemToRemove = basket.FirstOrDefault(b => b.Id == id);

            if (itemToRemove != null)
            {
                basket.Remove(itemToRemove);
            }

            SaveBasketToSession(basket);
        }

        public void ClearBasket()
        {
            Session.Remove("Basket");
        }

        public decimal GetBasketTotal()
        {
            var basket = GetBasketFromSession();
            return basket.Sum(b => b.ProductPrice * b.ProductQuantity);
        }

        // Implementation of the IBasketService interface
        void IBasketService.SaveBasket(List<BasketDetail> basket)
        {
            SaveBasketToSession(basket);
        }

        void IBasketService.AddToBasket(int productId, int quantity)
        {
            // Directly calling the public async method
            AddToBasket(productId, quantity).GetAwaiter().GetResult();
        }
    }
}
