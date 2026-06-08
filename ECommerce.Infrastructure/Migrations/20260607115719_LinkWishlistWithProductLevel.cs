using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class LinkWishlistWithProductLevel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItems_Skus_SkuId",
                table: "WishlistItems");

            migrationBuilder.RenameColumn(
                name: "SkuId",
                table: "WishlistItems",
                newName: "ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_WishlistItems_SkuId",
                table: "WishlistItems",
                newName: "IX_WishlistItems_ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItems_Products_ProductId",
                table: "WishlistItems",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItems_Products_ProductId",
                table: "WishlistItems");

            migrationBuilder.RenameColumn(
                name: "ProductId",
                table: "WishlistItems",
                newName: "SkuId");

            migrationBuilder.RenameIndex(
                name: "IX_WishlistItems_ProductId",
                table: "WishlistItems",
                newName: "IX_WishlistItems_SkuId");

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItems_Skus_SkuId",
                table: "WishlistItems",
                column: "SkuId",
                principalTable: "Skus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
