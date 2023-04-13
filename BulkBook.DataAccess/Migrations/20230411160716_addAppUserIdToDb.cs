using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BulkyBook.Migrations
{
    /// <inheritdoc />
    public partial class addAppUserIdToDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShopingCarts_AspNetUsers_ApplicationUserId",
                table: "ShopingCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_ShopingCarts_Products_ProductId",
                table: "ShopingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShopingCarts",
                table: "ShopingCarts");

            migrationBuilder.RenameTable(
                name: "ShopingCarts",
                newName: "ShoppingCarts");

            migrationBuilder.RenameIndex(
                name: "IX_ShopingCarts_ProductId",
                table: "ShoppingCarts",
                newName: "IX_ShoppingCarts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ShopingCarts_ApplicationUserId",
                table: "ShoppingCarts",
                newName: "IX_ShoppingCarts_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_ApplicationUserId",
                table: "ShoppingCarts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShoppingCarts_Products_ProductId",
                table: "ShoppingCarts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_AspNetUsers_ApplicationUserId",
                table: "ShoppingCarts");

            migrationBuilder.DropForeignKey(
                name: "FK_ShoppingCarts_Products_ProductId",
                table: "ShoppingCarts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShoppingCarts",
                table: "ShoppingCarts");

            migrationBuilder.RenameTable(
                name: "ShoppingCarts",
                newName: "ShopingCarts");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCarts_ProductId",
                table: "ShopingCarts",
                newName: "IX_ShopingCarts_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ShoppingCarts_ApplicationUserId",
                table: "ShopingCarts",
                newName: "IX_ShopingCarts_ApplicationUserId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShopingCarts",
                table: "ShopingCarts",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ShopingCarts_AspNetUsers_ApplicationUserId",
                table: "ShopingCarts",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ShopingCarts_Products_ProductId",
                table: "ShopingCarts",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
