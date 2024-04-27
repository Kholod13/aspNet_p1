using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UseThi.Migrations
{
    public partial class newProducts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CategoryId1", "Contact", "Description", "Discount", "ImageUrl", "Location", "Name", "Price", "Status" },
                values: new object[] { 2, 1, null, "sdjfh@gmail.com", null, 10, "https://applecity.com.ua/image/cache/catalog/0iphone/ipohnex/iphone-x-black-1000x1000.png", "Rivne", "iPhone X", 650m, true });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CategoryId1", "Contact", "Description", "Discount", "ImageUrl", "Location", "Name", "Price", "Status" },
                values: new object[] { 5, 1, null, "lalalalad@gmail.com", null, 10, "https://newtime.ua/image/import/catalog/mac/macbook_pro/MacBook-Pro-16-2019/MacBook-Pro-16-Space-Gray-2019/MacBook-Pro-16-Space-Gray-00.webp", "Lviv", "MacBook Pro 2019", 700m, true });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CategoryId1", "Contact", "Description", "Discount", "ImageUrl", "Location", "Name", "Price", "Quantity", "Status" },
                values: new object[] { 7, 1, null, "sdjfh@gmail.com", null, 10, "https://applecity.com.ua/image/cache/catalog/0iphone/ipohnex/iphone-x-black-1000x1000.png", "Rivne", "iPhone X", 650m, 3, true });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CategoryId1", "Contact", "Description", "Discount", "ImageUrl", "Location", "Name", "Price", "Quantity", "Status" },
                values: new object[] { 8, 1, null, "sdjfh@gmail.com", null, 10, "https://applecity.com.ua/image/cache/catalog/0iphone/ipohnex/iphone-x-black-1000x1000.png", "Rivne", "iPhone X", 650m, 5, true });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryId", "CategoryId1", "Contact", "Description", "Discount", "ImageUrl", "Location", "Name", "Price", "Quantity", "Status" },
                values: new object[] { 9, 1, null, "sdjfh@gmail.com", null, 10, "https://applecity.com.ua/image/cache/catalog/0iphone/ipohnex/iphone-x-black-1000x1000.png", "Rivne", "iPhone X", 650m, 2, true });
        }
    }
}
