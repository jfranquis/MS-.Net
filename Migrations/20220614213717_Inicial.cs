using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace productsApi.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    name = table.Column<string>(type: "varchar(80) CHARACTER SET utf8mb4", maxLength: 80, nullable: true),
                    price = table.Column<decimal>(type: "decimal(10,2)", precision: 10, scale: 2, nullable: false),
                    Inventory = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "Inventory", "name", "price" },
                values: new object[] { 1, 5, "Caneta", 5.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "Inventory", "name", "price" },
                values: new object[] { 2, 2, "Impressora", 1445.99m });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "id", "Inventory", "name", "price" },
                values: new object[] { 3, 2, "Papel Sulft", 17.99m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
