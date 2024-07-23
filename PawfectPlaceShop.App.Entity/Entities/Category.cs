using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Entity.Entities
{
    public class Category : BaseEntity
    {

        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<Article> articles { get; set; }
    }
}
