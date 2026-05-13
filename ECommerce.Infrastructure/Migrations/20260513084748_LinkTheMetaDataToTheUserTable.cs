using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class LinkTheMetaDataToTheUserTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_UserId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Cart_User_UserId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_User_UserId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Role_RoleId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_Wishlist_User_UserId",
                table: "Wishlist");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItem_CreatedBy",
                table: "WishlistItem",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItem_DeletedBy",
                table: "WishlistItem",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_WishlistItem_ModifiedBy",
                table: "WishlistItem",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlist_CreatedBy",
                table: "Wishlist",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlist_DeletedBy",
                table: "Wishlist",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Wishlist_ModifiedBy",
                table: "Wishlist",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_User_CreatedBy",
                table: "User",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_User_DeletedBy",
                table: "User",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_User_ModifiedBy",
                table: "User",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SKUProductVariantOption_CreatedBy",
                table: "SKUProductVariantOption",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SKUProductVariantOption_DeletedBy",
                table: "SKUProductVariantOption",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_SKUProductVariantOption_ModifiedBy",
                table: "SKUProductVariantOption",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Sku_CreatedBy",
                table: "Sku",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Sku_DeletedBy",
                table: "Sku",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Sku_ModifiedBy",
                table: "Sku",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingRate_CreatedBy",
                table: "ShippingRate",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingRate_DeletedBy",
                table: "ShippingRate",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ShippingRate_ModifiedBy",
                table: "ShippingRate",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Role_CreatedBy",
                table: "Role",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Role_DeletedBy",
                table: "Role",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Role_ModifiedBy",
                table: "Role",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Review_CreatedBy",
                table: "Review",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Review_DeletedBy",
                table: "Review",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Review_ModifiedBy",
                table: "Review",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariantOption_CreatedBy",
                table: "ProductVariantOption",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariantOption_DeletedBy",
                table: "ProductVariantOption",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariantOption_ModifiedBy",
                table: "ProductVariantOption",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariant_CreatedBy",
                table: "ProductVariant",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariant_DeletedBy",
                table: "ProductVariant",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductVariant_ModifiedBy",
                table: "ProductVariant",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_CreatedBy",
                table: "ProductImage",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_DeletedBy",
                table: "ProductImage",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_ProductImage_ModifiedBy",
                table: "ProductImage",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Product_CreatedBy",
                table: "Product",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Product_DeletedBy",
                table: "Product",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Product_ModifiedBy",
                table: "Product",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentStatus_CreatedBy",
                table: "PaymentStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentStatus_DeletedBy",
                table: "PaymentStatus",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentStatus_ModifiedBy",
                table: "PaymentStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_CreatedBy",
                table: "PaymentMethod",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_DeletedBy",
                table: "PaymentMethod",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentMethod_ModifiedBy",
                table: "PaymentMethod",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_CreatedBy",
                table: "Payment",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_DeletedBy",
                table: "Payment",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_ModifiedBy",
                table: "Payment",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatus_CreatedBy",
                table: "OrderStatus",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatus_DeletedBy",
                table: "OrderStatus",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderStatus_ModifiedBy",
                table: "OrderStatus",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_CreatedBy",
                table: "OrderItem",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_DeletedBy",
                table: "OrderItem",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItem_ModifiedBy",
                table: "OrderItem",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CreatedBy",
                table: "Order",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Order_DeletedBy",
                table: "Order",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Order_ModifiedBy",
                table: "Order",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountType_CreatedBy",
                table: "DiscountType",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountType_DeletedBy",
                table: "DiscountType",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_DiscountType_ModifiedBy",
                table: "DiscountType",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Country_CreatedBy",
                table: "Country",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Country_DeletedBy",
                table: "Country",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Country_ModifiedBy",
                table: "Country",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_City_CreatedBy",
                table: "City",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_City_DeletedBy",
                table: "City",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_City_ModifiedBy",
                table: "City",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Category_CreatedBy",
                table: "Category",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Category_DeletedBy",
                table: "Category",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ModifiedBy",
                table: "Category",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_CreatedBy",
                table: "CartItem",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_DeletedBy",
                table: "CartItem",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_CartItem_ModifiedBy",
                table: "CartItem",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_CreatedBy",
                table: "Cart",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_DeletedBy",
                table: "Cart",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Cart_ModifiedBy",
                table: "Cart",
                column: "ModifiedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Address_CreatedBy",
                table: "Address",
                column: "CreatedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Address_DeletedBy",
                table: "Address",
                column: "DeletedBy");

            migrationBuilder.CreateIndex(
                name: "IX_Address_ModifiedBy",
                table: "Address",
                column: "ModifiedBy");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_User_CreatedBy",
                table: "Address",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_User_DeletedBy",
                table: "Address",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_User_ModifiedBy",
                table: "Address",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_User_UserId",
                table: "Address",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_User_CreatedBy",
                table: "Cart",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_User_DeletedBy",
                table: "Cart",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_User_ModifiedBy",
                table: "Cart",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_User_UserId",
                table: "Cart",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_User_CreatedBy",
                table: "CartItem",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_User_DeletedBy",
                table: "CartItem",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_User_ModifiedBy",
                table: "CartItem",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_User_CreatedBy",
                table: "Category",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_User_DeletedBy",
                table: "Category",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_User_ModifiedBy",
                table: "Category",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_City_User_CreatedBy",
                table: "City",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_City_User_DeletedBy",
                table: "City",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_City_User_ModifiedBy",
                table: "City",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Country_User_CreatedBy",
                table: "Country",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Country_User_DeletedBy",
                table: "Country",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Country_User_ModifiedBy",
                table: "Country",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DiscountType_User_CreatedBy",
                table: "DiscountType",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DiscountType_User_DeletedBy",
                table: "DiscountType",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DiscountType_User_ModifiedBy",
                table: "DiscountType",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_User_CreatedBy",
                table: "Order",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_User_DeletedBy",
                table: "Order",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_User_ModifiedBy",
                table: "Order",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_User_UserId",
                table: "Order",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_User_CreatedBy",
                table: "OrderItem",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_User_DeletedBy",
                table: "OrderItem",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_User_ModifiedBy",
                table: "OrderItem",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderStatus_User_CreatedBy",
                table: "OrderStatus",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderStatus_User_DeletedBy",
                table: "OrderStatus",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderStatus_User_ModifiedBy",
                table: "OrderStatus",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_User_CreatedBy",
                table: "Payment",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_User_DeletedBy",
                table: "Payment",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_User_ModifiedBy",
                table: "Payment",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_User_CreatedBy",
                table: "PaymentMethod",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_User_DeletedBy",
                table: "PaymentMethod",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethod_User_ModifiedBy",
                table: "PaymentMethod",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentStatus_User_CreatedBy",
                table: "PaymentStatus",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentStatus_User_DeletedBy",
                table: "PaymentStatus",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentStatus_User_ModifiedBy",
                table: "PaymentStatus",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_User_CreatedBy",
                table: "Product",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_User_DeletedBy",
                table: "Product",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_User_ModifiedBy",
                table: "Product",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImage_User_CreatedBy",
                table: "ProductImage",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImage_User_DeletedBy",
                table: "ProductImage",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImage_User_ModifiedBy",
                table: "ProductImage",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariant_User_CreatedBy",
                table: "ProductVariant",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariant_User_DeletedBy",
                table: "ProductVariant",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariant_User_ModifiedBy",
                table: "ProductVariant",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariantOption_User_CreatedBy",
                table: "ProductVariantOption",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariantOption_User_DeletedBy",
                table: "ProductVariantOption",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariantOption_User_ModifiedBy",
                table: "ProductVariantOption",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_User_CreatedBy",
                table: "Review",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_User_DeletedBy",
                table: "Review",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_User_ModifiedBy",
                table: "Review",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Role_User_CreatedBy",
                table: "Role",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Role_User_DeletedBy",
                table: "Role",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Role_User_ModifiedBy",
                table: "Role",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingRate_User_CreatedBy",
                table: "ShippingRate",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingRate_User_DeletedBy",
                table: "ShippingRate",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingRate_User_ModifiedBy",
                table: "ShippingRate",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sku_User_CreatedBy",
                table: "Sku",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sku_User_DeletedBy",
                table: "Sku",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Sku_User_ModifiedBy",
                table: "Sku",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SKUProductVariantOption_User_CreatedBy",
                table: "SKUProductVariantOption",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SKUProductVariantOption_User_DeletedBy",
                table: "SKUProductVariantOption",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SKUProductVariantOption_User_ModifiedBy",
                table: "SKUProductVariantOption",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_RoleId",
                table: "User",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_CreatedBy",
                table: "User",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_DeletedBy",
                table: "User",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_User_ModifiedBy",
                table: "User",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlist_User_CreatedBy",
                table: "Wishlist",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlist_User_DeletedBy",
                table: "Wishlist",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlist_User_ModifiedBy",
                table: "Wishlist",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlist_User_UserId",
                table: "Wishlist",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItem_User_CreatedBy",
                table: "WishlistItem",
                column: "CreatedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItem_User_DeletedBy",
                table: "WishlistItem",
                column: "DeletedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItem_User_ModifiedBy",
                table: "WishlistItem",
                column: "ModifiedBy",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_CreatedBy",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_DeletedBy",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_ModifiedBy",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_UserId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Cart_User_CreatedBy",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_Cart_User_DeletedBy",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_Cart_User_ModifiedBy",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_Cart_User_UserId",
                table: "Cart");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_User_CreatedBy",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_User_DeletedBy",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_User_ModifiedBy",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_User_CreatedBy",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_User_DeletedBy",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_Category_User_ModifiedBy",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_City_User_CreatedBy",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_City_User_DeletedBy",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_City_User_ModifiedBy",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_User_CreatedBy",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_User_DeletedBy",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_Country_User_ModifiedBy",
                table: "Country");

            migrationBuilder.DropForeignKey(
                name: "FK_DiscountType_User_CreatedBy",
                table: "DiscountType");

            migrationBuilder.DropForeignKey(
                name: "FK_DiscountType_User_DeletedBy",
                table: "DiscountType");

            migrationBuilder.DropForeignKey(
                name: "FK_DiscountType_User_ModifiedBy",
                table: "DiscountType");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_User_CreatedBy",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_User_DeletedBy",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_User_ModifiedBy",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_User_UserId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_User_CreatedBy",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_User_DeletedBy",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_User_ModifiedBy",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderStatus_User_CreatedBy",
                table: "OrderStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderStatus_User_DeletedBy",
                table: "OrderStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderStatus_User_ModifiedBy",
                table: "OrderStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_User_CreatedBy",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_User_DeletedBy",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_User_ModifiedBy",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_User_CreatedBy",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_User_DeletedBy",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethod_User_ModifiedBy",
                table: "PaymentMethod");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentStatus_User_CreatedBy",
                table: "PaymentStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentStatus_User_DeletedBy",
                table: "PaymentStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentStatus_User_ModifiedBy",
                table: "PaymentStatus");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_User_CreatedBy",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_User_DeletedBy",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_User_ModifiedBy",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImage_User_CreatedBy",
                table: "ProductImage");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImage_User_DeletedBy",
                table: "ProductImage");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImage_User_ModifiedBy",
                table: "ProductImage");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariant_User_CreatedBy",
                table: "ProductVariant");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariant_User_DeletedBy",
                table: "ProductVariant");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariant_User_ModifiedBy",
                table: "ProductVariant");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariantOption_User_CreatedBy",
                table: "ProductVariantOption");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariantOption_User_DeletedBy",
                table: "ProductVariantOption");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariantOption_User_ModifiedBy",
                table: "ProductVariantOption");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_User_CreatedBy",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_User_DeletedBy",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_User_ModifiedBy",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Role_User_CreatedBy",
                table: "Role");

            migrationBuilder.DropForeignKey(
                name: "FK_Role_User_DeletedBy",
                table: "Role");

            migrationBuilder.DropForeignKey(
                name: "FK_Role_User_ModifiedBy",
                table: "Role");

            migrationBuilder.DropForeignKey(
                name: "FK_ShippingRate_User_CreatedBy",
                table: "ShippingRate");

            migrationBuilder.DropForeignKey(
                name: "FK_ShippingRate_User_DeletedBy",
                table: "ShippingRate");

            migrationBuilder.DropForeignKey(
                name: "FK_ShippingRate_User_ModifiedBy",
                table: "ShippingRate");

            migrationBuilder.DropForeignKey(
                name: "FK_Sku_User_CreatedBy",
                table: "Sku");

            migrationBuilder.DropForeignKey(
                name: "FK_Sku_User_DeletedBy",
                table: "Sku");

            migrationBuilder.DropForeignKey(
                name: "FK_Sku_User_ModifiedBy",
                table: "Sku");

            migrationBuilder.DropForeignKey(
                name: "FK_SKUProductVariantOption_User_CreatedBy",
                table: "SKUProductVariantOption");

            migrationBuilder.DropForeignKey(
                name: "FK_SKUProductVariantOption_User_DeletedBy",
                table: "SKUProductVariantOption");

            migrationBuilder.DropForeignKey(
                name: "FK_SKUProductVariantOption_User_ModifiedBy",
                table: "SKUProductVariantOption");

            migrationBuilder.DropForeignKey(
                name: "FK_User_Role_RoleId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_CreatedBy",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_DeletedBy",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_User_User_ModifiedBy",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_Wishlist_User_CreatedBy",
                table: "Wishlist");

            migrationBuilder.DropForeignKey(
                name: "FK_Wishlist_User_DeletedBy",
                table: "Wishlist");

            migrationBuilder.DropForeignKey(
                name: "FK_Wishlist_User_ModifiedBy",
                table: "Wishlist");

            migrationBuilder.DropForeignKey(
                name: "FK_Wishlist_User_UserId",
                table: "Wishlist");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItem_User_CreatedBy",
                table: "WishlistItem");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItem_User_DeletedBy",
                table: "WishlistItem");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItem_User_ModifiedBy",
                table: "WishlistItem");

            migrationBuilder.DropIndex(
                name: "IX_WishlistItem_CreatedBy",
                table: "WishlistItem");

            migrationBuilder.DropIndex(
                name: "IX_WishlistItem_DeletedBy",
                table: "WishlistItem");

            migrationBuilder.DropIndex(
                name: "IX_WishlistItem_ModifiedBy",
                table: "WishlistItem");

            migrationBuilder.DropIndex(
                name: "IX_Wishlist_CreatedBy",
                table: "Wishlist");

            migrationBuilder.DropIndex(
                name: "IX_Wishlist_DeletedBy",
                table: "Wishlist");

            migrationBuilder.DropIndex(
                name: "IX_Wishlist_ModifiedBy",
                table: "Wishlist");

            migrationBuilder.DropIndex(
                name: "IX_User_CreatedBy",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_DeletedBy",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_ModifiedBy",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_SKUProductVariantOption_CreatedBy",
                table: "SKUProductVariantOption");

            migrationBuilder.DropIndex(
                name: "IX_SKUProductVariantOption_DeletedBy",
                table: "SKUProductVariantOption");

            migrationBuilder.DropIndex(
                name: "IX_SKUProductVariantOption_ModifiedBy",
                table: "SKUProductVariantOption");

            migrationBuilder.DropIndex(
                name: "IX_Sku_CreatedBy",
                table: "Sku");

            migrationBuilder.DropIndex(
                name: "IX_Sku_DeletedBy",
                table: "Sku");

            migrationBuilder.DropIndex(
                name: "IX_Sku_ModifiedBy",
                table: "Sku");

            migrationBuilder.DropIndex(
                name: "IX_ShippingRate_CreatedBy",
                table: "ShippingRate");

            migrationBuilder.DropIndex(
                name: "IX_ShippingRate_DeletedBy",
                table: "ShippingRate");

            migrationBuilder.DropIndex(
                name: "IX_ShippingRate_ModifiedBy",
                table: "ShippingRate");

            migrationBuilder.DropIndex(
                name: "IX_Role_CreatedBy",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Role_DeletedBy",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Role_ModifiedBy",
                table: "Role");

            migrationBuilder.DropIndex(
                name: "IX_Review_CreatedBy",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_DeletedBy",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_Review_ModifiedBy",
                table: "Review");

            migrationBuilder.DropIndex(
                name: "IX_ProductVariantOption_CreatedBy",
                table: "ProductVariantOption");

            migrationBuilder.DropIndex(
                name: "IX_ProductVariantOption_DeletedBy",
                table: "ProductVariantOption");

            migrationBuilder.DropIndex(
                name: "IX_ProductVariantOption_ModifiedBy",
                table: "ProductVariantOption");

            migrationBuilder.DropIndex(
                name: "IX_ProductVariant_CreatedBy",
                table: "ProductVariant");

            migrationBuilder.DropIndex(
                name: "IX_ProductVariant_DeletedBy",
                table: "ProductVariant");

            migrationBuilder.DropIndex(
                name: "IX_ProductVariant_ModifiedBy",
                table: "ProductVariant");

            migrationBuilder.DropIndex(
                name: "IX_ProductImage_CreatedBy",
                table: "ProductImage");

            migrationBuilder.DropIndex(
                name: "IX_ProductImage_DeletedBy",
                table: "ProductImage");

            migrationBuilder.DropIndex(
                name: "IX_ProductImage_ModifiedBy",
                table: "ProductImage");

            migrationBuilder.DropIndex(
                name: "IX_Product_CreatedBy",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_DeletedBy",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_ModifiedBy",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_PaymentStatus_CreatedBy",
                table: "PaymentStatus");

            migrationBuilder.DropIndex(
                name: "IX_PaymentStatus_DeletedBy",
                table: "PaymentStatus");

            migrationBuilder.DropIndex(
                name: "IX_PaymentStatus_ModifiedBy",
                table: "PaymentStatus");

            migrationBuilder.DropIndex(
                name: "IX_PaymentMethod_CreatedBy",
                table: "PaymentMethod");

            migrationBuilder.DropIndex(
                name: "IX_PaymentMethod_DeletedBy",
                table: "PaymentMethod");

            migrationBuilder.DropIndex(
                name: "IX_PaymentMethod_ModifiedBy",
                table: "PaymentMethod");

            migrationBuilder.DropIndex(
                name: "IX_Payment_CreatedBy",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_DeletedBy",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_Payment_ModifiedBy",
                table: "Payment");

            migrationBuilder.DropIndex(
                name: "IX_OrderStatus_CreatedBy",
                table: "OrderStatus");

            migrationBuilder.DropIndex(
                name: "IX_OrderStatus_DeletedBy",
                table: "OrderStatus");

            migrationBuilder.DropIndex(
                name: "IX_OrderStatus_ModifiedBy",
                table: "OrderStatus");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_CreatedBy",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_DeletedBy",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_OrderItem_ModifiedBy",
                table: "OrderItem");

            migrationBuilder.DropIndex(
                name: "IX_Order_CreatedBy",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_DeletedBy",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_Order_ModifiedBy",
                table: "Order");

            migrationBuilder.DropIndex(
                name: "IX_DiscountType_CreatedBy",
                table: "DiscountType");

            migrationBuilder.DropIndex(
                name: "IX_DiscountType_DeletedBy",
                table: "DiscountType");

            migrationBuilder.DropIndex(
                name: "IX_DiscountType_ModifiedBy",
                table: "DiscountType");

            migrationBuilder.DropIndex(
                name: "IX_Country_CreatedBy",
                table: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Country_DeletedBy",
                table: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Country_ModifiedBy",
                table: "Country");

            migrationBuilder.DropIndex(
                name: "IX_City_CreatedBy",
                table: "City");

            migrationBuilder.DropIndex(
                name: "IX_City_DeletedBy",
                table: "City");

            migrationBuilder.DropIndex(
                name: "IX_City_ModifiedBy",
                table: "City");

            migrationBuilder.DropIndex(
                name: "IX_Category_CreatedBy",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_DeletedBy",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_ModifiedBy",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_CartItem_CreatedBy",
                table: "CartItem");

            migrationBuilder.DropIndex(
                name: "IX_CartItem_DeletedBy",
                table: "CartItem");

            migrationBuilder.DropIndex(
                name: "IX_CartItem_ModifiedBy",
                table: "CartItem");

            migrationBuilder.DropIndex(
                name: "IX_Cart_CreatedBy",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_DeletedBy",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Cart_ModifiedBy",
                table: "Cart");

            migrationBuilder.DropIndex(
                name: "IX_Address_CreatedBy",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_DeletedBy",
                table: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Address_ModifiedBy",
                table: "Address");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_User_UserId",
                table: "Address",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cart_User_UserId",
                table: "Cart",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_User_UserId",
                table: "Order",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_RoleId",
                table: "User",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlist_User_UserId",
                table: "Wishlist",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
