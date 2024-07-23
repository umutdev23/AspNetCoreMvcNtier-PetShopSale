using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Entity.Services
{
    public interface IBasketService
    {
        List<BasketDetail> GetBasket();
        void SaveBasket(List<BasketDetail> basket);
        void ClearBasket();
        void AddToBasket(int productId, int quantity);
        void UpdateBasketItem(int id, int quantity);
        void RemoveFromBasket(int id);
        decimal GetBasketTotal();
    }
}
