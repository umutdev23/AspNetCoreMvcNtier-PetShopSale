using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Entity.Entities
{
    public class ProductSale : BaseEntity
    {

        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }

        public Customer customer { get; set; }

        public List<ProductSaleDetail> productSaleDetails { get; set; }
    }
}
