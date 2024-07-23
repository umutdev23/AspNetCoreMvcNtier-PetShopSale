using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Entity.Entities
{
    public class AnimalType : BaseEntity
    {
        public string AnimalName { get; set; }
        public List<Product> products { get; set; }
    }
}
