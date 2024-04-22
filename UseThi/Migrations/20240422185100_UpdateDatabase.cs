using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UseThi.Migrations
{
    public partial class UpdateDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "InStock",
                table: "Products",
                newName: "Status");

            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Contact", "Location", "Quantity", "Status" },
                values: new object[] { "sdjfh@gmail.com", "Rivne", 3, true });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Contact", "Location" },
                values: new object[] { "+380439850090", "Prague" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Contact", "Discount", "Location", "Status" },
                values: new object[] { "+420849953978", 0, "Zatec", false });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Contact", "Location" },
                values: new object[] { "lalalalad@gmail.com", "Lviv" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Location",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "Products",
                newName: "InStock");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "InStock", "Quantity" },
                values: new object[] { false, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Discount", "InStock" },
                values: new object[] { 5, true });
        }
    }
}
