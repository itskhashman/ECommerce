using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateLookupsTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderStatus_OrderStatusId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_CountryCode_CountryCodeId",
                table: "Users");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Role_RoleId",
                table: "Users");

            migrationBuilder.DropTable(
                name: "CountryCode");

            migrationBuilder.DropIndex(
                name: "IX_Users_CountryCodeId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Role",
                table: "Role");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderStatus",
                table: "OrderStatus");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Country",
                table: "Country");

            migrationBuilder.DropPrimaryKey(
                name: "PK_City",
                table: "City");

            migrationBuilder.DropColumn(
                name: "CountryCodeId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PriceUnit",
                table: "Skus");

            migrationBuilder.DropColumn(
                name: "DefaultPrice",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "IsoCode",
                table: "Country");

            migrationBuilder.RenameTable(
                name: "Role",
                newName: "Roles");

            migrationBuilder.RenameTable(
                name: "OrderStatus",
                newName: "OrderStatuses");

            migrationBuilder.RenameTable(
                name: "Country",
                newName: "Countries");

            migrationBuilder.RenameTable(
                name: "City",
                newName: "Cities");

            migrationBuilder.RenameColumn(
                name: "EnMiddleName",
                table: "Users",
                newName: "MiddleNameEn");

            migrationBuilder.RenameColumn(
                name: "EnLastName",
                table: "Users",
                newName: "LastNameEn");

            migrationBuilder.RenameColumn(
                name: "EnFirstName",
                table: "Users",
                newName: "FirstNameEn");

            migrationBuilder.RenameColumn(
                name: "ArMiddleName",
                table: "Users",
                newName: "MiddleNameAr");

            migrationBuilder.RenameColumn(
                name: "ArLastName",
                table: "Users",
                newName: "LastNameAr");

            migrationBuilder.RenameColumn(
                name: "ArFirstName",
                table: "Users",
                newName: "FirstNameAr");

            migrationBuilder.RenameColumn(
                name: "EnName",
                table: "ProductVariants",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "ArName",
                table: "ProductVariants",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "EnName",
                table: "ProductVariantOptions",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "ArName",
                table: "ProductVariantOptions",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "Stock",
                table: "Products",
                newName: "TotalStock");

            migrationBuilder.RenameColumn(
                name: "EnName",
                table: "Products",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "EnDescription",
                table: "Products",
                newName: "DescriptionEn");

            migrationBuilder.RenameColumn(
                name: "ArName",
                table: "Products",
                newName: "NameAr");

            migrationBuilder.RenameColumn(
                name: "ArDescription",
                table: "Products",
                newName: "DescriptionAr");

            migrationBuilder.RenameColumn(
                name: "EnName",
                table: "Categories",
                newName: "NameEn");

            migrationBuilder.RenameColumn(
                name: "ArName",
                table: "Categories",
                newName: "NameAr");

            migrationBuilder.RenameIndex(
                name: "IX_City_CountryId",
                table: "Cities",
                newName: "IX_Cities_CountryId");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Stock",
                table: "Skus",
                type: "int",
                maxLength: 10,
                nullable: false,
                defaultValue: 0);

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

            migrationBuilder.AddColumn<int>(
                name: "OrderItemNumber",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NumberOfProducts",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Addresses",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Roles",
                table: "Roles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderStatuses",
                table: "OrderStatuses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Countries",
                table: "Countries",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cities",
                table: "Cities",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8532), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8533) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8537), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8538) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8540), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8541) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8543), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8544) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8546), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8547) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8549), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8549) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8553), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8553) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8555), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8556) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8558), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8559) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8561), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8562) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8564), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8564) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8567), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8567) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8569), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8570) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8572), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8575), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8575) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8578), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8578) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8580), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8580) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8487), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8487) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8490), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8493), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8494) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(7888), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(7891) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(7899), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(7900) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(7902), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(7903) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(7905), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(7905) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8435), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8436) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8440), new DateTime(2026, 5, 7, 7, 27, 8, 894, DateTimeKind.Utc).AddTicks(8441) });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses",
                column: "CityId");

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
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderStatuses_OrderStatusId",
                table: "Orders",
                column: "OrderStatusId",
                principalTable: "OrderStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Roles",
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
                name: "FK_Addresses_Countries_CountryId",
                table: "Addresses");

            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.DropForeignKey(
                name: "FK_Orders_OrderStatuses_OrderStatusId",
                table: "Orders");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_Roles_RoleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CityId",
                table: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Addresses_CountryId",
                table: "Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Roles",
                table: "Roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderStatuses",
                table: "OrderStatuses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Countries",
                table: "Countries");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cities",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Skus");

            migrationBuilder.DropColumn(
                name: "OrderItemNumber",
                table: "OrderItems");

            migrationBuilder.DropColumn(
                name: "NumberOfProducts",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Addresses");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Roles",
                newName: "Role");

            migrationBuilder.RenameTable(
                name: "OrderStatuses",
                newName: "OrderStatus");

            migrationBuilder.RenameTable(
                name: "Countries",
                newName: "Country");

            migrationBuilder.RenameTable(
                name: "Cities",
                newName: "City");

            migrationBuilder.RenameColumn(
                name: "MiddleNameEn",
                table: "Users",
                newName: "EnMiddleName");

            migrationBuilder.RenameColumn(
                name: "MiddleNameAr",
                table: "Users",
                newName: "ArMiddleName");

            migrationBuilder.RenameColumn(
                name: "LastNameEn",
                table: "Users",
                newName: "EnLastName");

            migrationBuilder.RenameColumn(
                name: "LastNameAr",
                table: "Users",
                newName: "ArLastName");

            migrationBuilder.RenameColumn(
                name: "FirstNameEn",
                table: "Users",
                newName: "EnFirstName");

            migrationBuilder.RenameColumn(
                name: "FirstNameAr",
                table: "Users",
                newName: "ArFirstName");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "ProductVariants",
                newName: "EnName");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "ProductVariants",
                newName: "ArName");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "ProductVariantOptions",
                newName: "EnName");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "ProductVariantOptions",
                newName: "ArName");

            migrationBuilder.RenameColumn(
                name: "TotalStock",
                table: "Products",
                newName: "Stock");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "Products",
                newName: "EnName");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "Products",
                newName: "ArName");

            migrationBuilder.RenameColumn(
                name: "DescriptionEn",
                table: "Products",
                newName: "EnDescription");

            migrationBuilder.RenameColumn(
                name: "DescriptionAr",
                table: "Products",
                newName: "ArDescription");

            migrationBuilder.RenameColumn(
                name: "NameEn",
                table: "Categories",
                newName: "EnName");

            migrationBuilder.RenameColumn(
                name: "NameAr",
                table: "Categories",
                newName: "ArName");

            migrationBuilder.RenameIndex(
                name: "IX_Cities_CountryId",
                table: "City",
                newName: "IX_City_CountryId");

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CountryCodeId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "PriceUnit",
                table: "Skus",
                type: "nvarchar(10)",
                maxLength: 10,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<decimal>(
                name: "DiscountAmount",
                table: "Products",
                type: "decimal(8,2)",
                precision: 8,
                scale: 2,
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(8,2)",
                oldPrecision: 8,
                oldScale: 2);

            migrationBuilder.AddColumn<decimal>(
                name: "DefaultPrice",
                table: "Products",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "IsoCode",
                table: "Country",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Role",
                table: "Role",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderStatus",
                table: "OrderStatus",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Country",
                table: "Country",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_City",
                table: "City",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "CountryCode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryCode", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8397), new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8398) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8401), new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8402) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8404), new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8405) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8475), new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8476) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8478), new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8479) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8481), new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8481) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8483), new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8484) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8486), new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8486) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8488), new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8489) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8490), new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8491) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8492), new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8493) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8494), new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8495) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8496), new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8497) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8499), new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8499) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8501), new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8502) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8503), new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8504) });

            migrationBuilder.UpdateData(
                table: "City",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8505), new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8506) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "IsoCode", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8272), "SA", new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8273) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "IsoCode", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8281), "AE", new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8281) });

            migrationBuilder.UpdateData(
                table: "Country",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "IsoCode", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8284), "JO", new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8285) });

            migrationBuilder.InsertData(
                table: "CountryCode",
                columns: new[] { "Id", "Code", "CreatedAt", "CreatedBy", "IsDeleted", "ModifiedAt", "ModifiedBy" },
                values: new object[,]
                {
                    { 1, "+966", new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6199), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6200), 0 },
                    { 2, "+962", new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6202), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6202), 0 },
                    { 3, "+971", new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6204), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6204), 0 },
                    { 4, "+20", new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6206), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6206), 0 },
                    { 5, "+1", new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6208), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6208), 0 },
                    { 6, "+44", new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6209), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6210), 0 }
                });

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(5876), new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(5879) });

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(5886), new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(5887) });

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(5889), new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(5890) });

            migrationBuilder.UpdateData(
                table: "OrderStatus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(5891), new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(5892) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6251), new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6252) });

            migrationBuilder.UpdateData(
                table: "Role",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6254), new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6254) });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryCodeId",
                table: "Users",
                column: "CountryCodeId");

            migrationBuilder.AddForeignKey(
                name: "FK_City_Country_CountryId",
                table: "City",
                column: "CountryId",
                principalTable: "Country",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Orders_OrderStatus_OrderStatusId",
                table: "Orders",
                column: "OrderStatusId",
                principalTable: "OrderStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_CountryCode_CountryCodeId",
                table: "Users",
                column: "CountryCodeId",
                principalTable: "CountryCode",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Role_RoleId",
                table: "Users",
                column: "RoleId",
                principalTable: "Role",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
