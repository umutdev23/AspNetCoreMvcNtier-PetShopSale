using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Entity.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; }
        public bool IsDiscount { get; set; } = false;
        public bool IsPopuler { get; set; } = false;
        public DateTime CreatedDate { get; set; }= DateTime.Now;
        public int AnimalTypeId { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductCategory productCategory { get; set; }
        public AnimalType animalType { get; set; }

        public List<ProductSaleDetail> productSaleDetails { get; set; }

    }
}
