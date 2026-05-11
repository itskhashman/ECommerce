using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEntitesBasedOnDbSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Cities_CityId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_Countries_CountryId",
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
                name: "FK_Carts_Users_UserId",
                table: "Carts");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Skus_SkuId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Addresses_AddressId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderStatuses_OrderStatusId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariantOptions_ProductVariants_ProductVariantId",
                table: "ProductVariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariants_Products_ProductId",
                table: "ProductVariants");

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
                name: "FK_SKUProductVariantOptions_Skus_SkuId",
                table: "SKUProductVariantOptions");

            migrationBuilder.DropForeignKey(
                name: "FK_Skus_Products_ProductId",
                table: "Skus");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItems_Skus_SkuId",
                table: "WishlistItems");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItems_Wishlists_WishlistId",
                table: "WishlistItems");

            migrationBuilder.DropForeignKey(
                name: "FK_Wishlists_Users_UserId",
                table: "Wishlists");

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

            migrationBuilder.DropIndex(
                name: "IX_SKUProductVariantOptions_ProductVariantId1",
                table: "SKUProductVariantOptions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

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
                name: "PK_OrderStatuses",
                table: "OrderStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Orders",
                table: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

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

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CountryId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "RoleName",
                table: "Roles");

            migrationBuilder.DropColumn(
                name: "DefaultPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "DiscountType",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "StatusName",
                table: "OrderStatuses");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Cities");

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
                name: "Roles",
                newName: "Role");

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
                name: "OrderStatuses",
                newName: "OrderStatus");

            migrationBuilder.RenameTable(
                name: "Orders",
                newName: "Order");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "OrderItem");

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
                name: "IX_WishlistItems_WishlistId",
                table: "WishlistItem",
                newName: "IX_WishlistItem_WishlistId");

            migrationBuilder.RenameIndex(
                name: "IX_WishlistItems_SkuId",
                table: "WishlistItem",
                newName: "IX_WishlistItem_SkuId");

            migrationBuilder.RenameIndex(
                name: "IX_Users_RoleId",
                table: "User",
                newName: "IX_User_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_Skus_ProductId",
                table: "Sku",
                newName: "IX_Sku_ProductId");

            migrationBuilder.RenameColumn(
                name: "ProductVariantId1",
                table: "SKUProductVariantOption",
                newName: "DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_SKUProductVariantOptions_ProductVariantOptionsId",
                table: "SKUProductVariantOption",
                newName: "IX_SKUProductVariantOption_ProductVariantOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_SKUProductVariantOptions_ProductVariantId",
                table: "SKUProductVariantOption",
                newName: "IX_SKUProductVariantOption_ProductVariantId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariants_ProductId",
                table: "ProductVariant",
                newName: "IX_ProductVariant_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariantOptions_ProductVariantId",
                table: "ProductVariantOption",
                newName: "IX_ProductVariantOption_ProductVariantId");

            migrationBuilder.RenameColumn(
                name: "TotalStock",
                table: "Product",
                newName: "DiscountTypeId");

            migrationBuilder.RenameColumn(
                name: "ReviewCount",
                table: "Product",
                newName: "RateId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                table: "Product",
                newName: "IX_Product_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImages_ProductId",
                table: "ProductImage",
                newName: "IX_ProductImage_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_UserId",
                table: "Order",
                newName: "IX_Order_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Orders_OrderStatusId",
                table: "Order",
                newName: "IX_Order_OrderStatusId");

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
                name: "IX_Cities_CountryId",
                table: "City",
                newName: "IX_City_CountryId");

            migrationBuilder.RenameColumn(
                name: "NumberOfProducts",
                table: "Category",
                newName: "ParentCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Carts_UserId",
                table: "Cart",
                newName: "IX_Cart_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_SkuId",
                table: "CartItem",
                newName: "IX_CartItem_SkuId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItems_CartId",
                table: "CartItem",
                newName: "IX_CartItem_CartId");

            migrationBuilder.RenameColumn(
                name: "CountryId",
                table: "Address",
                newName: "DeletedBy");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_UserId",
                table: "Address",
                newName: "IX_Address_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Addresses_CityId",
                table: "Address",
                newName: "IX_Address_CityId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Wishlist",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Wishlist",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Wishlist",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "WishlistItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "WishlistItem",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "WishlistItem",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "WishlistItem",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "WishlistId",
                table: "User",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "MiddleNameAr",
                table: "User",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastNameAr",
                table: "User",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstNameAr",
                table: "User",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CartId",
                table: "User",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "User",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsEmailVerified",
                table: "User",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastLoginAt",
                table: "User",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<string>(
                name: "SkuCode",
                table: "Sku",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Sku",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Sku",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Sku",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Sku",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "LowStockThreshold",
                table: "Sku",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Weight",
                table: "Sku",
                type: "decimal(8,3)",
                precision: 8,
                scale: 3,
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "SKUProductVariantOption",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "CreatedBy",
                table: "SKUProductVariantOption",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "SKUProductVariantOption",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "SKUProductVariantOption",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SKUProductVariantOption",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifiedAt",
                table: "SKUProductVariantOption",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "ModifiedBy",
                table: "SKUProductVariantOption",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Role",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Role",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Role",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionAr",
                table: "Role",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "Role",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "Role",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "Role",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "ProductVariant",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "ProductVariant",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "ProductVariant",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ProductVariant",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "ProductVariant",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "ProductVariantOption",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "ProductVariantOption",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ProductVariantOption",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "ProductVariantOption",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HexColor",
                table: "ProductVariantOption",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "ProductVariantOption",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "Product",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "Product",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Product",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountAmount",
                table: "Product",
                type: "decimal(8,2)",
                precision: 8,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)",
                oldPrecision: 8,
                oldScale: 2);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Product",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Product",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "ProductImage",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AltText",
                table: "ProductImage",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "ProductImage",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "ProductImage",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "ProductImage",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "OrderStatus",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "OrderStatus",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "OrderStatus",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionAr",
                table: "OrderStatus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "OrderStatus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "OrderStatus",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "OrderStatus",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "OrderNumber",
                table: "Order",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Order",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CurrencyCode",
                table: "Order",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Order",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Order",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Order",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "ShippingCost",
                table: "Order",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "OrderItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "OrderItem",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "OrderItem",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DiscountAmount",
                table: "OrderItem",
                type: "decimal(8,2)",
                precision: 8,
                scale: 2,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ProductNameAr",
                table: "OrderItem",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ProductNameEn",
                table: "OrderItem",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SkuCode",
                table: "OrderItem",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "SubTotal",
                table: "OrderItem",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Country",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Country",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Country",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionAr",
                table: "Country",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "Country",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "Country",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "Country",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "City",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "City",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "City",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionAr",
                table: "City",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionEn",
                table: "City",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "NameAr",
                table: "City",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NameEn",
                table: "City",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "Category",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Category",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Category",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Cart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Cart",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "Cart",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiresAt",
                table: "Cart",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "CartItem",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "CartItem",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DeletedBy",
                table: "CartItem",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "PriceAtAddTime",
                table: "CartItem",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Address",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Address",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Address",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedAt",
                table: "Address",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDefault",
                table: "Address",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Label",
                table: "Address",
                type: "nvarchar(max)",
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
                columns: new[] { "SkuId", "ProductVariantId", "ProductVariantOptionsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
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

            migrationBuilder.CreateTable(
                name: "DiscountType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscountType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true),
                    NameAr = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NameEn = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    DescriptionAr = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DescriptionEn = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rate",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<decimal>(type: "decimal(4,2)", precision: 4, scale: 2, nullable: false),
                    ReviewCount = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Rate", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payment",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TransactionId = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    PaymentStatusId = table.Column<int>(type: "int", nullable: false),
                    PaidAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DeletedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payment_PaymentMethod_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethod",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payment_PaymentStatus_PaymentStatusId",
                        column: x => x.PaymentStatusId,
                        principalTable: "PaymentStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "عمان", "Amman" });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الزرقاء", "Zarqa" });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "إربد", "Irbid" });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الرصيفة", "Russeifa" });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "صاحب", "Sahab" });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "السلط", "As-Salt" });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "العقبة", "Aqaba" });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مادبا", "Madaba" });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "جرش", "Jerash" });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "معان", "Ma'an" });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "المفرق", "Al-Mafraq" });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الطفيلة", "Tafilah" });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "عجلون", "Ajloun" });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الرياض", "Riyadh" });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "جدة", "Jeddah" });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "دبي", "Dubai" });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "أبو ظبي", "Abu Dhabi" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "المملكة العربية السعودية", "Saudi Arabia" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الإمارات العربية المتحدة", "United Arab Emirates" });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "الأردن", "Jordan" });

            migrationBuilder.InsertData(
                table: "DiscountType",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "IsDeleted", "ModifiedAt", "ModifiedBy", "NameAr", "NameEn" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, null, null, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "نسبة مئوية", "Percentage" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, null, null, null, null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0, "مبلغ ثابت", "Fixed Amount" }
                });

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "قيد الانتظار", "Pending" });

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تم التأكيد", "Confirmed" });

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تم الشحن", "Shipped" });

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "تم التسليم", "Delivered" });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "مشرف", "Admin" });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "DeletedAt", "DeletedBy", "DescriptionAr", "DescriptionEn", "ModifiedAt", "NameAr", "NameEn" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, null, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "عميل", "Customer" });

            migrationBuilder.CreateIndex(
                name: "IX_Product_DiscountTypeId",
                table: "Product",
                column: "DiscountTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_RateId",
                table: "Product",
                column: "RateId");

            migrationBuilder.CreateIndex(
                name: "IX_Category_ParentCategoryId",
                table: "Category",
                column: "ParentCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentMethodId",
                table: "Payment",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Payment_PaymentStatusId",
                table: "Payment",
                column: "PaymentStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Address_City_CityId",
                table: "Address",
                column: "CityId",
                principalTable: "City",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Address_User_UserId",
                table: "Address",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItem_Sku_SkuId",
                table: "CartItem",
                column: "SkuId",
                principalTable: "Sku",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Category_Category_ParentCategoryId",
                table: "Category",
                column: "ParentCategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_Address_AddressId",
                table: "Order",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Order_OrderStatus_OrderStatusId",
                table: "Order",
                column: "OrderStatusId",
                principalTable: "OrderStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItem_Sku_SkuId",
                table: "OrderItem",
                column: "SkuId",
                principalTable: "Sku",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Category_CategoryId",
                table: "Product",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_DiscountType_DiscountTypeId",
                table: "Product",
                column: "DiscountTypeId",
                principalTable: "DiscountType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Product_Rate_RateId",
                table: "Product",
                column: "RateId",
                principalTable: "Rate",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImage_Product_ProductId",
                table: "ProductImage",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariant_Product_ProductId",
                table: "ProductVariant",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariantOption_ProductVariant_ProductVariantId",
                table: "ProductVariantOption",
                column: "ProductVariantId",
                principalTable: "ProductVariant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Sku_Product_ProductId",
                table: "Sku",
                column: "ProductId",
                principalTable: "Product",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SKUProductVariantOption_ProductVariantOption_ProductVariantOptionsId",
                table: "SKUProductVariantOption",
                column: "ProductVariantOptionsId",
                principalTable: "ProductVariantOption",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SKUProductVariantOption_ProductVariant_ProductVariantId",
                table: "SKUProductVariantOption",
                column: "ProductVariantId",
                principalTable: "ProductVariant",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SKUProductVariantOption_Sku_SkuId",
                table: "SKUProductVariantOption",
                column: "SkuId",
                principalTable: "Sku",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_Role_RoleId",
                table: "User",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItem_Wishlist_WishlistId",
                table: "WishlistItem",
                column: "WishlistId",
                principalTable: "Wishlist",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Address_City_CityId",
                table: "Address");

            migrationBuilder.DropForeignKey(
                name: "FK_Address_User_UserId",
                table: "Address");

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
                name: "FK_Category_Category_ParentCategoryId",
                table: "Category");

            migrationBuilder.DropForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_Address_AddressId",
                table: "Order");

            migrationBuilder.DropForeignKey(
                name: "FK_Order_OrderStatus_OrderStatusId",
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
                name: "FK_Product_Category_CategoryId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_DiscountType_DiscountTypeId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_Product_Rate_RateId",
                table: "Product");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductImage_Product_ProductId",
                table: "ProductImage");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariant_Product_ProductId",
                table: "ProductVariant");

            migrationBuilder.DropForeignKey(
                name: "FK_ProductVariantOption_ProductVariant_ProductVariantId",
                table: "ProductVariantOption");

            migrationBuilder.DropForeignKey(
                name: "FK_Sku_Product_ProductId",
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
                name: "FK_User_Role_RoleId",
                table: "User");

            migrationBuilder.DropForeignKey(
                name: "FK_Wishlist_User_UserId",
                table: "Wishlist");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItem_Sku_SkuId",
                table: "WishlistItem");

            migrationBuilder.DropForeignKey(
                name: "FK_WishlistItem_Wishlist_WishlistId",
                table: "WishlistItem");

            migrationBuilder.DropTable(
                name: "DiscountType");

            migrationBuilder.DropTable(
                name: "Payment");

            migrationBuilder.DropTable(
                name: "Rate");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "PaymentStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_WishlistItem",
                table: "WishlistItem");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Wishlist",
                table: "Wishlist");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SKUProductVariantOption",
                table: "SKUProductVariantOption");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Sku",
                table: "Sku");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

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

            migrationBuilder.DropIndex(
                name: "IX_Product_DiscountTypeId",
                table: "Product");

            migrationBuilder.DropIndex(
                name: "IX_Product_RateId",
                table: "Product");

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
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.DropIndex(
                name: "IX_Category_ParentCategoryId",
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
                name: "DeletedAt",
                table: "WishlistItem");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "WishlistItem");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "WishlistItem");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Wishlist");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Wishlist");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "User");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IsEmailVerified",
                table: "User");

            migrationBuilder.DropColumn(
                name: "LastLoginAt",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "SKUProductVariantOption");

            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "SKUProductVariantOption");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "SKUProductVariantOption");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "SKUProductVariantOption");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SKUProductVariantOption");

            migrationBuilder.DropColumn(
                name: "ModifiedAt",
                table: "SKUProductVariantOption");

            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "SKUProductVariantOption");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Sku");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Sku");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Sku");

            migrationBuilder.DropColumn(
                name: "LowStockThreshold",
                table: "Sku");

            migrationBuilder.DropColumn(
                name: "Weight",
                table: "Sku");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "DescriptionAr",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ProductVariantOption");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ProductVariantOption");

            migrationBuilder.DropColumn(
                name: "HexColor",
                table: "ProductVariantOption");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "ProductVariantOption");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ProductVariant");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ProductVariant");

            migrationBuilder.DropColumn(
                name: "AltText",
                table: "ProductImage");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "ProductImage");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "ProductImage");

            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "ProductImage");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Product");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "OrderStatus");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "OrderStatus");

            migrationBuilder.DropColumn(
                name: "DescriptionAr",
                table: "OrderStatus");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "OrderStatus");

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "OrderStatus");

            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "OrderStatus");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "DiscountAmount",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "ProductNameAr",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "ProductNameEn",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "SkuCode",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "SubTotal",
                table: "OrderItem");

            migrationBuilder.DropColumn(
                name: "CurrencyCode",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "ShippingCost",
                table: "Order");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "DescriptionAr",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "Country");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "City");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "City");

            migrationBuilder.DropColumn(
                name: "DescriptionAr",
                table: "City");

            migrationBuilder.DropColumn(
                name: "DescriptionEn",
                table: "City");

            migrationBuilder.DropColumn(
                name: "NameAr",
                table: "City");

            migrationBuilder.DropColumn(
                name: "NameEn",
                table: "City");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Category");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "CartItem");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "CartItem");

            migrationBuilder.DropColumn(
                name: "PriceAtAddTime",
                table: "CartItem");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "DeletedBy",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "ExpiresAt",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "DeletedAt",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "IsDefault",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "Label",
                table: "Address");

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
                name: "Role",
                newName: "Roles");

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
                name: "OrderStatus",
                newName: "OrderStatuses");

            migrationBuilder.RenameTable(
                name: "OrderItem",
                newName: "OrderItems");

            migrationBuilder.RenameTable(
                name: "Order",
                newName: "Orders");

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
                name: "IX_Wishlist_UserId",
                table: "Wishlists",
                newName: "IX_Wishlists_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_User_RoleId",
                table: "Users",
                newName: "IX_Users_RoleId");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "SKUProductVariantOptions",
                newName: "ProductVariantId1");

            migrationBuilder.RenameIndex(
                name: "IX_SKUProductVariantOption_ProductVariantOptionsId",
                table: "SKUProductVariantOptions",
                newName: "IX_SKUProductVariantOptions_ProductVariantOptionsId");

            migrationBuilder.RenameIndex(
                name: "IX_SKUProductVariantOption_ProductVariantId",
                table: "SKUProductVariantOptions",
                newName: "IX_SKUProductVariantOptions_ProductVariantId");

            migrationBuilder.RenameIndex(
                name: "IX_Sku_ProductId",
                table: "Skus",
                newName: "IX_Skus_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariantOption_ProductVariantId",
                table: "ProductVariantOptions",
                newName: "IX_ProductVariantOptions_ProductVariantId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductVariant_ProductId",
                table: "ProductVariants",
                newName: "IX_ProductVariants_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_ProductImage_ProductId",
                table: "ProductImages",
                newName: "IX_ProductImages_ProductId");

            migrationBuilder.RenameColumn(
                name: "RateId",
                table: "Products",
                newName: "ReviewCount");

            migrationBuilder.RenameColumn(
                name: "DiscountTypeId",
                table: "Products",
                newName: "TotalStock");

            migrationBuilder.RenameIndex(
                name: "IX_Product_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_SkuId",
                table: "OrderItems",
                newName: "IX_OrderItems_SkuId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItem_OrderId",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_UserId",
                table: "Orders",
                newName: "IX_Orders_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_OrderStatusId",
                table: "Orders",
                newName: "IX_Orders_OrderStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Order_AddressId",
                table: "Orders",
                newName: "IX_Orders_AddressId");

            migrationBuilder.RenameIndex(
                name: "IX_City_CountryId",
                table: "Cities",
                newName: "IX_Cities_CountryId");

            migrationBuilder.RenameColumn(
                name: "ParentCategoryId",
                table: "Categories",
                newName: "NumberOfProducts");

            migrationBuilder.RenameIndex(
                name: "IX_CartItem_SkuId",
                table: "CartItems",
                newName: "IX_CartItems_SkuId");

            migrationBuilder.RenameIndex(
                name: "IX_CartItem_CartId",
                table: "CartItems",
                newName: "IX_CartItems_CartId");

            migrationBuilder.RenameIndex(
                name: "IX_Cart_UserId",
                table: "Carts",
                newName: "IX_Carts_UserId");

            migrationBuilder.RenameColumn(
                name: "DeletedBy",
                table: "Addresses",
                newName: "CountryId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_UserId",
                table: "Addresses",
                newName: "IX_Addresses_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Address_CityId",
                table: "Addresses",
                newName: "IX_Addresses_CityId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "WishlistItems",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Wishlists",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "WishlistId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Users",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "MiddleNameAr",
                table: "Users",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "LastNameAr",
                table: "Users",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "FirstNameAr",
                table: "Users",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CartId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "SkuCode",
                table: "Skus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Skus",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Roles",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "RoleName",
                table: "Roles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "ProductVariantOptions",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "ProductVariantOptions",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "ProductVariants",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "ProductVariants",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "ProductVariants",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "ProductImages",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "NameEn",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "Products",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Products",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountAmount",
                table: "Products",
                type: "decimal(8,2)",
                precision: 8,
                scale: 2,
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)",
                oldPrecision: 8,
                oldScale: 2,
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "DefaultPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "DiscountType",
                table: "Products",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Rating",
                table: "Products",
                type: "decimal(3,2)",
                precision: 3,
                scale: 2,
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "OrderStatuses",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "StatusName",
                table: "OrderStatuses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "OrderItems",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "OrderNumber",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Orders",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Countries",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Cities",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Categories",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "CartItems",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Carts",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(10)",
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedAt",
                table: "Addresses",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

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
                columns: new[] { "SkuId", "ProductVariantId", "ProductVariantOptionsId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_Skus",
                table: "Skus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
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

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8320), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8321), "Amman" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8323), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8323), "Zarqa" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8325), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8326), "Irbid" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8327), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8328), "Russeifa" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8329), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8330), "Sahab" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8331), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8332), "As-Salt" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8333), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8334), "Aqaba" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8336), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8336), "Madaba" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8338), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8338), "Jerash" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8340), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8340), "Ma'an" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8342), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8342), "Al-Mafraq" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8344), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8344), "Tafilah" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8346), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8347), "Ajloun" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8348), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8349), "Riyadh" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8350), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8351), "Jeddah" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8352), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8353), "Dubai" });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8358), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8359), "Abu Dhabi" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8289), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8289), "Saudi Arabia" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8291), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8292), "United Arab Emirates" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "Name" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8294), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8295), "Jordan" });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt", "StatusName" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(7956), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(7960), "Pending" });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "StatusName" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(7966), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(7966), "Confirmed" });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt", "StatusName" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(7968), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(7969), "Shipped" });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt", "StatusName" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(7970), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(7971), "Delivered" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt", "RoleName" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8247), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8248), "Admin" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt", "RoleName" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8250), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8251), "Customer" });

            migrationBuilder.CreateIndex(
                name: "IX_SKUProductVariantOptions_ProductVariantId1",
                table: "SKUProductVariantOptions",
                column: "ProductVariantId1");

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CountryId",
                table: "Addresses",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Cities_CityId",
                table: "Addresses",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_Countries_CountryId",
                table: "Addresses",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id");

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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CartItems_Skus_SkuId",
                table: "CartItems",
                column: "SkuId",
                principalTable: "Skus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Skus_SkuId",
                table: "OrderItems",
                column: "SkuId",
                principalTable: "Skus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_Users_UserId",
                table: "Orders",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductImages_Products_ProductId",
                table: "ProductImages",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariantOptions_ProductVariants_ProductVariantId",
                table: "ProductVariantOptions",
                column: "ProductVariantId",
                principalTable: "ProductVariants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ProductVariants_Products_ProductId",
                table: "ProductVariants",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

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
                name: "FK_SKUProductVariantOptions_Skus_SkuId",
                table: "SKUProductVariantOptions",
                column: "SkuId",
                principalTable: "Skus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Skus_Products_ProductId",
                table: "Skus",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItems_Skus_SkuId",
                table: "WishlistItems",
                column: "SkuId",
                principalTable: "Skus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_WishlistItems_Wishlists_WishlistId",
                table: "WishlistItems",
                column: "WishlistId",
                principalTable: "Wishlists",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlists_Users_UserId",
                table: "Wishlists",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
