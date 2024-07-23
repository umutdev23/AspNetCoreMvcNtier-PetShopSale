using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PawfectPlaceShop.App.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addphotolar : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2556));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2558), "https://static.ticimax.cloud/cdn-cgi/image/width=540,quality=99/52768/uploads/blog/persian-iran-kedilerinin-ozellikleri-0663.jpg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2560), "https://www.patibul.com/uploads/ajax/2023/03/03/IMG-4054-6401CD1B83876.jpg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2562), "https://static.ticimax.cloud/cdn-cgi/image/width=540,quality=99/9062/uploads/editoruploads/06a90ea6-87bb-45b8-931f-8ae475b89248-758.jpeg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2564), "https://www.patibul.com/uploads/ajax/2023/02/28/WhatsApp-Image-2023-02-20-at-113214-(1)-63FDABE6E0598.jpeg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2566), "https://www.guardiaturca.com/wp-content/uploads/german-shepherd-alman-kurdu-ozellikleri.jpg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2567), "https://www.evcilhayvan.market/wp-content/uploads/2017/06/yavru-beagle-kopek.jpg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2569), "https://static.ticimax.cloud/cdn-cgi/image/width=540,quality=99/9062//uploads/editoruploads/0yorkshire-terrier.jpg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Content", "CreatedDate", "PictureUrl", "Title" },
                values: new object[] { "Farklı renklerde muhabbet kuşları sahiplendirilecektir. Çok konuşkan, oyuncu ve sağlıklıdırlar. Yeni sahibine kolayca alışacak, evde neşe kaynağı olacaklardır.", new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2571), "https://www.petihtiyac.com/Data/Blog/1/113.jpg", "Muhabbet Kuşu " });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2573), "https://www.atasehirveteriner.com/upload/images/jako-papagan.jpg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2575), "https://www.petihtiyac.com/Data/Blog/664.jpg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2576), "https://www.petipet.net/uploads/2020/07/images-1-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2578), "https://static.ticimax.cloud/cdn-cgi/image/width=540,quality=99/9062/uploads/editoruploads/japon-baligi.jpg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2580), "https://storage.evrimagaci.org/old/content_media/7dc03454e9646168baf5a463fcdd3e6f.jpg" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2582), "https://storage.evrimagaci.org/old/content_media/3723213440e3ea2a80717dc1969081a2.png" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2583), "https://www.petihtiyac.com/Data/Blog/1/155.jpg" });

            migrationBuilder.UpdateData(
                table: "ProductSales",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2706));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2709));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2724));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3201));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3203), "" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3205), "" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3207), "" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3209), "" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3210), "" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3212), "" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3214), "" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Content", "CreatedDate", "PictureUrl", "Title" },
                values: new object[] { "Farklı renklerde muhabbet kuşu yavruları sahiplendirilecektir. Çok konuşkan, oyuncu ve sağlıklıdırlar. Yeni sahibine kolayca alışacak, evde neşe kaynağı olacaklardır.", new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3216), "", "Muhabbet Kuşu Yavruları" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3217), "" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3219), "" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3221), "" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3222), "" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3224), "" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3225), "" });

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "PictureUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3227), "" });

            migrationBuilder.UpdateData(
                table: "ProductSales",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3433));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3350));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3354));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3361));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3364));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3366));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 13, 23, 211, DateTimeKind.Local).AddTicks(3367));
        }
    }
}
