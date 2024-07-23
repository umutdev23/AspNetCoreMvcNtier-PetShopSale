using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Entity.Entities
{
    public class ProductSaleDetail : BaseEntity
    {
        public int ProductSaleId { get; set; }
        public int ProductId { get; set; }
        public int Number { get; set; }
        public decimal UnitPrice { get; set; }

        public ProductSale productSale { get; set; }
        public Product product { get; set; }
    }
}
