using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Entity.ViewModels
{
    public class OrderConfirmedViewModel
    {


        public AddressViewModel Address { get; set; }
        public CreditCardViewModel CreditCard { get; set; }
        public decimal Subtotal { get; set; }
        public decimal Total { get; set; }
        public List<BasketItemViewModel> BasketItems { get; set; }
    }
}
