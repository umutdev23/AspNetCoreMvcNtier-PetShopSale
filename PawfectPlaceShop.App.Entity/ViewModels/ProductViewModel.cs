using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Entity.ViewModels
{
    public class ProductViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string ImageUrl { get; set; }
        public bool IsDiscount { get; set; }
        public bool IsPopuler { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

        public int AnimalTypeId { get; set; }



        public int ProductCategoryId { get; set; }

    }
}
