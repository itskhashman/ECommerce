using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserRelationsAndNameArOptional : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Address_UserId",
                table: "Address");

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "CartId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "WishlistId",
                table: "User");

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "ProductVariant",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Address_UserId",
                table: "Address",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Address_UserId",
                table: "Address");

            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CartId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WishlistId",
                table: "User",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "NameAr",
                table: "ProductVariant",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.CreateIndex(
                name: "IX_Address_UserId",
                table: "Address",
                column: "UserId",
                unique: true);
        }
    }
}
