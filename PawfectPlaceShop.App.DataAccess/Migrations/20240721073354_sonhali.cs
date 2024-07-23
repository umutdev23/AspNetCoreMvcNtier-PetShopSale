using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PawfectPlaceShop.App.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class sonhali : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AnimalTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AnimalName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimalTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ArticleCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ArticleCategoryId = table.Column<int>(type: "int", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Articles_ArticleCategories_ArticleCategoryId",
                        column: x => x.ArticleCategoryId,
                        principalTable: "ArticleCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSales",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    TotalQuantity = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSales_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "/images/default.jpg"),
                    IsDiscount = table.Column<bool>(type: "bit", nullable: false),
                    IsPopuler = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AnimalTypeId = table.Column<int>(type: "int", nullable: false),
                    ProductCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_AnimalTypes_AnimalTypeId",
                        column: x => x.AnimalTypeId,
                        principalTable: "AnimalTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSaleDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductSaleId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Number = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSaleDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductSaleDetails_ProductSales_ProductSaleId",
                        column: x => x.ProductSaleId,
                        principalTable: "ProductSales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSaleDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AnimalTypes",
                columns: new[] { "Id", "AnimalName" },
                values: new object[,]
                {
                    { 1, "Köpek" },
                    { 2, "Kedi" },
                    { 3, "Kuş" },
                    { 4, "Balık" }
                });

            migrationBuilder.InsertData(
                table: "ArticleCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Kedi" },
                    { 2, "Köpek" },
                    { 3, "Kuş" },
                    { 4, "Balık" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Email", "Name", "Password", "Phone" },
                values: new object[] { 1, "İstanbul, Türkiye", "ahmet@example.com", "Ahmet Yılmaz", "password123", "5555555555" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "Email", "IsAdmin", "Name", "Password", "Phone" },
                values: new object[] { 2, "Ankara, Türkiye", "ayse@example.com", true, "Ayşe Demir", "password123", "5555555556" });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mama" },
                    { 2, "Aksesuar" },
                    { 3, "Oyuncak" }
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "Id", "ArticleCategoryId", "Content", "CreatedDate", "Location", "PictureUrl", "Title", "UserId" },
                values: new object[,]
                {
                    { 1, 1, "Sokakta bulunan sevimli yavru kedi, sıcak bir yuva arıyor. Veteriner kontrolleri yapılmış, iç ve dış parazit tedavisi tamamlanmıştır. Yeni sahibine karnesi ile birlikte teslim edilecektir. Çok oyuncu ve sevecen bir karaktere sahiptir.", new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4455), "İstanbul, Kadıköy", "", "Yavru Kedi", 1 },
                    { 2, 1, "Safkan İran kedisi sahiplendirilecektir. 2 yaşında, tüm aşıları tam, sağlıklı ve bakımlıdır. Yeni sahibine alışması için biraz zaman gerektirebilir. Evde yalnız kalmayı sevmeyen, ilgi isteyen bir kedidir.", new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4457), "Ankara, Çankaya", "", "İran Kedisi", 2 },
                    { 3, 1, "Scottish Fold cinsi 3 aylık yavru kediler sahiplendirilecektir. Tüy dökme sorunu yaşamayan, oyuncu ve sosyal kedilerdir. Veteriner kontrolleri eksiksiz yapılmıştır. Tuvalet eğitimi verilmiştir.", new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4459), "İzmir, Bornova", "", "Scottish Fold Yavruları", 3 },
                    { 4, 1, "Sokakta yaralı bulunan ve tedavi ettirilen sarman kedi sahiplendirilecektir. 1 yaşında, sevecen ve oyuncudur. Evde çocuklarla iyi anlaşan, sosyal bir kedidir. Karnesi ile birlikte teslim edilecektir.", new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4461), "Antalya, Muratpaşa", "", "Sarman Kedi", 4 },
                    { 5, 2, "Golden Retriever cinsi 2 aylık yavrular sahiplendirilecektir. Anne sütüyle beslenmiş, sağlık kontrolleri yapılmıştır. Çok enerjik ve oyuncu köpeklerdir. Evde çocuklarla çok iyi anlaşırlar.", new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4504), "İstanbul, Beşiktaş", "", "Golden Retriever Yavruları", 5 },
                    { 6, 2, "Safkan Alman Kurdu, 3 yaşında, tüm aşıları yapılmış, sağlıklı ve güçlü bir köpektir. Eğitimi verilmiş, itaatkar ve koruyucu bir yapıya sahiptir. Büyük bahçeli bir eve sahip yeni sahip aranıyor.", new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4506), "Ankara, Etimesgut", "", "Alman Kurdu", 6 },
                    { 7, 2, "Beagle cinsi 4 aylık yavru köpek sahiplendirilecektir. Çok enerjik, oyuncu ve sosyal bir yapıya sahiptir. Veteriner kontrolleri yapılmış, karnesi bulunmaktadır. Çocuklarla iyi anlaşan bir köpektir.", new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4508), "İzmir, Karşıyaka", "", "Beagle Yavrusu", 7 },
                    { 8, 2, "Terrier cinsi 1 yaşındaki köpek sahiplendirilecektir. Küçük ırk, ev içinde yaşamaya uygun, sevecen ve enerjik bir köpektir. Aşıları tam, sağlık durumu çok iyi. Yeni sahibine alışması biraz zaman alabilir.", new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4510), "Antalya, Kepez", "", "Terrier Cinsi Köpek", 8 },
                    { 9, 3, "Farklı renklerde muhabbet kuşu yavruları sahiplendirilecektir. Çok konuşkan, oyuncu ve sağlıklıdırlar. Yeni sahibine kolayca alışacak, evde neşe kaynağı olacaklardır.", new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4512), "İstanbul, Üsküdar", "", "Muhabbet Kuşu Yavruları", 9 },
                    { 10, 3, "Ara papağanı, 1 yaşında, konuşkan ve sosyal bir kuştur. Eğitimli, insanlarla kolayca iletişim kurar. Sağlıklı ve bakımlıdır. Geniş bir kafes ve ilgi isteyen bir kuş olduğu unutulmamalıdır.", new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4514), "Ankara, Mamak", "", "Papağan", 10 },
                    { 11, 3, "Ötücü kanarya, 6 aylık, çok enerjik ve sağlıklıdır. Günde birkaç saat şarkı söyleyen, evin neşesi olacak bir kuştur. Yeni sahibine hızlıca alışacak, kolay bakımı olan bir evcil hayvandır.", new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4515), "İzmir, Gaziemir", "", "Kanarya", 11 },
                    { 12, 3, "Saka kuşu, 1 yaşında, çok ötücü ve enerjik bir kuştur. Doğal ortamında bulup sahiplendirdik. Sağlıklı ve neşelidir. Geniş bir kafeste bakılması önerilir.", new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4517), "Antalya, Konyaaltı", "", "Saka Kuşu", 12 },
                    { 13, 4, "Çeşitli renklerde Japon balıkları, akvaryum içinde harika bir görüntü sağlar. Sağlıklı ve bakımlıdır. Su değişimi ve yemlemesi düzenli yapılmıştır. Yeni sahibine akvaryumla birlikte teslim edilecektir.", new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4519), "İstanbul, Şişli", "", "Japon Balığı", 13 },
                    { 14, 4, "Renkli ve gösterişli Betta balığı sahiplendirilecektir. Sağlıklı, bakımlı ve enerjik bir balıktır. Küçük bir akvaryumda veya fanusta rahatça yaşayabilir. Tek bakılması önerilir.", new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4520), "Ankara, Yenimahalle", "", "Betta Balığı", 14 },
                    { 15, 4, "Lepistes balıkları, çeşitli renk ve desenlerde, çok sağlıklı ve bakımlıdır. Akvaryum ortamına kolayca uyum sağlarlar. Bakımları kolay ve keyifli olan balıklardır.", new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4522), "İzmir, Buca", "", "Lepistes Balığı", 15 },
                    { 16, 4, "Neon Tetra balıkları, parlak renkleri ve sürü halinde yüzmeleriyle ünlüdür. Sağlıklı ve enerjik balıklardır. Akvaryum ortamında çok güzel bir görüntü sağlarlar.", new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4524), "Antalya, Alanya", "", "Neon Tetra Balıkları", 16 }
                });

            migrationBuilder.InsertData(
                table: "ProductSales",
                columns: new[] { "Id", "CustomerId", "Date", "TotalPrice", "TotalQuantity" },
                values: new object[] { 1, 1, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4725), 120m, 2 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AnimalTypeId", "CreatedDate", "Description", "ImageUrl", "IsDiscount", "IsPopuler", "Name", "Price", "ProductCategoryId", "Stock" },
                values: new object[] { 1, 1, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4622), "Yüksek kaliteli köpek maması", "/images/kopek_mamasi.jpg", false, true, "Köpek Maması", 50m, 1, 100 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AnimalTypeId", "CreatedDate", "Description", "ImageUrl", "IsDiscount", "Name", "Price", "ProductCategoryId", "Stock" },
                values: new object[,]
                {
                    { 2, 2, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4630), "Renkli ve eğlenceli kedi oyuncağı", "/images/kedi_oyuncagi.jpg", true, "Kedi Oyuncağı", 20m, 3, 200 },
                    { 3, 3, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4632), "Geniş ve konforlu kuş kafesi", "/images/kus_kafesi.jpg", false, "Kuş Kafesi", 75m, 3, 50 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AnimalTypeId", "CreatedDate", "Description", "ImageUrl", "IsDiscount", "IsPopuler", "Name", "Price", "ProductCategoryId", "Stock" },
                values: new object[] { 4, 4, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4634), "Geniş ve şık balık akvaryumu", "/images/balik_akvaryumu.jpg", false, true, "Balık Akvaryumu", 150m, 3, 20 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AnimalTypeId", "CreatedDate", "Description", "ImageUrl", "IsDiscount", "Name", "Price", "ProductCategoryId", "Stock" },
                values: new object[] { 5, 2, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4635), "Sağlıklı ve besleyici kedi maması", "/images/kedi_mamasi.jpg", true, "Kedi Maması", 30m, 1, 150 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AnimalTypeId", "CreatedDate", "Description", "ImageUrl", "IsDiscount", "IsPopuler", "Name", "Price", "ProductCategoryId", "Stock" },
                values: new object[,]
                {
                    { 6, 1, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4637), "Dayanıklı ve şık köpek tasması", "/images/kopek_tasmassi.jpg", true, true, "Köpek Tasması", 25m, 2, 100 },
                    { 7, 3, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4639), "Vitaminli ve besleyici kuş yemi", "/images/kus_yemi.jpg", false, true, "Kuş Yemi", 15m, 1, 300 }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AnimalTypeId", "CreatedDate", "Description", "ImageUrl", "IsDiscount", "Name", "Price", "ProductCategoryId", "Stock" },
                values: new object[] { 8, 4, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4640), "Kaliteli ve besleyici balık yemi", "/images/balik_yemi.jpg", true, "Balık Yemi", 10m, 1, 400 });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "AnimalTypeId", "CreatedDate", "Description", "ImageUrl", "IsDiscount", "IsPopuler", "Name", "Price", "ProductCategoryId", "Stock" },
                values: new object[,]
                {
                    { 9, 2, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4642), "Kedi için oyuncak ve aksesuar seti", "/images/kedi_aksesuar_seti.jpg", false, true, "Kedi Aksesuar Seti", 40m, 2, 80 },
                    { 10, 1, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4643), "Dayanıklı ve eğlenceli köpek oyuncağı", "/images/kopek_oyuncagi.jpg", true, true, "Köpek Oyuncağı", 30m, 3, 120 },
                    { 11, 1, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4645), "Dayanıklı ve eğlenceli köpek oyuncağı", "/images/kopek_oyuncagi.jpg", true, true, "Köpek Oyuncağı", 30m, 3, 120 },
                    { 12, 1, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4647), "Köpeğiniz için rahat ve dayanıklı tasma seti", "/images/kopek_tasma.jpg", false, true, "Köpek Tasma ve Tasması", 25m, 2, 100 },
                    { 13, 2, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4648), "Kediniz için rahatlatıcı ve dayanıklı tırmalama ağacı", "/images/kedi_tirmalama_agaci.jpg", false, true, "Kedi Tırmalama Ağacı", 50m, 3, 80 },
                    { 14, 3, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4650), "Kuşunuz için geniş ve konforlu kafes", "/images/kus_kafesi.jpg", true, true, "Geniş Kuş Kafesi", 40m, 3, 60 },
                    { 15, 4, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4652), "Balıklarınız için modern ve şık akvaryum seti", "/images/akvaryum_seti.jpg", false, true, "Akvaryum Seti", 70m, 3, 30 },
                    { 16, 1, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4653), "Sağlıklı ve dengeli beslenme için köpek kuru maması", "/images/kopek_kuru_mamasi.jpg", false, true, "Köpek Kuru Maması", 55m, 1, 90 },
                    { 17, 1, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4655), "Konforlu ve yumuşak köpek yatağı", "/images/kopek_yatagi.jpg", true, true, "Köpek Yatak", 40m, 2, 70 },
                    { 18, 2, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4657), "Lezzetli ve sağlıklı kedi konservesi", "/images/kedi_konservesi.jpg", true, true, "Kedi Konservesi", 10m, 1, 120 },
                    { 19, 2, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4658), "Eğlenceli ve oyun dolu kedi oyun tüneli", "/images/kedi_oyun_tuneli.jpg", false, true, "Kedi Oyun Tüneli", 20m, 3, 100 },
                    { 20, 3, new DateTime(2024, 7, 21, 10, 33, 54, 100, DateTimeKind.Local).AddTicks(4660), "Muhabbet kuşlarınız için özel karışım yem", "/images/muhabbet_kusu_yemi.jpg", false, true, "Muhabbet Kuşu Yemi", 8m, 1, 150 }
                });

            migrationBuilder.InsertData(
                table: "ProductSaleDetails",
                columns: new[] { "Id", "Number", "ProductId", "ProductSaleId", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 2, 1, 1, 50m },
                    { 2, 1, 2, 1, 20m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Articles_ArticleCategoryId",
                table: "Articles",
                column: "ArticleCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_AnimalTypeId",
                table: "Products",
                column: "AnimalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSaleDetails_ProductId",
                table: "ProductSaleDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSaleDetails_ProductSaleId",
                table: "ProductSaleDetails",
                column: "ProductSaleId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSales_CustomerId",
                table: "ProductSales",
                column: "CustomerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "ProductSaleDetails");

            migrationBuilder.DropTable(
                name: "ArticleCategories");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "ProductSales");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "AnimalTypes");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
