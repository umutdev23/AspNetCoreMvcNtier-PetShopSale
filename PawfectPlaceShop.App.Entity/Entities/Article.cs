using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PawfectPlaceShop.App.Entity.Entities
{
    public  class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Location { get; set; }
        public  string Content { get; set; }
        public int  ArticleCategoryId { get; set; }
        public string PictureUrl { get; set; }
        public DateTime CreatedDate { get; set; }=DateTime.Now;
        public int UserId { get; set; }     
        public  ArticleCategory articleCategory  { get; set; }

    }
}
