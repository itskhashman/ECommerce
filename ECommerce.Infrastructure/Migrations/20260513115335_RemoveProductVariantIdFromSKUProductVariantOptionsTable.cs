using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class RemoveProductVariantIdFromSKUProductVariantOptionsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SKUProductVariantOptions_ProductVariants_ProductVariantId",
                table: "SKUProductVariantOptions");

            migrationBuilder.DropIndex(
                name: "IX_SKUProductVariantOptions_ProductVariantId",
                table: "SKUProductVariantOptions");

            migrationBuilder.DropColumn(
                name: "ProductVariantId",
                table: "SKUProductVariantOptions");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductVariantId",
                table: "SKUProductVariantOptions",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SKUProductVariantOptions_ProductVariantId",
                table: "SKUProductVariantOptions",
                column: "ProductVariantId");

            migrationBuilder.AddForeignKey(
                name: "FK_SKUProductVariantOptions_ProductVariants_ProductVariantId",
                table: "SKUProductVariantOptions",
                column: "ProductVariantId",
                principalTable: "ProductVariants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
