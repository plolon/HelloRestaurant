using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hello.Services.ProductAPI.Migrations
{
    public partial class UpdatedSeededUrls : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://cdn.apartmenttherapy.info/image/upload/f_jpg,q_auto:eco,c_fill,g_auto,w_1500,ar_4:3/k%2Farchive%2F0eb929bc2c007ebf6009316a327b1e37587045a4");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://i2.wp.com/www.downshiftology.com/wp-content/uploads/2021/11/Stuffed-Mushrooms-main-1-1.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://www.thespruceeats.com/thmb/IHKuXcx3uUI1IWkM_cnnQdFH-zQ=/3485x2323/filters:fill(auto,1)/how-to-make-homemade-french-fries-2215971-hero-01-02f62a016f3e4aa4b41d0c27539885c3.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://ocdn.eu/pulscms-transforms/1/rlWk9kpTURBXy9iZTNhYjlkNjNmNDQzZmE2MzI1YWQwOGU0M2U3Nzk3ZC5qcGeTlQMAzMLNFMLNC62TCaY4YTBhZWMGkwXNBLDNAnaBoTAB/apple-pie.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ImageUrl",
                value: "https://www.bakinglikeachef.com/wp-content/uploads/Black-Forest-Cake-7.jpg");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ImageUrl",
                value: "https://hips.hearstapps.com/vidthumb/images/delish-crockpot-chicken-dumplings-1519941256.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5,
                column: "ImageUrl",
                value: "");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6,
                column: "ImageUrl",
                value: "");
        }
    }
}
