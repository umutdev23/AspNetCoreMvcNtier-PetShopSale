using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PawfectPlaceShop.App.DataAccess.Identity;
using PawfectPlaceShop.App.Entity.Entities;
using System;

namespace PawfectPlaceShop.App.DataAccess.Contexts
{
    public class PetShopDbContext : IdentityDbContext<AppUser, AppRole, int>
    {
        public PetShopDbContext(DbContextOptions<PetShopDbContext> options) : base(options)
        { }

        public DbSet<AnimalType> AnimalTypes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<ArticleCategory> ArticleCategories { get; set; }
        //public DbSet<BasketDetail> BasketDetails { get; set; }
        public DbSet<ProductSale> ProductSales { get; set; }
        public DbSet<ProductSaleDetail> ProductSaleDetails { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API validation
            modelBuilder.Entity<AnimalType>()
                .Property(g => g.AnimalName).HasMaxLength(100);
            modelBuilder.Entity<Product>()
                .Property(m => m.Name).HasMaxLength(200);
            modelBuilder.Entity<Product>()
                .Property(m => m.IsPopuler).HasDefaultValue(false);
            modelBuilder.Entity<Customer>()
                .Property(c => c.Name).HasMaxLength(100);
            modelBuilder.Entity<Product>()
                .Property(m => m.ImageUrl).HasDefaultValue("/images/default.jpg");
            modelBuilder.Entity<Customer>()
                .Property(m => m.IsAdmin).HasDefaultValue(false);

            // Seed data


            modelBuilder.Entity<ArticleCategory>().HasData(
         new ArticleCategory { Id = 1, Name = "Kedi" },
         new ArticleCategory { Id = 2, Name = "Köpek" },
         new ArticleCategory { Id = 3, Name = "Kuş" },
         new ArticleCategory { Id = 4, Name = "Balık" }
     );

            modelBuilder.Entity<Article>().HasData(
                new Article
                {
                    Id = 1,
                    Title = "Yavru Kedi",
                    Location = "İstanbul, Kadıköy",
                    Content = "Sokakta bulunan sevimli yavru kedi, sıcak bir yuva arıyor. Veteriner kontrolleri yapılmış, iç ve dış parazit tedavisi tamamlanmıştır. Yeni sahibine karnesi ile birlikte teslim edilecektir. Çok oyuncu ve sevecen bir karaktere sahiptir.",
                    ArticleCategoryId = 1,
                    PictureUrl = "https://www.mamaplus.com/storage/uploads/images/Blog/kopek/64b2a543f231b.jpeg",
                    CreatedDate = DateTime.Now,
                    UserId = 1
                },
                new Article
                {
                    Id = 2,
                    Title = "İran Kedisi",
                    Location = "Ankara, Çankaya",
                    Content = "Safkan İran kedisi sahiplendirilecektir. 2 yaşında, tüm aşıları tam, sağlıklı ve bakımlıdır. Yeni sahibine alışması için biraz zaman gerektirebilir. Evde yalnız kalmayı sevmeyen, ilgi isteyen bir kedidir.",
                    ArticleCategoryId = 1,
                    PictureUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=540,quality=99/52768/uploads/blog/persian-iran-kedilerinin-ozellikleri-0663.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = 2
                },
                new Article
                {
                    Id = 3,
                    Title = "Scottish Fold Yavruları",
                    Location = "İzmir, Bornova",
                    Content = "Scottish Fold cinsi 3 aylık yavru kediler sahiplendirilecektir. Tüy dökme sorunu yaşamayan, oyuncu ve sosyal kedilerdir. Veteriner kontrolleri eksiksiz yapılmıştır. Tuvalet eğitimi verilmiştir.",
                    ArticleCategoryId = 1,
                    PictureUrl = "https://www.patibul.com/uploads/ajax/2023/03/03/IMG-4054-6401CD1B83876.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = 3
                },
                new Article
                {
                    Id = 4,
                    Title = "Sarman Kedi",
                    Location = "Antalya, Muratpaşa",
                    Content = "Sokakta yaralı bulunan ve tedavi ettirilen sarman kedi sahiplendirilecektir. 1 yaşında, sevecen ve oyuncudur. Evde çocuklarla iyi anlaşan, sosyal bir kedidir. Karnesi ile birlikte teslim edilecektir.",
                    ArticleCategoryId = 1,
                    PictureUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=540,quality=99/9062/uploads/editoruploads/06a90ea6-87bb-45b8-931f-8ae475b89248-758.jpeg",
                    CreatedDate = DateTime.Now,
                    UserId = 4
                },
                new Article
                {
                    Id = 5,
                    Title = "Golden Retriever Yavruları",
                    Location = "İstanbul, Beşiktaş",
                    Content = "Golden Retriever cinsi 2 aylık yavrular sahiplendirilecektir. Anne sütüyle beslenmiş, sağlık kontrolleri yapılmıştır. Çok enerjik ve oyuncu köpeklerdir. Evde çocuklarla çok iyi anlaşırlar.",
                    ArticleCategoryId = 2,
                    PictureUrl = "https://www.patibul.com/uploads/ajax/2023/02/28/WhatsApp-Image-2023-02-20-at-113214-(1)-63FDABE6E0598.jpeg",
                    CreatedDate = DateTime.Now,
                    UserId = 5
                },
                new Article
                {
                    Id = 6,
                    Title = "Alman Kurdu",
                    Location = "Ankara, Etimesgut",
                    Content = "Safkan Alman Kurdu, 3 yaşında, tüm aşıları yapılmış, sağlıklı ve güçlü bir köpektir. Eğitimi verilmiş, itaatkar ve koruyucu bir yapıya sahiptir. Büyük bahçeli bir eve sahip yeni sahip aranıyor.",
                    ArticleCategoryId = 2,
                    PictureUrl = "https://www.guardiaturca.com/wp-content/uploads/german-shepherd-alman-kurdu-ozellikleri.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = 6
                },
                new Article
                {
                    Id = 7,
                    Title = "Beagle Yavrusu",
                    Location = "İzmir, Karşıyaka",
                    Content = "Beagle cinsi 4 aylık yavru köpek sahiplendirilecektir. Çok enerjik, oyuncu ve sosyal bir yapıya sahiptir. Veteriner kontrolleri yapılmış, karnesi bulunmaktadır. Çocuklarla iyi anlaşan bir köpektir.",
                    ArticleCategoryId = 2,
                    PictureUrl = "https://www.evcilhayvan.market/wp-content/uploads/2017/06/yavru-beagle-kopek.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = 7
                },
                new Article
                {
                    Id = 8,
                    Title = "Terrier Cinsi Köpek",
                    Location = "Antalya, Kepez",
                    Content = "Terrier cinsi 1 yaşındaki köpek sahiplendirilecektir. Küçük ırk, ev içinde yaşamaya uygun, sevecen ve enerjik bir köpektir. Aşıları tam, sağlık durumu çok iyi. Yeni sahibine alışması biraz zaman alabilir.",
                    ArticleCategoryId = 2,
                    PictureUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=540,quality=99/9062//uploads/editoruploads/0yorkshire-terrier.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = 8
                },
                new Article
                {
                    Id = 9,
                    Title = "Muhabbet Kuşu ",
                    Location = "İstanbul, Üsküdar",
                    Content = "Farklı renklerde muhabbet kuşları sahiplendirilecektir. Çok konuşkan, oyuncu ve sağlıklıdırlar. Yeni sahibine kolayca alışacak, evde neşe kaynağı olacaklardır.",
                    ArticleCategoryId = 3,
                    PictureUrl = "https://www.petihtiyac.com/Data/Blog/1/113.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = 9
                },
                new Article
                {
                    Id = 10,
                    Title = "Papağan",
                    Location = "Ankara, Mamak",
                    Content = "Ara papağanı, 1 yaşında, konuşkan ve sosyal bir kuştur. Eğitimli, insanlarla kolayca iletişim kurar. Sağlıklı ve bakımlıdır. Geniş bir kafes ve ilgi isteyen bir kuş olduğu unutulmamalıdır.",
                    ArticleCategoryId = 3,
                    PictureUrl = "https://www.atasehirveteriner.com/upload/images/jako-papagan.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = 10
                },
                new Article
                {
                    Id = 11,
                    Title = "Kanarya",
                    Location = "İzmir, Gaziemir",
                    Content = "Ötücü kanarya, 6 aylık, çok enerjik ve sağlıklıdır. Günde birkaç saat şarkı söyleyen, evin neşesi olacak bir kuştur. Yeni sahibine hızlıca alışacak, kolay bakımı olan bir evcil hayvandır.",
                    ArticleCategoryId = 3,
                    PictureUrl = "https://www.petihtiyac.com/Data/Blog/664.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = 11
                },
                new Article
                {
                    Id = 12,
                    Title = "Saka Kuşu",
                    Location = "Antalya, Konyaaltı",
                    Content = "Saka kuşu, 1 yaşında, çok ötücü ve enerjik bir kuştur. Doğal ortamında bulup sahiplendirdik. Sağlıklı ve neşelidir. Geniş bir kafeste bakılması önerilir.",
                    ArticleCategoryId = 3,
                    PictureUrl = "https://www.petipet.net/uploads/2020/07/images-1-1.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = 12
                },
                new Article
                {
                    Id = 13,
                    Title = "Japon Balığı",
                    Location = "İstanbul, Şişli",
                    Content = "Çeşitli renklerde Japon balıkları, akvaryum içinde harika bir görüntü sağlar. Sağlıklı ve bakımlıdır. Su değişimi ve yemlemesi düzenli yapılmıştır. Yeni sahibine akvaryumla birlikte teslim edilecektir.",
                    ArticleCategoryId = 4,
                    PictureUrl = "https://static.ticimax.cloud/cdn-cgi/image/width=540,quality=99/9062/uploads/editoruploads/japon-baligi.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = 13
                },
                new Article
                {
                    Id = 14,
                    Title = "Betta Balığı",
                    Location = "Ankara, Yenimahalle",
                    Content = "Renkli ve gösterişli Betta balığı sahiplendirilecektir. Sağlıklı, bakımlı ve enerjik bir balıktır. Küçük bir akvaryumda veya fanusta rahatça yaşayabilir. Tek bakılması önerilir.",
                    ArticleCategoryId = 4,
                    PictureUrl = "https://storage.evrimagaci.org/old/content_media/7dc03454e9646168baf5a463fcdd3e6f.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = 14
                },
                new Article
                {
                    Id = 15,
                    Title = "Lepistes Balığı",
                    Location = "İzmir, Buca",
                    Content = "Lepistes balıkları, çeşitli renk ve desenlerde, çok sağlıklı ve bakımlıdır. Akvaryum ortamına kolayca uyum sağlarlar. Bakımları kolay ve keyifli olan balıklardır.",
                    ArticleCategoryId = 4,
                    PictureUrl = "https://storage.evrimagaci.org/old/content_media/3723213440e3ea2a80717dc1969081a2.png",
                    CreatedDate = DateTime.Now,
                    UserId = 15
                },
                new Article
                {
                    Id = 16,
                    Title = "Neon Tetra Balıkları",
                    Location = "Antalya, Alanya",
                    Content = "Neon Tetra balıkları, parlak renkleri ve sürü halinde yüzmeleriyle ünlüdür. Sağlıklı ve enerjik balıklardır. Akvaryum ortamında çok güzel bir görüntü sağlarlar.",
                    ArticleCategoryId = 4,
                    PictureUrl = "https://www.petihtiyac.com/Data/Blog/1/155.jpg",
                    CreatedDate = DateTime.Now,
                    UserId = 16
                }
            );




            modelBuilder.Entity<AnimalType>().HasData(
                    new AnimalType { Id = 1, AnimalName = "Köpek" },
                    new AnimalType { Id = 2, AnimalName = "Kedi" },
                    new AnimalType { Id = 3, AnimalName = "Kuş" },
                    new AnimalType { Id = 4, AnimalName = "Balık" }
                );

            modelBuilder.Entity<ProductCategory>().HasData(
                new ProductCategory { Id = 1, Name = "Mama" },
                new ProductCategory { Id = 2, Name = "Aksesuar" },
                new ProductCategory { Id = 3, Name = "Oyuncak" }
            );

            modelBuilder.Entity<Product>().HasData(
    new Product { Id = 1, Name = "Köpek Maması", Description = "Yüksek kaliteli köpek maması", Price = 50, Stock = 100, ImageUrl = "https://petmekan.com/wp-content/uploads/2023/03/enjoy-kuzu-etli-yetiskin-kopek-mamasi-15-kg-13815.jpg", IsDiscount = false, IsPopuler = true, AnimalTypeId = 1, ProductCategoryId = 1 },
    new Product { Id = 2, Name = "Kedi Oyuncağı", Description = "Renkli ve eğlenceli kedi oyuncağı", Price = 20, Stock = 200, ImageUrl = "https://m.media-amazon.com/images/I/71XTc9mbkfL._AC_UF1000,1000_QL80_.jpg", IsDiscount = true, IsPopuler = false, AnimalTypeId = 2, ProductCategoryId = 3 },
    new Product { Id = 3, Name = "Kuş Kafesi", Description = "Geniş ve konforlu kuş kafesi", Price = 75, Stock = 50, ImageUrl = "https://ferplastturkiye.com/wp-content/uploads/2023/03/8010690087405-1.jpg", IsDiscount = false, IsPopuler = false, AnimalTypeId = 3, ProductCategoryId = 3 },
    new Product { Id = 4, Name = "Balık Akvaryumu", Description = "Geniş ve şık balık akvaryumu", Price = 150, Stock = 20, ImageUrl = "https://image.posta.com.tr/i/posta/75/0x0/6196486145d2a07ffcb0ab64.jpg", IsDiscount = false, IsPopuler = true, AnimalTypeId = 4, ProductCategoryId = 3 },
    new Product { Id = 5, Name = "Kedi Maması", Description = "Sağlıklı ve besleyici kedi maması", Price = 30, Stock = 150, ImageUrl = "https://ideacdn.net/idea/el/24/myassets/products/200/1027124.jpg?revision=1697143329", IsDiscount = true, IsPopuler = false, AnimalTypeId = 2, ProductCategoryId = 1 },
    new Product { Id = 6, Name = "Köpek Tasması", Description = "Dayanıklı ve şık köpek tasması", Price = 25, Stock = 100, ImageUrl = "https://hep21.com/cdn/shop/products/S28a2287c17bf480691a43bcc5e68c90cr.jpg?v=1709507505&width=1445", IsDiscount = true, IsPopuler = true, AnimalTypeId = 1, ProductCategoryId = 2 },
    new Product { Id = 7, Name = "Kuş Yemi", Description = "Vitaminli ve besleyici kuş yemi", Price = 15, Stock = 300, ImageUrl = "https://www.adresemama.com/quik-muhabbet-kusu-yemi-1-kg-98234-76-O.jpg", IsDiscount = false, IsPopuler = true, AnimalTypeId = 3, ProductCategoryId = 1 },
    new Product { Id = 8, Name = "Balık Yemi", Description = "Kaliteli ve besleyici balık yemi", Price = 10, Stock = 400, ImageUrl = "https://productimages.hepsiburada.net/s/27/375-375/10191018328114.jpg", IsDiscount = true, IsPopuler = false, AnimalTypeId = 4, ProductCategoryId = 1 },
    new Product { Id = 9, Name = "Kedi Aksesuar Seti", Description = "Kedi için oyuncak ve aksesuar seti", Price = 40, Stock = 80, ImageUrl = "https://productimages.hepsiburada.net/s/259/375-375/110000242965113.jpg", IsDiscount = false, IsPopuler = true, AnimalTypeId = 2, ProductCategoryId = 2 },
    new Product { Id = 10, Name = "Köpek Oyuncağı", Description = "Dayanıklı ve eğlenceli köpek oyuncağı", Price = 30, Stock = 120, ImageUrl = "https://cdn.myikas.com/images/095577b2-7631-4970-aac8-f67dc0fdb305/9f1981cb-27c2-4f43-8857-cfd946a86ef2/image_1080.jpg", IsDiscount = true, IsPopuler = true, AnimalTypeId = 1, ProductCategoryId = 3 },
    new Product { Id = 11, Name = "Köpek Oyuncağı", Description = "Dayanıklı ve eğlenceli köpek oyuncağı", Price = 30, Stock = 120, ImageUrl = "https://ideacdn.net/idea/it/26/myassets/products/360/pf-4023-playfull-kopek-oyuncagi-28x95-cm-kopek-oyuncaklari-playfull-1622-70-o.jpg?revision=1712226517", IsDiscount = true, IsPopuler = true, AnimalTypeId = 1, ProductCategoryId = 3 },
    new Product { Id = 12, Name = "Köpek Tasması", Description = "Köpeğiniz için rahat ve dayanıklı tasma seti", Price = 25, Stock = 100, ImageUrl = "https://productimages.hepsiburada.net/s/439/375-375/110000472848675.jpg", IsDiscount = false, IsPopuler = true, AnimalTypeId = 1, ProductCategoryId = 2 },
    new Product { Id = 13, Name = "Kedi Tırmalama Ağacı", Description = "Kediniz için rahatlatıcı ve dayanıklı tırmalama ağacı", Price = 50, Stock = 80, ImageUrl = "https://www.turuncu-sepet.com/wp-content/uploads/2022/04/kedi-tirmalama-tahtasi-55-cm-kedi-figurlu-2270.jpg", IsDiscount = false, IsPopuler = true, AnimalTypeId = 2, ProductCategoryId = 3 },
    new Product { Id = 14, Name = "Geniş Kuş Kafesi", Description = "Kuşunuz için geniş ve konforlu kafes", Price = 40, Stock = 60, ImageUrl = "https://www.ferhatyazan.com.tr/images_1/Easyfashion-haddeleme-geni%C5%9F-ku%C5%9F-kafesi-b%C3%B6l%C3%BCnm%C3%BC%C5%9F-214386_upload.jpg", IsDiscount = true, IsPopuler = true, AnimalTypeId = 3, ProductCategoryId = 3 },
    new Product { Id = 15, Name = "Akvaryum Seti", Description = "Balıklarınız için modern ve şık akvaryum seti", Price = 70, Stock = 30, ImageUrl = "https://cdn.akakce.com/z/ans/ans-full-hazir-seti-30-x-2-5-x-14-cm-10-parca.jpg", IsDiscount = false, IsPopuler = true, AnimalTypeId = 4, ProductCategoryId = 3 },
    new Product { Id = 16, Name = "Köpek Kuru Maması", Description = "Sağlıklı ve dengeli beslenme için köpek kuru maması", Price = 55, Stock = 90, ImageUrl = "https://cdn03.ciceksepeti.com/cicek/kcm9336886-1/L/proart-pupy-yavru-kopek-kuru-mama-3-kg-kcm9336886-1-a434d38ce7e547c28f0f4f3618a8f1f5.jpg", IsDiscount = false, IsPopuler = true, AnimalTypeId = 1, ProductCategoryId = 1 },
    new Product { Id = 17, Name = "Köpek Yatak", Description = "Konforlu ve yumuşak köpek yatağı", Price = 40, Stock = 70, ImageUrl = "https://www.petimce.com/i/l/002/0022207_peggy-luna-kopek-yatagi-gri-large.jpeg", IsDiscount = true, IsPopuler = true, AnimalTypeId = 1, ProductCategoryId = 2 },
    new Product { Id = 18, Name = "Kedi Konservesi", Description = "Lezzetli ve sağlıklı kedi konservesi", Price = 10, Stock = 120, ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR9OY7lELsmTfa86oCGGB3LNIi4aDn5YLJfFw&s", IsDiscount = true, IsPopuler = true, AnimalTypeId = 2, ProductCategoryId = 1 },
    new Product { Id = 19, Name = "Kedi Oyun Tüneli", Description = "Eğlenceli ve oyun dolu kedi oyun tüneli", Price = 20, Stock = 100, ImageUrl = "https://static.ticimax.cloud/2601/uploads/urunresimleri/buyuk/trixie-2-bolmeli-pelus-ve-jut-kumasli--4c956f.jpg", IsDiscount = false, IsPopuler = true, AnimalTypeId = 2, ProductCategoryId = 3 },
    new Product { Id = 20, Name = "Muhabbet Kuşu Yemi", Description = "Muhabbet kuşlarınız için özel karışım yem", Price = 8, Stock = 150, ImageUrl = "https://www.adresemama.com/gold-wings-classic-yavru-muhabbet-kusu-yemi-400-gr-98926-76-B.jpg", IsDiscount = false, IsPopuler = true, AnimalTypeId = 3, ProductCategoryId = 1 }

            );

            modelBuilder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Ahmet Yılmaz", Email = "ahmet@example.com", Password = "password123", Phone = "5555555555", Address = "İstanbul, Türkiye", IsAdmin = false },
                new Customer { Id = 2, Name = "Ayşe Demir", Email = "ayse@example.com", Password = "password123", Phone = "5555555556", Address = "Ankara, Türkiye", IsAdmin = true }
            );

            modelBuilder.Entity<ProductSale>().HasData(
                new ProductSale { Id = 1, Date = DateTime.Now, CustomerId = 1, TotalQuantity = 2, TotalPrice = 120 }
            );

            modelBuilder.Entity<ProductSaleDetail>().HasData(
                new ProductSaleDetail { Id = 1, ProductSaleId = 1, ProductId = 1, Number = 2, UnitPrice = 50 },
                new ProductSaleDetail { Id = 2, ProductSaleId = 1, ProductId = 2, Number = 1, UnitPrice = 20 }
            );

            base.OnModelCreating(modelBuilder);
        }

        internal object Where(Func<object, bool> value)
        {
            throw new NotImplementedException();
        }
    }
}
