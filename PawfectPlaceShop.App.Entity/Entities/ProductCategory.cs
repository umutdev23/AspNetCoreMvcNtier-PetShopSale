using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Entity.Entities
{
    public class ProductCategory : BaseEntity
    {
        public string Name { get; set; }
        public List<Product> products { get; set; }
    }
}
