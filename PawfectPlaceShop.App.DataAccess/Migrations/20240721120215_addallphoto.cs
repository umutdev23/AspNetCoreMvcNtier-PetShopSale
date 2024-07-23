using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PawfectPlaceShop.App.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class addallphoto : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8721));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8727));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8730));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "ProductSales",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8873), "https://petmekan.com/wp-content/uploads/2023/03/enjoy-kuzu-etli-yetiskin-kopek-mamasi-15-kg-13815.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8881), "https://m.media-amazon.com/images/I/71XTc9mbkfL._AC_UF1000,1000_QL80_.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8883), "https://ferplastturkiye.com/wp-content/uploads/2023/03/8010690087405-1.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8885), "https://image.posta.com.tr/i/posta/75/0x0/6196486145d2a07ffcb0ab64.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8887), "https://ideacdn.net/idea/el/24/myassets/products/200/1027124.jpg?revision=1697143329" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8888), "https://hep21.com/cdn/shop/products/S28a2287c17bf480691a43bcc5e68c90cr.jpg?v=1709507505&width=1445" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8890), "https://www.adresemama.com/quik-muhabbet-kusu-yemi-1-kg-98234-76-O.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8892), "https://productimages.hepsiburada.net/s/27/375-375/10191018328114.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8893), "https://productimages.hepsiburada.net/s/259/375-375/110000242965113.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8895), "https://cdn.myikas.com/images/095577b2-7631-4970-aac8-f67dc0fdb305/9f1981cb-27c2-4f43-8857-cfd946a86ef2/image_1080.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8897), "https://ideacdn.net/idea/it/26/myassets/products/360/pf-4023-playfull-kopek-oyuncagi-28x95-cm-kopek-oyuncaklari-playfull-1622-70-o.jpg?revision=1712226517" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ImageUrl", "Name" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8898), "https://productimages.hepsiburada.net/s/439/375-375/110000472848675.jpg", "Köpek Tasması" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8900), "https://www.turuncu-sepet.com/wp-content/uploads/2022/04/kedi-tirmalama-tahtasi-55-cm-kedi-figurlu-2270.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8902), "https://www.ferhatyazan.com.tr/images_1/Easyfashion-haddeleme-geni%C5%9F-ku%C5%9F-kafesi-b%C3%B6l%C3%BCnm%C3%BC%C5%9F-214386_upload.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8903), "https://cdn.akakce.com/z/ans/ans-full-hazir-seti-30-x-2-5-x-14-cm-10-parca.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8905), "https://cdn03.ciceksepeti.com/cicek/kcm9336886-1/L/proart-pupy-yavru-kopek-kuru-mama-3-kg-kcm9336886-1-a434d38ce7e547c28f0f4f3618a8f1f5.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8907), "https://www.petimce.com/i/l/002/0022207_peggy-luna-kopek-yatagi-gri-large.jpeg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8908), "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcR9OY7lELsmTfa86oCGGB3LNIi4aDn5YLJfFw&s" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8910), "https://static.ticimax.cloud/2601/uploads/urunresimleri/buyuk/trixie-2-bolmeli-pelus-ve-jut-kumasli--4c956f.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 15, 2, 15, 265, DateTimeKind.Local).AddTicks(8911), "https://www.adresemama.com/gold-wings-classic-yavru-muhabbet-kusu-yemi-400-gr-98926-76-B.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2560));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2564));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2567));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2569));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2571));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2573));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2575));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2576));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2580));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "Articles",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2583));

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
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2685), "/images/kopek_mamasi.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2694), "/images/kedi_oyuncagi.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2696), "/images/kus_kafesi.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2697), "/images/balik_akvaryumu.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2699), "/images/kedi_mamasi.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2701), "/images/kopek_tasmassi.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2702), "/images/kus_yemi.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2704), "/images/balik_yemi.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2706), "/images/kedi_aksesuar_seti.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2707), "/images/kopek_oyuncagi.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2709), "/images/kopek_oyuncagi.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "ImageUrl", "Name" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2711), "/images/kopek_tasma.jpg", "Köpek Tasma ve Tasması" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2712), "/images/kedi_tirmalama_agaci.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2714), "/images/kus_kafesi.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2716), "/images/akvaryum_seti.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2717), "/images/kopek_kuru_mamasi.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2719), "/images/kopek_yatagi.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2721), "/images/kedi_konservesi.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2722), "/images/kedi_oyun_tuneli.jpg" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedDate", "ImageUrl" },
                values: new object[] { new DateTime(2024, 7, 21, 14, 29, 38, 279, DateTimeKind.Local).AddTicks(2724), "/images/muhabbet_kusu_yemi.jpg" });
        }
    }
}
