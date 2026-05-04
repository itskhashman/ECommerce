using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FixTheMultipleOnDeletePath : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_SKUProductVariantOptions_ProductVariantOptions_ProductVariantOptionsId",
                table: "SKUProductVariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_SKUProductVariantOptions_ProductVariants_ProductVariantId",
                table: "SKUProductVariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Skus_Products_ProductId",
                table: "Skus");

            migrationBuilder.AddColumn<int>(
                name: "ProductVariantId1",
                table: "SKUProductVariantOptions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SKUProductVariantOptions_ProductVariantId1",
                table: "SKUProductVariantOptions",
                column: "ProductVariantId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SKUProductVariantOptions_ProductVariantOptions_ProductVariantOptionsId",
                table: "SKUProductVariantOptions",
                column: "ProductVariantOptionsId",
                principalTable: "ProductVariantOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SKUProductVariantOptions_ProductVariants_ProductVariantId",
                table: "SKUProductVariantOptions",
                column: "ProductVariantId",
                principalTable: "ProductVariants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SKUProductVariantOptions_ProductVariants_ProductVariantId1",
                table: "SKUProductVariantOptions",
                column: "ProductVariantId1",
                principalTable: "ProductVariants",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Skus_Products_ProductId",
                table: "Skus",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_SKUProductVariantOptions_ProductVariantOptions_ProductVariantOptionsId",
                table: "SKUProductVariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_SKUProductVariantOptions_ProductVariants_ProductVariantId",
                table: "SKUProductVariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_SKUProductVariantOptions_ProductVariants_ProductVariantId1",
                table: "SKUProductVariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Skus_Products_ProductId",
                table: "Skus");

            migrationBuilder.DropIndex(
                name: "IX_SKUProductVariantOptions_ProductVariantId1",
                table: "SKUProductVariantOptions");

            migrationBuilder.DropColumn(
                name: "ProductVariantId1",
                table: "SKUProductVariantOptions");

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SKUProductVariantOptions_ProductVariantOptions_ProductVariantOptionsId",
                table: "SKUProductVariantOptions",
                column: "ProductVariantOptionsId",
                principalTable: "ProductVariantOptions",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SKUProductVariantOptions_ProductVariants_ProductVariantId",
                table: "SKUProductVariantOptions",
                column: "ProductVariantId",
                principalTable: "ProductVariants",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Skus_Products_ProductId",
                table: "Skus",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
