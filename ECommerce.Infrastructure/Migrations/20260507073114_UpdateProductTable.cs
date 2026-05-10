using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ECommerce.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DefaultPrice",
                table: "Products",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8320), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8321) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8323), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8323) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8325), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8326) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8327), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8328) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8329), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8330) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8331), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8332) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8333), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8334) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8336), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8336) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8338), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8338) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8340), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8340) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8342), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8342) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8344), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8344) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8346), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8347) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8348), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8349) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8350), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8351) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8352), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8353) });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8358), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8359) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8289), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8289) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8291), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8292) });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8294), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8295) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(7956), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(7960) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(7966), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(7966) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(7968), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(7969) });

            migrationBuilder.UpdateData(
                table: "OrderStatuses",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(7970), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8247), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8248) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifiedAt" },
                values: new object[] { new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8250), new DateTime(2026, 5, 7, 7, 31, 14, 324, DateTimeKind.Utc).AddTicks(8251) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefaultPrice",
                table: "Products");

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
        }
    }
}
