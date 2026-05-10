using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ECommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddLookupsTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountryCode",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Orders");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "Wishlists",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Wishlists",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "WishlistItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "WishlistItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "CountryCodeId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "Skus",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Skus",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "ProductVariants",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "ProductVariants",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "ProductVariantOptions",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "ProductVariantOptions",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "ProductImages",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "ProductImages",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "OrderStatusId",
                table: "Orders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "OrderItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "OrderItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Categories",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "Carts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Carts",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "CartItems",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "CartItems",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "ModifiedBy",
                table: "Addresses",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CreatedBy",
                table: "Addresses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsoCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CountryCode",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryCode", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<int>(type: "int", nullable: false),
                    ModifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                    table.ForeignKey(
                        name: "FK_City_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "IsoCode", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8272), 0, false, "SA", new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8273), 0, "Saudi Arabia" },
                    { 2, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8281), 0, false, "AE", new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8281), 0, "United Arab Emirates" },
                    { 3, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8284), 0, false, "JO", new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8285), 0, "Jordan" }
                });

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

            migrationBuilder.InsertData(
                table: "OrderStatus",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ModifiedAt", "ModifiedBy", "StatusName" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(5876), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(5879), 0, "Pending" },
                    { 2, new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(5886), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(5887), 0, "Confirmed" },
                    { 3, new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(5889), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(5890), 0, "Shipped" },
                    { 4, new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(5891), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(5892), 0, "Delivered" }
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "ModifiedAt", "ModifiedBy", "RoleName" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6251), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6252), 0, "Admin" },
                    { 2, new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6254), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 536, DateTimeKind.Utc).AddTicks(6254), 0, "Customer" }
                });

            migrationBuilder.InsertData(
                table: "City",
                columns: new[] { "Id", "CountryId", "CreatedAt", "CreatedBy", "IsDeleted", "ModifiedAt", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8397), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8398), 0, "Amman" },
                    { 2, 3, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8401), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8402), 0, "Zarqa" },
                    { 3, 3, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8404), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8405), 0, "Irbid" },
                    { 4, 3, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8475), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8476), 0, "Russeifa" },
                    { 5, 3, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8478), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8479), 0, "Sahab" },
                    { 6, 3, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8481), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8481), 0, "As-Salt" },
                    { 7, 3, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8483), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8484), 0, "Aqaba" },
                    { 8, 3, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8486), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8486), 0, "Madaba" },
                    { 9, 3, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8488), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8489), 0, "Jerash" },
                    { 10, 3, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8490), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8491), 0, "Ma'an" },
                    { 11, 3, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8492), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8493), 0, "Al-Mafraq" },
                    { 12, 3, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8494), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8495), 0, "Tafilah" },
                    { 13, 3, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8496), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8497), 0, "Ajloun" },
                    { 14, 1, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8499), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8499), 0, "Riyadh" },
                    { 15, 1, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8501), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8502), 0, "Jeddah" },
                    { 16, 2, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8503), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8504), 0, "Dubai" },
                    { 17, 2, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8505), 0, false, new DateTime(2026, 5, 6, 12, 29, 2, 542, DateTimeKind.Utc).AddTicks(8506), 0, "Abu Dhabi" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Users_CountryCodeId",
                table: "Users",
                column: "CountryCodeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderStatusId",
                table: "Orders",
                column: "OrderStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_City_CountryId",
                table: "City",
                column: "CountryId");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                name: "City");

            migrationBuilder.DropTable(
                name: "CountryCode");

            migrationBuilder.DropTable(
                name: "OrderStatus");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropIndex(
                name: "IX_Users_CountryCodeId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_RoleId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Orders_OrderStatusId",
                table: "Orders");

            migrationBuilder.DropColumn(
                name: "CountryCodeId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "OrderStatusId",
                table: "Orders");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Wishlists",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Wishlists",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "WishlistItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "WishlistItems",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "CountryCode",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "Users",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Skus",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Skus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "ProductVariants",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "ProductVariants",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "ProductVariantOptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "ProductVariantOptions",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "ProductImages",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Orders",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Orders",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "OrderItems",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Carts",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "CartItems",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedBy",
                table: "Addresses",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }
    }
}
