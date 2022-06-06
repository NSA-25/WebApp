using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations
{
    public partial class update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StoreProduct",
                columns: table => new
                {
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StoreProduct", x => new { x.StoreId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_StoreProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StoreProduct_Store_StoreId",
                        column: x => x.StoreId,
                        principalTable: "Store",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Store_LocationId",
                table: "Store",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_Store_ManagerId",
                table: "Store",
                column: "ManagerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StoreProduct_ProductId",
                table: "StoreProduct",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Store_Location_LocationId",
                table: "Store",
                column: "LocationId",
                principalTable: "Location",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Store_Manager_ManagerId",
                table: "Store",
                column: "ManagerId",
                principalTable: "Manager",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Store_Location_LocationId",
                table: "Store");

            migrationBuilder.DropForeignKey(
                name: "FK_Store_Manager_ManagerId",
                table: "Store");

            migrationBuilder.DropTable(
                name: "StoreProduct");

            migrationBuilder.DropIndex(
                name: "IX_Store_LocationId",
                table: "Store");

            migrationBuilder.DropIndex(
                name: "IX_Store_ManagerId",
                table: "Store");
        }
    }
}
