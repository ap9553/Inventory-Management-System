using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class InitialInventoryTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364), new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364), new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364), new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364), new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364), new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364), new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364), new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364), new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364), new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364), new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364), new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 19, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364), new DateTime(2026, 6, 19, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PurchaseDate", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 19, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364), new DateTime(2026, 6, 19, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364), new DateTime(2026, 6, 19, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "SaleItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 24, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364), new DateTime(2026, 6, 24, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "SaleDate", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 24, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364), new DateTime(2026, 6, 24, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364), new DateTime(2026, 6, 24, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364), new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364), new DateTime(2026, 6, 29, 17, 16, 51, 916, DateTimeKind.Utc).AddTicks(8364) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 19, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), new DateTime(2026, 6, 19, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "PurchaseDate", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 19, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), new DateTime(2026, 6, 19, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), new DateTime(2026, 6, 19, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "SaleItems",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 24, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), new DateTime(2026, 6, 24, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "SaleDate", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 24, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), new DateTime(2026, 6, 24, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), new DateTime(2026, 6, 24, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });
        }
    }
}
