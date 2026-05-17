using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUsersRolesTableAndRenameTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_City_CityId",
                table: "Address");

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
                name: "FK_CartItem_Cart_CartId",
                table: "CartItem");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItem_Sku_SkuId",
                table: "CartItem");

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
                name: "FK_Category_Category_ParentCategoryId",
                table: "Category");

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
                name: "FK_City_Country_CountryId",
                table: "City");

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
                name: "FK_Order_Address_AddressId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_OrderStatus_OrderStatusId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Payment_PaymentId",
                table: "Order");

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
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItem_Sku_SkuId",
                table: "OrderItem");

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
                name: "FK_Payment_PaymentMethod_PaymentMethodId",
                table: "Payment");

            migrationBuilder.DropForeignKey(
                name: "FK_Payment_PaymentStatus_PaymentStatusId",
                table: "Payment");

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
                name: "FK_Product_Category_CategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_DiscountType_DiscountTypeId",
                table: "Product");

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
                name: "FK_ProductImage_Product_ProductId",
                table: "ProductImage");

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
                name: "FK_ProductVariant_Product_ProductId",
                table: "ProductVariant");

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
                name: "FK_ProductVariantOption_ProductVariant_ProductVariantId",
                table: "ProductVariantOption");

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
                name: "FK_Review_OrderItem_OrderItemId",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Product_ProductId",
                table: "Review");

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
                name: "FK_Review_User_UserId",
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
                name: "FK_ShippingRate_City_CityId",
                table: "ShippingRate");

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
                name: "FK_Sku_Product_ProductId",
                table: "Sku");

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
                name: "FK_SKUProductVariantOption_ProductVariantOption_ProductVariantOptionsId",
                table: "SKUProductVariantOption");

            migrationBuilder.DropForeignKey(
                name: "FK_SKUProductVariantOption_ProductVariant_ProductVariantId",
                table: "SKUProductVariantOption");

            migrationBuilder.DropForeignKey(
                name: "FK_SKUProductVariantOption_Sku_SkuId",
                table: "SKUProductVariantOption");

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
                name: "FK_WishlistItem_Sku_SkuId",
                table: "WishlistItem");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItem_User_CreatedBy",
                table: "WishlistItem");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItem_User_DeletedBy",
                table: "WishlistItem");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItem_User_ModifiedBy",
                table: "WishlistItem");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItem_Wishlist_WishlistId",
                table: "WishlistItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WishlistItem",
                table: "WishlistItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wishlist",
                table: "Wishlist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_RoleId",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SKUProductVariantOption",
                table: "SKUProductVariantOption");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sku",
                table: "Sku");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShippingRate",
                table: "ShippingRate");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Review",
                table: "Review");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductVariantOption",
                table: "ProductVariantOption");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductVariant",
                table: "ProductVariant");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImage",
                table: "ProductImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Product",
                table: "Product");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentStatus",
                table: "PaymentStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentMethod",
                table: "PaymentMethod");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payment",
                table: "Payment");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderStatus",
                table: "OrderStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Order",
                table: "Order");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiscountType",
                table: "DiscountType");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItem",
                table: "CartItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cart",
                table: "Cart");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Address",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "BaseRate",
                table: "ShippingRate");

            migrationBuilder.DropColumn(
                name: "FreeShippingThreshold",
                table: "ShippingRate");

            migrationBuilder.RenameTable(
                name: "WishlistItem",
                newName: "WishlistItems");

            migrationBuilder.RenameTable(
                name: "Wishlist",
                newName: "Wishlists");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "Users");

            migrationBuilder.RenameTable(
                name: "SKUProductVariantOption",
                newName: "SKUProductVariantOptions");

            migrationBuilder.RenameTable(
                name: "Sku",
                newName: "Skus");

            migrationBuilder.RenameTable(
                name: "ShippingRate",
                newName: "ShippingRates");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "Review",
                newName: "Reviews");

            migrationBuilder.RenameTable(
                name: "ProductVariantOption",
                newName: "ProductVariantOptions");

            migrationBuilder.RenameTable(
                name: "ProductVariant",
                newName: "ProductVariants");

            migrationBuilder.RenameTable(
                name: "ProductImage",
                newName: "ProductImages");

            migrationBuilder.RenameTable(
                name: "Product",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "PaymentStatus",
                newName: "PaymentStatuses");

            migrationBuilder.RenameTable(
                name: "PaymentMethod",
                newName: "PaymentMethods");

            migrationBuilder.RenameTable(
                name: "Payment",
                newName: "Payments");

            migrationBuilder.RenameTable(
                name: "OrderStatus",
                newName: "OrderStatuses");

            migrationBuilder.RenameTable(
                name: "OrderItem",
                newName: "OrderItems");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

            migrationBuilder.RenameTable(
                name: "DiscountType",
                newName: "DiscountTypes");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.RenameTable(
                name: "CartItem",
                newName: "CartItems");

            migrationBuilder.RenameTable(
                name: "Cart",
                newName: "Carts");

            migrationBuilder.RenameTable(
                name: "Address",
                newName: "Addresses");

            migrationBuilder.RenameIndex(
                name: "IX_WishlistItem_WishlistId",
                table: "WishlistItems",
                newName: "IX_WishlistItems_WishlistId");

            migrationBuilder.RenameIndex(
                name: "IX_WishlistItem_SkuId",
                table: "WishlistItems",
                newName: "IX_WishlistItems_SkuId");

            migrationBuilder.RenameIndex(
                name: "IX_WishlistItem_ModifiedBy",
                table: "WishlistItems",
                newName: "IX_WishlistItems_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_WishlistItem_DeletedBy",
                table: "WishlistItems",
                newName: "IX_WishlistItems_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_WishlistItem_CreatedBy",
                table: "WishlistItems",
                newName: "IX_WishlistItems_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Wishlist_UserId",
                table: "Wishlists",
                newName: "IX_Wishlists_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Wishlist_ModifiedBy",
                table: "Wishlists",
                newName: "IX_Wishlists_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Wishlist_DeletedBy",
                table: "Wishlists",
                newName: "IX_Wishlists_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Wishlist_CreatedBy",
                table: "Wishlists",
                newName: "IX_Wishlists_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_User_ModifiedBy",
                table: "Users",
                newName: "IX_Users_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_User_DeletedBy",
                table: "Users",
                newName: "IX_Users_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_User_CreatedBy",
                table: "Users",
                newName: "IX_Users_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_SKUProductVariantOption_ProductVariantOptionsId",
                table: "SKUProductVariantOptions",
                newName: "IX_SKUProductVariantOptions_ProductVariantOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_SKUProductVariantOption_ProductVariantId",
                table: "SKUProductVariantOptions",
                newName: "IX_SKUProductVariantOptions_ProductVariantId");

            migrationBuilder.RenameIndex(
                name: "IX_SKUProductVariantOption_ModifiedBy",
                table: "SKUProductVariantOptions",
                newName: "IX_SKUProductVariantOptions_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_SKUProductVariantOption_DeletedBy",
                table: "SKUProductVariantOptions",
                newName: "IX_SKUProductVariantOptions_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_SKUProductVariantOption_CreatedBy",
                table: "SKUProductVariantOptions",
                newName: "IX_SKUProductVariantOptions_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Sku_ProductId",
                table: "Skus",
                newName: "IX_Skus_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Sku_ModifiedBy",
                table: "Skus",
                newName: "IX_Skus_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Sku_DeletedBy",
                table: "Skus",
                newName: "IX_Skus_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Sku_CreatedBy",
                table: "Skus",
                newName: "IX_Skus_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "RatePerKg",
                table: "ShippingRates",
                newName: "ShippingCost");

            migrationBuilder.RenameIndex(
                name: "IX_ShippingRate_ModifiedBy",
                table: "ShippingRates",
                newName: "IX_ShippingRates_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ShippingRate_DeletedBy",
                table: "ShippingRates",
                newName: "IX_ShippingRates_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ShippingRate_CreatedBy",
                table: "ShippingRates",
                newName: "IX_ShippingRates_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ShippingRate_CityId",
                table: "ShippingRates",
                newName: "IX_ShippingRates_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Role_ModifiedBy",
                table: "Roles",
                newName: "IX_Roles_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Role_DeletedBy",
                table: "Roles",
                newName: "IX_Roles_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Role_CreatedBy",
                table: "Roles",
                newName: "IX_Roles_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Review_UserId",
                table: "Reviews",
                newName: "IX_Reviews_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_ProductId",
                table: "Reviews",
                newName: "IX_Reviews_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_OrderItemId",
                table: "Reviews",
                newName: "IX_Reviews_OrderItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Review_ModifiedBy",
                table: "Reviews",
                newName: "IX_Reviews_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Review_DeletedBy",
                table: "Reviews",
                newName: "IX_Reviews_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Review_CreatedBy",
                table: "Reviews",
                newName: "IX_Reviews_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariantOption_ProductVariantId",
                table: "ProductVariantOptions",
                newName: "IX_ProductVariantOptions_ProductVariantId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariantOption_ModifiedBy",
                table: "ProductVariantOptions",
                newName: "IX_ProductVariantOptions_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariantOption_DeletedBy",
                table: "ProductVariantOptions",
                newName: "IX_ProductVariantOptions_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariantOption_CreatedBy",
                table: "ProductVariantOptions",
                newName: "IX_ProductVariantOptions_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariant_ProductId",
                table: "ProductVariants",
                newName: "IX_ProductVariants_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariant_ModifiedBy",
                table: "ProductVariants",
                newName: "IX_ProductVariants_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariant_DeletedBy",
                table: "ProductVariants",
                newName: "IX_ProductVariants_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariant_CreatedBy",
                table: "ProductVariants",
                newName: "IX_ProductVariants_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImage_ProductId",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImage_ModifiedBy",
                table: "ProductImages",
                newName: "IX_ProductImages_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImage_DeletedBy",
                table: "ProductImages",
                newName: "IX_ProductImages_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImage_CreatedBy",
                table: "ProductImages",
                newName: "IX_ProductImages_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Product_ModifiedBy",
                table: "Products",
                newName: "IX_Products_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Product_DiscountTypeId",
                table: "Products",
                newName: "IX_Products_DiscountTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Product_DeletedBy",
                table: "Products",
                newName: "IX_Products_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CreatedBy",
                table: "Products",
                newName: "IX_Products_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentStatus_ModifiedBy",
                table: "PaymentStatuses",
                newName: "IX_PaymentStatuses_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentStatus_DeletedBy",
                table: "PaymentStatuses",
                newName: "IX_PaymentStatuses_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentStatus_CreatedBy",
                table: "PaymentStatuses",
                newName: "IX_PaymentStatuses_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_ModifiedBy",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_DeletedBy",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethod_CreatedBy",
                table: "PaymentMethods",
                newName: "IX_PaymentMethods_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_PaymentStatusId",
                table: "Payments",
                newName: "IX_Payments_PaymentStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_PaymentMethodId",
                table: "Payments",
                newName: "IX_Payments_PaymentMethodId");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_ModifiedBy",
                table: "Payments",
                newName: "IX_Payments_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_DeletedBy",
                table: "Payments",
                newName: "IX_Payments_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Payment_CreatedBy",
                table: "Payments",
                newName: "IX_Payments_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_OrderStatus_ModifiedBy",
                table: "OrderStatuses",
                newName: "IX_OrderStatuses_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_OrderStatus_DeletedBy",
                table: "OrderStatuses",
                newName: "IX_OrderStatuses_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_OrderStatus_CreatedBy",
                table: "OrderStatuses",
                newName: "IX_OrderStatuses_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_SkuId",
                table: "OrderItems",
                newName: "IX_OrderItems_SkuId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_ModifiedBy",
                table: "OrderItems",
                newName: "IX_OrderItems_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_DeletedBy",
                table: "OrderItems",
                newName: "IX_OrderItems_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_CreatedBy",
                table: "OrderItems",
                newName: "IX_OrderItems_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Order_UserId",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_PaymentId",
                table: "Orders",
                newName: "IX_Orders_PaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_OrderStatusId",
                table: "Orders",
                newName: "IX_Orders_OrderStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_ModifiedBy",
                table: "Orders",
                newName: "IX_Orders_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Order_DeletedBy",
                table: "Orders",
                newName: "IX_Orders_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Order_CreatedBy",
                table: "Orders",
                newName: "IX_Orders_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Order_AddressId",
                table: "Orders",
                newName: "IX_Orders_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_DiscountType_ModifiedBy",
                table: "DiscountTypes",
                newName: "IX_DiscountTypes_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_DiscountType_DeletedBy",
                table: "DiscountTypes",
                newName: "IX_DiscountTypes_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_DiscountType_CreatedBy",
                table: "DiscountTypes",
                newName: "IX_DiscountTypes_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Country_ModifiedBy",
                table: "Countries",
                newName: "IX_Countries_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Country_DeletedBy",
                table: "Countries",
                newName: "IX_Countries_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Country_CreatedBy",
                table: "Countries",
                newName: "IX_Countries_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_City_ModifiedBy",
                table: "Cities",
                newName: "IX_Cities_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_City_DeletedBy",
                table: "Cities",
                newName: "IX_Cities_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_City_CreatedBy",
                table: "Cities",
                newName: "IX_Cities_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_City_CountryId",
                table: "Cities",
                newName: "IX_Cities_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Category_ParentCategoryId",
                table: "Categories",
                newName: "IX_Categories_ParentCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Category_ModifiedBy",
                table: "Categories",
                newName: "IX_Categories_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Category_DeletedBy",
                table: "Categories",
                newName: "IX_Categories_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Category_CreatedBy",
                table: "Categories",
                newName: "IX_Categories_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_CartItem_SkuId",
                table: "CartItems",
                newName: "IX_CartItems_SkuId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItem_ModifiedBy",
                table: "CartItems",
                newName: "IX_CartItems_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_CartItem_DeletedBy",
                table: "CartItems",
                newName: "IX_CartItems_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_CartItem_CreatedBy",
                table: "CartItems",
                newName: "IX_CartItems_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_CartItem_CartId",
                table: "CartItems",
                newName: "IX_CartItems_CartId");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_UserId",
                table: "Carts",
                newName: "IX_Carts_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_ModifiedBy",
                table: "Carts",
                newName: "IX_Carts_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_DeletedBy",
                table: "Carts",
                newName: "IX_Carts_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_CreatedBy",
                table: "Carts",
                newName: "IX_Carts_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Address_UserId",
                table: "Addresses",
                newName: "IX_Addresses_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_ModifiedBy",
                table: "Addresses",
                newName: "IX_Addresses_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Address_DeletedBy",
                table: "Addresses",
                newName: "IX_Addresses_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Address_CreatedBy",
                table: "Addresses",
                newName: "IX_Addresses_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Address_CityId",
                table: "Addresses",
                newName: "IX_Addresses_CityId");

            migrationBuilder.AlterColumn<int>(
                name: "ProductVariantId",
                table: "SKUProductVariantOptions",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WishlistItems",
                table: "WishlistItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wishlists",
                table: "Wishlists",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SKUProductVariantOptions",
                table: "SKUProductVariantOptions",
                columns: new[] { "SkuId", "ProductVariantOptionsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skus",
                table: "Skus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShippingRates",
                table: "ShippingRates",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductVariantOptions",
                table: "ProductVariantOptions",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductVariants",
                table: "ProductVariants",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentStatuses",
                table: "PaymentStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentMethods",
                table: "PaymentMethods",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payments",
                table: "Payments",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderStatuses",
                table: "OrderStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Orders",
                table: "Orders",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiscountTypes",
                table: "DiscountTypes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Carts",
                table: "Carts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "UsersRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersRoles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsersRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UsersRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsersRoles_RoleId",
                table: "UsersRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UsersRoles_UserId",
                table: "UsersRoles",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Cities_CityId",
                table: "Addresses",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Users_CreatedBy",
                table: "Addresses",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Users_DeletedBy",
                table: "Addresses",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Users_ModifiedBy",
                table: "Addresses",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Users_UserId",
                table: "Addresses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Carts_CartId",
                table: "CartItems",
                column: "CartId",
                principalTable: "Carts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Skus_SkuId",
                table: "CartItems",
                column: "SkuId",
                principalTable: "Skus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Users_CreatedBy",
                table: "CartItems",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Users_DeletedBy",
                table: "CartItems",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Users_ModifiedBy",
                table: "CartItems",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_CreatedBy",
                table: "Carts",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_DeletedBy",
                table: "Carts",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_ModifiedBy",
                table: "Carts",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Categories_ParentCategoryId",
                table: "Categories",
                column: "ParentCategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_CreatedBy",
                table: "Categories",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_DeletedBy",
                table: "Categories",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_ModifiedBy",
                table: "Categories",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Users_CreatedBy",
                table: "Cities",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Users_DeletedBy",
                table: "Cities",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Users_ModifiedBy",
                table: "Cities",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Users_CreatedBy",
                table: "Countries",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Users_DeletedBy",
                table: "Countries",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Countries_Users_ModifiedBy",
                table: "Countries",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DiscountTypes_Users_CreatedBy",
                table: "DiscountTypes",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DiscountTypes_Users_DeletedBy",
                table: "DiscountTypes",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_DiscountTypes_Users_ModifiedBy",
                table: "DiscountTypes",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Skus_SkuId",
                table: "OrderItems",
                column: "SkuId",
                principalTable: "Skus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Users_CreatedBy",
                table: "OrderItems",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Users_DeletedBy",
                table: "OrderItems",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Users_ModifiedBy",
                table: "OrderItems",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderStatuses_OrderStatusId",
                table: "Orders",
                column: "OrderStatusId",
                principalTable: "OrderStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Payments_PaymentId",
                table: "Orders",
                column: "PaymentId",
                principalTable: "Payments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_CreatedBy",
                table: "Orders",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_DeletedBy",
                table: "Orders",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_ModifiedBy",
                table: "Orders",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderStatuses_Users_CreatedBy",
                table: "OrderStatuses",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderStatuses_Users_DeletedBy",
                table: "OrderStatuses",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderStatuses_Users_ModifiedBy",
                table: "OrderStatuses",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_Users_CreatedBy",
                table: "PaymentMethods",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_Users_DeletedBy",
                table: "PaymentMethods",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentMethods_Users_ModifiedBy",
                table: "PaymentMethods",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_PaymentMethods_PaymentMethodId",
                table: "Payments",
                column: "PaymentMethodId",
                principalTable: "PaymentMethods",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_PaymentStatuses_PaymentStatusId",
                table: "Payments",
                column: "PaymentStatusId",
                principalTable: "PaymentStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Users_CreatedBy",
                table: "Payments",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Users_DeletedBy",
                table: "Payments",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payments_Users_ModifiedBy",
                table: "Payments",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentStatuses_Users_CreatedBy",
                table: "PaymentStatuses",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentStatuses_Users_DeletedBy",
                table: "PaymentStatuses",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentStatuses_Users_ModifiedBy",
                table: "PaymentStatuses",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Users_CreatedBy",
                table: "ProductImages",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Users_DeletedBy",
                table: "ProductImages",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Users_ModifiedBy",
                table: "ProductImages",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_DiscountTypes_DiscountTypeId",
                table: "Products",
                column: "DiscountTypeId",
                principalTable: "DiscountTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_CreatedBy",
                table: "Products",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_DeletedBy",
                table: "Products",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Users_ModifiedBy",
                table: "Products",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariantOptions_ProductVariants_ProductVariantId",
                table: "ProductVariantOptions",
                column: "ProductVariantId",
                principalTable: "ProductVariants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariantOptions_Users_CreatedBy",
                table: "ProductVariantOptions",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariantOptions_Users_DeletedBy",
                table: "ProductVariantOptions",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariantOptions_Users_ModifiedBy",
                table: "ProductVariantOptions",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariants_Products_ProductId",
                table: "ProductVariants",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariants_Users_CreatedBy",
                table: "ProductVariants",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariants_Users_DeletedBy",
                table: "ProductVariants",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariants_Users_ModifiedBy",
                table: "ProductVariants",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_OrderItems_OrderItemId",
                table: "Reviews",
                column: "OrderItemId",
                principalTable: "OrderItems",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_CreatedBy",
                table: "Reviews",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_DeletedBy",
                table: "Reviews",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_ModifiedBy",
                table: "Reviews",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_CreatedBy",
                table: "Roles",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_DeletedBy",
                table: "Roles",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Users_ModifiedBy",
                table: "Roles",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingRates_Cities_CityId",
                table: "ShippingRates",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingRates_Users_CreatedBy",
                table: "ShippingRates",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingRates_Users_DeletedBy",
                table: "ShippingRates",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ShippingRates_Users_ModifiedBy",
                table: "ShippingRates",
                column: "ModifiedBy",
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
                name: "FK_SKUProductVariantOptions_Skus_SkuId",
                table: "SKUProductVariantOptions",
                column: "SkuId",
                principalTable: "Skus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SKUProductVariantOptions_Users_CreatedBy",
                table: "SKUProductVariantOptions",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SKUProductVariantOptions_Users_DeletedBy",
                table: "SKUProductVariantOptions",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SKUProductVariantOptions_Users_ModifiedBy",
                table: "SKUProductVariantOptions",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skus_Products_ProductId",
                table: "Skus",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skus_Users_CreatedBy",
                table: "Skus",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skus_Users_DeletedBy",
                table: "Skus",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Skus_Users_ModifiedBy",
                table: "Skus",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_CreatedBy",
                table: "Users",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_DeletedBy",
                table: "Users",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Users_ModifiedBy",
                table: "Users",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItems_Skus_SkuId",
                table: "WishlistItems",
                column: "SkuId",
                principalTable: "Skus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItems_Users_CreatedBy",
                table: "WishlistItems",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItems_Users_DeletedBy",
                table: "WishlistItems",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItems_Users_ModifiedBy",
                table: "WishlistItems",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItems_Wishlists_WishlistId",
                table: "WishlistItems",
                column: "WishlistId",
                principalTable: "Wishlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlists_Users_CreatedBy",
                table: "Wishlists",
                column: "CreatedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlists_Users_DeletedBy",
                table: "Wishlists",
                column: "DeletedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlists_Users_ModifiedBy",
                table: "Wishlists",
                column: "ModifiedBy",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlists_Users_UserId",
                table: "Wishlists",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Cities_CityId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Users_CreatedBy",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Users_DeletedBy",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Users_ModifiedBy",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Users_UserId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Carts_CartId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Skus_SkuId",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Users_CreatedBy",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Users_DeletedBy",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_CartItems_Users_ModifiedBy",
                table: "CartItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_CreatedBy",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_DeletedBy",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_ModifiedBy",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Categories_ParentCategoryId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_CreatedBy",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_DeletedBy",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_ModifiedBy",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Users_CreatedBy",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Users_DeletedBy",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Users_ModifiedBy",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Users_CreatedBy",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Users_DeletedBy",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_Countries_Users_ModifiedBy",
                table: "Countries");

            migrationBuilder.DropForeignKey(
                name: "FK_DiscountTypes_Users_CreatedBy",
                table: "DiscountTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_DiscountTypes_Users_DeletedBy",
                table: "DiscountTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_DiscountTypes_Users_ModifiedBy",
                table: "DiscountTypes");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Skus_SkuId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Users_CreatedBy",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Users_DeletedBy",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Users_ModifiedBy",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderStatuses_OrderStatusId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Payments_PaymentId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_CreatedBy",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_DeletedBy",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_ModifiedBy",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderStatuses_Users_CreatedBy",
                table: "OrderStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderStatuses_Users_DeletedBy",
                table: "OrderStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderStatuses_Users_ModifiedBy",
                table: "OrderStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_Users_CreatedBy",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_Users_DeletedBy",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentMethods_Users_ModifiedBy",
                table: "PaymentMethods");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_PaymentMethods_PaymentMethodId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_PaymentStatuses_PaymentStatusId",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Users_CreatedBy",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Users_DeletedBy",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_Payments_Users_ModifiedBy",
                table: "Payments");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentStatuses_Users_CreatedBy",
                table: "PaymentStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentStatuses_Users_DeletedBy",
                table: "PaymentStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_PaymentStatuses_Users_ModifiedBy",
                table: "PaymentStatuses");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Users_CreatedBy",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Users_DeletedBy",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Users_ModifiedBy",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_DiscountTypes_DiscountTypeId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_CreatedBy",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_DeletedBy",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Users_ModifiedBy",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariantOptions_ProductVariants_ProductVariantId",
                table: "ProductVariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariantOptions_Users_CreatedBy",
                table: "ProductVariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariantOptions_Users_DeletedBy",
                table: "ProductVariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariantOptions_Users_ModifiedBy",
                table: "ProductVariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariants_Products_ProductId",
                table: "ProductVariants");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariants_Users_CreatedBy",
                table: "ProductVariants");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariants_Users_DeletedBy",
                table: "ProductVariants");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariants_Users_ModifiedBy",
                table: "ProductVariants");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_OrderItems_OrderItemId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Products_ProductId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_CreatedBy",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_DeletedBy",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_ModifiedBy",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Reviews_Users_UserId",
                table: "Reviews");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_CreatedBy",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_DeletedBy",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Users_ModifiedBy",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_ShippingRates_Cities_CityId",
                table: "ShippingRates");

            migrationBuilder.DropForeignKey(
                name: "FK_ShippingRates_Users_CreatedBy",
                table: "ShippingRates");

            migrationBuilder.DropForeignKey(
                name: "FK_ShippingRates_Users_DeletedBy",
                table: "ShippingRates");

            migrationBuilder.DropForeignKey(
                name: "FK_ShippingRates_Users_ModifiedBy",
                table: "ShippingRates");

            migrationBuilder.DropForeignKey(
                name: "FK_SKUProductVariantOptions_ProductVariantOptions_ProductVariantOptionsId",
                table: "SKUProductVariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_SKUProductVariantOptions_ProductVariants_ProductVariantId",
                table: "SKUProductVariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_SKUProductVariantOptions_Skus_SkuId",
                table: "SKUProductVariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_SKUProductVariantOptions_Users_CreatedBy",
                table: "SKUProductVariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_SKUProductVariantOptions_Users_DeletedBy",
                table: "SKUProductVariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_SKUProductVariantOptions_Users_ModifiedBy",
                table: "SKUProductVariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Skus_Products_ProductId",
                table: "Skus");

            migrationBuilder.DropForeignKey(
                name: "FK_Skus_Users_CreatedBy",
                table: "Skus");

            migrationBuilder.DropForeignKey(
                name: "FK_Skus_Users_DeletedBy",
                table: "Skus");

            migrationBuilder.DropForeignKey(
                name: "FK_Skus_Users_ModifiedBy",
                table: "Skus");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_CreatedBy",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_DeletedBy",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Users_ModifiedBy",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItems_Skus_SkuId",
                table: "WishlistItems");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItems_Users_CreatedBy",
                table: "WishlistItems");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItems_Users_DeletedBy",
                table: "WishlistItems");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItems_Users_ModifiedBy",
                table: "WishlistItems");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItems_Wishlists_WishlistId",
                table: "WishlistItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Wishlists_Users_CreatedBy",
                table: "Wishlists");

            migrationBuilder.DropForeignKey(
                name: "FK_Wishlists_Users_DeletedBy",
                table: "Wishlists");

            migrationBuilder.DropForeignKey(
                name: "FK_Wishlists_Users_ModifiedBy",
                table: "Wishlists");

            migrationBuilder.DropForeignKey(
                name: "FK_Wishlists_Users_UserId",
                table: "Wishlists");

            migrationBuilder.DropTable(
                name: "UsersRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wishlists",
                table: "Wishlists");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WishlistItems",
                table: "WishlistItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Skus",
                table: "Skus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SKUProductVariantOptions",
                table: "SKUProductVariantOptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ShippingRates",
                table: "ShippingRates");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Reviews",
                table: "Reviews");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductVariants",
                table: "ProductVariants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductVariantOptions",
                table: "ProductVariantOptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductImages",
                table: "ProductImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentStatuses",
                table: "PaymentStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Payments",
                table: "Payments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PaymentMethods",
                table: "PaymentMethods");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderStatuses",
                table: "OrderStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DiscountTypes",
                table: "DiscountTypes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Carts",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CartItems",
                table: "CartItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Wishlists",
                newName: "Wishlist");

            migrationBuilder.RenameTable(
                name: "WishlistItems",
                newName: "WishlistItem");

            migrationBuilder.RenameTable(
                name: "Users",
                newName: "User");

            migrationBuilder.RenameTable(
                name: "Skus",
                newName: "Sku");

            migrationBuilder.RenameTable(
                name: "SKUProductVariantOptions",
                newName: "SKUProductVariantOption");

            migrationBuilder.RenameTable(
                name: "ShippingRates",
                newName: "ShippingRate");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Role");

            migrationBuilder.RenameTable(
                name: "Reviews",
                newName: "Review");

            migrationBuilder.RenameTable(
                name: "ProductVariants",
                newName: "ProductVariant");

            migrationBuilder.RenameTable(
                name: "ProductVariantOptions",
                newName: "ProductVariantOption");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Product");

            migrationBuilder.RenameTable(
                name: "ProductImages",
                newName: "ProductImage");

            migrationBuilder.RenameTable(
                name: "PaymentStatuses",
                newName: "PaymentStatus");

            migrationBuilder.RenameTable(
                name: "Payments",
                newName: "Payment");

            migrationBuilder.RenameTable(
                name: "PaymentMethods",
                newName: "PaymentMethod");

            migrationBuilder.RenameTable(
                name: "OrderStatuses",
                newName: "OrderStatus");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "OrderItem");

            migrationBuilder.RenameTable(
                name: "DiscountTypes",
                newName: "DiscountType");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.RenameTable(
                name: "Carts",
                newName: "Cart");

            migrationBuilder.RenameTable(
                name: "CartItems",
                newName: "CartItem");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "Address");

            migrationBuilder.RenameIndex(
                name: "IX_Wishlists_UserId",
                table: "Wishlist",
                newName: "IX_Wishlist_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Wishlists_ModifiedBy",
                table: "Wishlist",
                newName: "IX_Wishlist_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Wishlists_DeletedBy",
                table: "Wishlist",
                newName: "IX_Wishlist_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Wishlists_CreatedBy",
                table: "Wishlist",
                newName: "IX_Wishlist_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_WishlistItems_WishlistId",
                table: "WishlistItem",
                newName: "IX_WishlistItem_WishlistId");

            migrationBuilder.RenameIndex(
                name: "IX_WishlistItems_SkuId",
                table: "WishlistItem",
                newName: "IX_WishlistItem_SkuId");

            migrationBuilder.RenameIndex(
                name: "IX_WishlistItems_ModifiedBy",
                table: "WishlistItem",
                newName: "IX_WishlistItem_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_WishlistItems_DeletedBy",
                table: "WishlistItem",
                newName: "IX_WishlistItem_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_WishlistItems_CreatedBy",
                table: "WishlistItem",
                newName: "IX_WishlistItem_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Users_ModifiedBy",
                table: "User",
                newName: "IX_User_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Users_DeletedBy",
                table: "User",
                newName: "IX_User_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Users_CreatedBy",
                table: "User",
                newName: "IX_User_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Skus_ProductId",
                table: "Sku",
                newName: "IX_Sku_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Skus_ModifiedBy",
                table: "Sku",
                newName: "IX_Sku_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Skus_DeletedBy",
                table: "Sku",
                newName: "IX_Sku_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Skus_CreatedBy",
                table: "Sku",
                newName: "IX_Sku_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_SKUProductVariantOptions_ProductVariantOptionsId",
                table: "SKUProductVariantOption",
                newName: "IX_SKUProductVariantOption_ProductVariantOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_SKUProductVariantOptions_ProductVariantId",
                table: "SKUProductVariantOption",
                newName: "IX_SKUProductVariantOption_ProductVariantId");

            migrationBuilder.RenameIndex(
                name: "IX_SKUProductVariantOptions_ModifiedBy",
                table: "SKUProductVariantOption",
                newName: "IX_SKUProductVariantOption_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_SKUProductVariantOptions_DeletedBy",
                table: "SKUProductVariantOption",
                newName: "IX_SKUProductVariantOption_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_SKUProductVariantOptions_CreatedBy",
                table: "SKUProductVariantOption",
                newName: "IX_SKUProductVariantOption_CreatedBy");

            migrationBuilder.RenameColumn(
                name: "ShippingCost",
                table: "ShippingRate",
                newName: "RatePerKg");

            migrationBuilder.RenameIndex(
                name: "IX_ShippingRates_ModifiedBy",
                table: "ShippingRate",
                newName: "IX_ShippingRate_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ShippingRates_DeletedBy",
                table: "ShippingRate",
                newName: "IX_ShippingRate_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ShippingRates_CreatedBy",
                table: "ShippingRate",
                newName: "IX_ShippingRate_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ShippingRates_CityId",
                table: "ShippingRate",
                newName: "IX_ShippingRate_CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_ModifiedBy",
                table: "Role",
                newName: "IX_Role_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_DeletedBy",
                table: "Role",
                newName: "IX_Role_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Roles_CreatedBy",
                table: "Role",
                newName: "IX_Role_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_UserId",
                table: "Review",
                newName: "IX_Review_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_ProductId",
                table: "Review",
                newName: "IX_Review_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_OrderItemId",
                table: "Review",
                newName: "IX_Review_OrderItemId");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_ModifiedBy",
                table: "Review",
                newName: "IX_Review_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_DeletedBy",
                table: "Review",
                newName: "IX_Review_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Reviews_CreatedBy",
                table: "Review",
                newName: "IX_Review_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariants_ProductId",
                table: "ProductVariant",
                newName: "IX_ProductVariant_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariants_ModifiedBy",
                table: "ProductVariant",
                newName: "IX_ProductVariant_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariants_DeletedBy",
                table: "ProductVariant",
                newName: "IX_ProductVariant_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariants_CreatedBy",
                table: "ProductVariant",
                newName: "IX_ProductVariant_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariantOptions_ProductVariantId",
                table: "ProductVariantOption",
                newName: "IX_ProductVariantOption_ProductVariantId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariantOptions_ModifiedBy",
                table: "ProductVariantOption",
                newName: "IX_ProductVariantOption_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariantOptions_DeletedBy",
                table: "ProductVariantOption",
                newName: "IX_ProductVariantOption_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariantOptions_CreatedBy",
                table: "ProductVariantOption",
                newName: "IX_ProductVariantOption_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Products_ModifiedBy",
                table: "Product",
                newName: "IX_Product_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Products_DiscountTypeId",
                table: "Product",
                newName: "IX_Product_DiscountTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_DeletedBy",
                table: "Product",
                newName: "IX_Product_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CreatedBy",
                table: "Product",
                newName: "IX_Product_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Product",
                newName: "IX_Product_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImage",
                newName: "IX_ProductImage_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ModifiedBy",
                table: "ProductImage",
                newName: "IX_ProductImage_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_DeletedBy",
                table: "ProductImage",
                newName: "IX_ProductImage_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_CreatedBy",
                table: "ProductImage",
                newName: "IX_ProductImage_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentStatuses_ModifiedBy",
                table: "PaymentStatus",
                newName: "IX_PaymentStatus_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentStatuses_DeletedBy",
                table: "PaymentStatus",
                newName: "IX_PaymentStatus_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentStatuses_CreatedBy",
                table: "PaymentStatus",
                newName: "IX_PaymentStatus_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_PaymentStatusId",
                table: "Payment",
                newName: "IX_Payment_PaymentStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_PaymentMethodId",
                table: "Payment",
                newName: "IX_Payment_PaymentMethodId");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_ModifiedBy",
                table: "Payment",
                newName: "IX_Payment_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_DeletedBy",
                table: "Payment",
                newName: "IX_Payment_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Payments_CreatedBy",
                table: "Payment",
                newName: "IX_Payment_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_ModifiedBy",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_DeletedBy",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_PaymentMethods_CreatedBy",
                table: "PaymentMethod",
                newName: "IX_PaymentMethod_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_OrderStatuses_ModifiedBy",
                table: "OrderStatus",
                newName: "IX_OrderStatus_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_OrderStatuses_DeletedBy",
                table: "OrderStatus",
                newName: "IX_OrderStatus_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_OrderStatuses_CreatedBy",
                table: "OrderStatus",
                newName: "IX_OrderStatus_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "Order",
                newName: "IX_Order_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_PaymentId",
                table: "Order",
                newName: "IX_Order_PaymentId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_OrderStatusId",
                table: "Order",
                newName: "IX_Order_OrderStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_ModifiedBy",
                table: "Order",
                newName: "IX_Order_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_DeletedBy",
                table: "Order",
                newName: "IX_Order_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_CreatedBy",
                table: "Order",
                newName: "IX_Order_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_AddressId",
                table: "Order",
                newName: "IX_Order_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_SkuId",
                table: "OrderItem",
                newName: "IX_OrderItem_SkuId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItem",
                newName: "IX_OrderItem_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_ModifiedBy",
                table: "OrderItem",
                newName: "IX_OrderItem_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_DeletedBy",
                table: "OrderItem",
                newName: "IX_OrderItem_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_CreatedBy",
                table: "OrderItem",
                newName: "IX_OrderItem_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_DiscountTypes_ModifiedBy",
                table: "DiscountType",
                newName: "IX_DiscountType_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_DiscountTypes_DeletedBy",
                table: "DiscountType",
                newName: "IX_DiscountType_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_DiscountTypes_CreatedBy",
                table: "DiscountType",
                newName: "IX_DiscountType_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_ModifiedBy",
                table: "Country",
                newName: "IX_Country_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_DeletedBy",
                table: "Country",
                newName: "IX_Country_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Countries_CreatedBy",
                table: "Country",
                newName: "IX_Country_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_ModifiedBy",
                table: "City",
                newName: "IX_City_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_DeletedBy",
                table: "City",
                newName: "IX_City_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_CreatedBy",
                table: "City",
                newName: "IX_City_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_CountryId",
                table: "City",
                newName: "IX_City_CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_ParentCategoryId",
                table: "Category",
                newName: "IX_Category_ParentCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_ModifiedBy",
                table: "Category",
                newName: "IX_Category_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_DeletedBy",
                table: "Category",
                newName: "IX_Category_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Categories_CreatedBy",
                table: "Category",
                newName: "IX_Category_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_UserId",
                table: "Cart",
                newName: "IX_Cart_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_ModifiedBy",
                table: "Cart",
                newName: "IX_Cart_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_DeletedBy",
                table: "Cart",
                newName: "IX_Cart_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_CreatedBy",
                table: "Cart",
                newName: "IX_Cart_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_SkuId",
                table: "CartItem",
                newName: "IX_CartItem_SkuId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_ModifiedBy",
                table: "CartItem",
                newName: "IX_CartItem_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_DeletedBy",
                table: "CartItem",
                newName: "IX_CartItem_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_CreatedBy",
                table: "CartItem",
                newName: "IX_CartItem_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_CartId",
                table: "CartItem",
                newName: "IX_CartItem_CartId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_UserId",
                table: "Address",
                newName: "IX_Address_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_ModifiedBy",
                table: "Address",
                newName: "IX_Address_ModifiedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_DeletedBy",
                table: "Address",
                newName: "IX_Address_DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_CreatedBy",
                table: "Address",
                newName: "IX_Address_CreatedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_CityId",
                table: "Address",
                newName: "IX_Address_CityId");

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ProductVariantId",
                table: "SKUProductVariantOption",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "BaseRate",
                table: "ShippingRate",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FreeShippingThreshold",
                table: "ShippingRate",
                type: "decimal(10,2)",
                precision: 10,
                scale: 2,
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Wishlist",
                table: "Wishlist",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_WishlistItem",
                table: "WishlistItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Sku",
                table: "Sku",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SKUProductVariantOption",
                table: "SKUProductVariantOption",
                columns: new[] { "SkuId", "ProductVariantOptionsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShippingRate",
                table: "ShippingRate",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Review",
                table: "Review",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductVariant",
                table: "ProductVariant",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductVariantOption",
                table: "ProductVariantOption",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Product",
                table: "Product",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductImage",
                table: "ProductImage",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentStatus",
                table: "PaymentStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Payment",
                table: "Payment",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PaymentMethod",
                table: "PaymentMethod",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderStatus",
                table: "OrderStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Order",
                table: "Order",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItem",
                table: "OrderItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DiscountType",
                table: "DiscountType",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cart",
                table: "Cart",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CartItem",
                table: "CartItem",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Address",
                table: "Address",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_User_RoleId",
                table: "User",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_City_CityId",
                table: "Address",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_CartItem_Cart_CartId",
                table: "CartItem",
                column: "CartId",
                principalTable: "Cart",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Sku_SkuId",
                table: "CartItem",
                column: "SkuId",
                principalTable: "Sku",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Category_Category_ParentCategoryId",
                table: "Category",
                column: "ParentCategoryId",
                principalTable: "Category",
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
                name: "FK_City_Country_CountryId",
                table: "City",
                column: "CountryId",
                principalTable: "Country",
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
                name: "FK_Order_Address_AddressId",
                table: "Order",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_OrderStatus_OrderStatusId",
                table: "Order",
                column: "OrderStatusId",
                principalTable: "OrderStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Payment_PaymentId",
                table: "Order",
                column: "PaymentId",
                principalTable: "Payment",
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
                name: "FK_OrderItem_Order_OrderId",
                table: "OrderItem",
                column: "OrderId",
                principalTable: "Order",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Sku_SkuId",
                table: "OrderItem",
                column: "SkuId",
                principalTable: "Sku",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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
                name: "FK_Payment_PaymentMethod_PaymentMethodId",
                table: "Payment",
                column: "PaymentMethodId",
                principalTable: "PaymentMethod",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Payment_PaymentStatus_PaymentStatusId",
                table: "Payment",
                column: "PaymentStatusId",
                principalTable: "PaymentStatus",
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
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_DiscountType_DiscountTypeId",
                table: "Product",
                column: "DiscountTypeId",
                principalTable: "DiscountType",
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
                name: "FK_ProductImage_Product_ProductId",
                table: "ProductImage",
                column: "ProductId",
                principalTable: "Product",
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
                name: "FK_ProductVariant_Product_ProductId",
                table: "ProductVariant",
                column: "ProductId",
                principalTable: "Product",
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
                name: "FK_ProductVariantOption_ProductVariant_ProductVariantId",
                table: "ProductVariantOption",
                column: "ProductVariantId",
                principalTable: "ProductVariant",
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
                name: "FK_Review_OrderItem_OrderItemId",
                table: "Review",
                column: "OrderItemId",
                principalTable: "OrderItem",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Product_ProductId",
                table: "Review",
                column: "ProductId",
                principalTable: "Product",
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
                name: "FK_Review_User_UserId",
                table: "Review",
                column: "UserId",
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
                name: "FK_ShippingRate_City_CityId",
                table: "ShippingRate",
                column: "CityId",
                principalTable: "City",
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
                name: "FK_Sku_Product_ProductId",
                table: "Sku",
                column: "ProductId",
                principalTable: "Product",
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
                name: "FK_SKUProductVariantOption_ProductVariantOption_ProductVariantOptionsId",
                table: "SKUProductVariantOption",
                column: "ProductVariantOptionsId",
                principalTable: "ProductVariantOption",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SKUProductVariantOption_ProductVariant_ProductVariantId",
                table: "SKUProductVariantOption",
                column: "ProductVariantId",
                principalTable: "ProductVariant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SKUProductVariantOption_Sku_SkuId",
                table: "SKUProductVariantOption",
                column: "SkuId",
                principalTable: "Sku",
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
                name: "FK_WishlistItem_Sku_SkuId",
                table: "WishlistItem",
                column: "SkuId",
                principalTable: "Sku",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

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

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItem_Wishlist_WishlistId",
                table: "WishlistItem",
                column: "WishlistId",
                principalTable: "Wishlist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
