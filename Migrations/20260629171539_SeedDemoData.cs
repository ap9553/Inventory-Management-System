using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InventoryManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class SeedDemoData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "SaleItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "SaleItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "SaleItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "PurchaseItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "PurchaseItems",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "PurchaseItems",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedAt", "Description", "IsDeleted", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), "Computer accessories", false, "Accessories", new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) },
                    { 2, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), "Monitors and displays", false, "Displays", new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) },
                    { 3, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), "Peripherals and webcams", false, "Peripherals", new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Address", "City", "CreatedAt", "Email", "IsDeleted", "LoyaltyPoints", "Name", "Phone", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), "sales@globaltech.com", false, 0, "Global Tech", "555-1001", new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) },
                    { 2, null, null, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), "orders@officemart.com", false, 0, "OfficeMart", "555-1002", new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) },
                    { 3, null, null, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), "procurement@alphacorp.com", false, 0, "AlphaCorp", "555-1003", new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "Id", "Address", "City", "CompanyName", "ContactPerson", "Country", "CreatedAt", "Email", "IsDeleted", "Phone", "PostalCode", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, null, null, "Acme Supplies", "Alice", null, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), "alice@acme.com", false, "555-0100", null, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) },
                    { 2, null, null, "ViewTech", "Bob", null, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), "bob@viewtech.com", false, "555-0200", null, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Barcode", "CategoryId", "CreatedAt", "Description", "ImagePath", "IsActive", "IsDeleted", "Name", "PurchasePrice", "Quantity", "ReorderLevel", "SKU", "SellingPrice", "SupplierId", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, "BC-00123", 1, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), null, null, true, false, "Wireless Mouse", 10.00m, 120, 50, "PRD-00123", 18.00m, 1, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) },
                    { 2, "BC-00124", 1, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), null, null, true, false, "Mechanical Keyboard", 25.00m, 45, 30, "PRD-00124", 45.00m, 1, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) },
                    { 3, "BC-00125", 2, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), null, null, true, false, "27\" Monitor", 150.00m, 22, 10, "PRD-00125", 220.00m, 2, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) },
                    { 4, "BC-00126", 1, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), null, null, true, false, "USB-C Hub", 8.00m, 8, 15, "PRD-00126", 15.00m, 1, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) },
                    { 5, "BC-00127", 3, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), null, null, true, false, "Webcam HD", 40.00m, 60, 20, "PRD-00127", 70.00m, 2, new DateTime(2026, 6, 29, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) }
                });

            migrationBuilder.InsertData(
                table: "Purchases",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "Notes", "PurchaseDate", "PurchaseNumber", "Status", "SupplierId", "TotalAmount", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2026, 6, 19, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), null, false, null, new DateTime(2026, 6, 19, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), "PO-2026-001", "Completed", 1, 1200.00m, new DateTime(2026, 6, 19, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.InsertData(
                table: "Sales",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "CustomerId", "DiscountAmount", "InvoiceNumber", "IsDeleted", "NetAmount", "Notes", "PaymentMethod", "SaleDate", "Status", "TotalAmount", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2026, 6, 24, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), null, 1, 0m, "INV-2026-001", false, 1230.00m, null, "Card", new DateTime(2026, 6, 24, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), "Completed", 1230.00m, new DateTime(2026, 6, 24, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.InsertData(
                table: "PurchaseItems",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ProductId", "PurchaseId", "Quantity", "TotalPrice", "UnitPrice", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2026, 6, 19, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), false, 1, 1, 200, 1900.00m, 9.50m, new DateTime(2026, 6, 19, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });

            migrationBuilder.InsertData(
                table: "SaleItems",
                columns: new[] { "Id", "CreatedAt", "IsDeleted", "ProductId", "Quantity", "SaleId", "TotalPrice", "UnitPrice", "UpdatedAt" },
                values: new object[] { 1, new DateTime(2026, 6, 24, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759), false, 3, 1, 1, 1230.00m, 1230.00m, new DateTime(2026, 6, 24, 17, 15, 38, 942, DateTimeKind.Utc).AddTicks(8759) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PurchaseItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "SaleItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Purchases",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sales",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "SaleItems");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "SaleItems");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "SaleItems");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "PurchaseItems");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "PurchaseItems");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "PurchaseItems");

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CanManageCustomers = table.Column<bool>(type: "bit", nullable: false),
                    CanManageProducts = table.Column<bool>(type: "bit", nullable: false),
                    CanManagePurchases = table.Column<bool>(type: "bit", nullable: false),
                    CanManageSales = table.Column<bool>(type: "bit", nullable: false),
                    CanManageSuppliers = table.Column<bool>(type: "bit", nullable: false),
                    CanManageUsers = table.Column<bool>(type: "bit", nullable: false),
                    CanViewReports = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });
        }
    }
}
