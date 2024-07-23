using PawfectPlaceShop.App.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Entity.Entities
{
    public class Address
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public string StreetAddress { get; set; }
        public string Apartment { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
    }

    public class Order : BaseEntity
    {
        public Address Address { get; set; }
        public string PaymentMethod { get; set; }
        public decimal TotalAmount { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }

    public class OrderItem
    {
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
public class BasketDetail : BaseEntity
{
    public string ProductName { get; set; }
    public int ProductQuantity { get; set; }
    public decimal ProductPrice { get; set; }
    



    public List<BasketDetail> AddBasket(List<BasketDetail> basket, BasketDetail order)  // basket: sepet, order: sipariş
    {
        if (basket.Any(b => b.Id == order.Id))  // yeni eklenecek sipariş sepette daha önce var mı'nın kontrolü(any:bool döndürür)
        {
            foreach (var item in basket)
            {
                // aynı ürünü bulup, miktarını sipariş miktarı kadar artırıyoruz
                if (item.Id == order.Id)
                {
                    item.ProductQuantity += order.ProductQuantity;
                }
            }
        }
        else
        {
            // yeni ürün ilk kez sepete atılacak
            basket.Add(order);
        }
        return basket;
    }
    public void UpdateBasketDetail(int id, int quantity, List<BasketDetail> basket)
    {
        var item = basket.FirstOrDefault(b => b.Id == id);
        if (item != null)
        {
            item.ProductQuantity = quantity;
        }
    }

    public List<BasketDetail> DeleteBasket(List<BasketDetail> basket, int id)
    {
        basket.RemoveAll(b => b.Id == id);
        return basket;

    }
    public int SumQuantity(List<BasketDetail> basket)  //toplam adet
    {
        var sumQnt = basket.Sum(b => b.ProductQuantity);
        return sumQnt;
    }
    public decimal SumAmount(List<BasketDetail> basket)  //toplam tutar
    {
        if (basket == null)
        {
            throw new ArgumentNullException(nameof(basket), "Basket cannot be null.");
        }

        return basket.Sum(s => s.ProductPrice * s.ProductQuantity);

    }
}

