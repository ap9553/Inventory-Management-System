# Inventory Management System

Professional inventory management web application built with ASP.NET Core MVC (.NET 8), Entity Framework Core and SQL Server. Designed as an enterprise-ready portfolio project demonstrating clean architecture patterns, secure authentication, and a modern administrative dashboard.

---

## Project overview

This project is an Inventory Management System that models core domain entities (products, suppliers, purchases, sales, customers, employees, and stock movements) and provides a secure, role-based web application foundation. The UI includes a modern Bootstrap 5 dashboard (Chart.js + Font Awesome). The dashboard currently displays static demo values in the view; the project includes seeded demo data in the database and is ready to be wired to live queries.

---

## Business use case

Small and medium retail or wholesale businesses need a single system to track inventory levels, manage purchase orders and supplier relationships, process sales invoices, and produce audit-friendly inventory history. This project provides a foundational platform to implement those business processes with extensibility for reporting and alerts.

---

## Key features (Completed)

- ASP.NET Core MVC application targeting .NET 8
- Entity Framework Core integration with SQL Server (LocalDB)
- ApplicationDbContext with audit fields (CreatedAt, UpdatedAt) and soft-delete (IsDeleted)
- Domain model implemented for Products, Categories, Suppliers, Customers, Purchases, PurchaseItems, Sales, SaleItems, StockMovements, Employees
- ASP.NET Core Identity for authentication and role-based authorization
- Role and default admin user seeding at startup
- Dashboard UI: Bootstrap 5 + Chart.js + Font Awesome (presentational, uses static/dummy data in view)
- AccountController: Login, Register (Admin-only), Logout, AccessDenied
- Demo seed data added via EF Core migrations (categories, suppliers, products, customers, a purchase and a sale)

## Key features (Planned)

- Wire dashboard to live database metrics (counts, recent lists, chart series)
- CRUD modules for Products, Categories, Suppliers, Customers (with validation and image upload)
- Purchase workflow that updates inventory and creates StockMovement entries
- Sales workflow with inventory checks to prevent overselling
- Advanced reporting and exports (Excel/PDF)
- Barcode generation and low-stock alerting
- Repository/Service layers and automated tests

---

## Tech stack

- .NET 8 (ASP.NET Core MVC)
- C#
- Entity Framework Core 8
- SQL Server (LocalDB for development)
- ASP.NET Core Identity
- Bootstrap 5, Font Awesome, Chart.js

---

## Tools and libraries

Core NuGet packages (see `InventoryManagementSystem.csproj`):

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Tools
- Microsoft.AspNetCore.Identity.EntityFrameworkCore
- Microsoft.AspNetCore.Identity.UI
- Microsoft.VisualStudio.Web.CodeGeneration.Design

Front-end libraries loaded via CDN in views:
- Bootstrap 5 (project template includes local copies)
- Font Awesome (icons)
- Chart.js (dashboard charts)

---

## Architecture

The application follows a layered approach to enable maintainability and testability:

- Presentation: MVC Controllers + Razor Views (ViewModels for auth pages)
- Data: Entity Framework Core (`ApplicationDbContext`) with models as POCOs inheriting from `BaseEntity`
- Security: ASP.NET Core Identity (IdentityUser/IdentityRole) integrated with EF Core
- Future layers: Repository and Service folders exist as placeholders for business logic abstraction

Key patterns implemented:
- Soft delete via `IsDeleted` and global query filters
- Auditing via `BaseEntity` and `UpdateAuditFields()` on `SaveChanges`
- Seed data via `HasData()` and EF migrations

---

## Folder structure (important folders)

```
Controllers/
Models/
ViewModels/
Views/
Data/ (ApplicationDbContext)
Migrations/
wwwroot/ (css, js, images)
Interfaces/ (placeholder)
Repositories/ (placeholder)
Services/ (placeholder)
```

---

## Database design summary

- Core tables: Products, Categories, Suppliers, Customers, Purchases, PurchaseItems, Sales, SaleItems, StockMovements, Employees
- Relationships:
  - Product -> Category (many-to-one)
  - Product -> Supplier (many-to-one)
  - Purchase -> PurchaseItems (one-to-many)
  - Sale -> SaleItems (one-to-many)
  - StockMovement -> Product (many-to-one)
- Monetary fields use `decimal(18,2)`
- Unique indices: Category.Name, Product.SKU, Product.Barcode
- Soft delete (IsDeleted) with global query filters on applicable entities
- Audit fields: CreatedAt, UpdatedAt on every entity that inherits BaseEntity

---

## Authentication and roles

- ASP.NET Core Identity provides authentication and role management.
- Roles seeded on startup: `Admin`, `Manager`, `Employee`.
- Default admin user seeded at startup (development only).
- Register action in `AccountController` is restricted to `Admin` role.

---

## Business logic implemented so far

- Domain model and relationships with EF Core configuration
- Soft-delete and audit handling in `ApplicationDbContext`
- Authentication flows: login, logout, admin-only registration
- Seed demo data for development via migrations
- Dashboard UI (static/dummy data)

---

## How data flows

1. User interacts with a Razor view (form submission or navigation).
2. Controller action receives the request (e.g., `AccountController.Login`).
3. Controller uses `UserManager`/`SignInManager` or `ApplicationDbContext` to perform operations.
4. `ApplicationDbContext` maps changes to SQL via EF Core and persists to SQL Server LocalDB.

Planned improvement: introduce Service and Repository layers between Controllers and DbContext for separation of concerns and testability.

---

## How to run the project locally

Prerequisites:
- .NET 8 SDK
- SQL Server Express / LocalDB (LocalDB typically included with Visual Studio)

Steps:

1. Clone the repository:

```bash
git clone <repo-url>
cd InventoryManagementSystem
```

2. Restore and build:

```bash
dotnet restore
dotnet build
```

3. Apply migrations and update the database (see next section), or simply run the app which runs `Database.Migrate()` on startup:

```bash
dotnet run
```

4. Open the app at the URL printed in the console (typically https://localhost:5001).

---

## Create / update SQL Server database using migrations

Install EF tools if needed:

```bash
dotnet tool install --global dotnet-ef
```

To create a migration after model changes:

```bash
dotnet ef migrations add NameOfMigration
```

To apply migrations to the database:

```bash
dotnet ef database update
```

The application also calls `context.Database.Migrate()` during startup to automatically apply pending migrations.

---

## Default admin credentials (development)

> These are seeded for development only. Remove or change them for production.

- Email: `admin@inventory.com`
- Password: `Admin@123`

---

## Screenshots

Place screenshots in `docs/` and reference them here. Example placeholders:

- `docs/screenshot-dashboard.png` — Dashboard overview
- `docs/screenshot-login.png` — Login page
- `docs/screenshot-register.png` — Register page (Admin-only)

---

## Future enhancements (short-term roadmap)

- Replace dashboard dummy data with real queries via a `DashboardController` and `DashboardViewModel`.
- Implement full CRUD modules (Products, Categories, Suppliers, Customers).
- Implement purchase/sales workflows that update inventory and record stock movements.
- Add reporting, exports (Excel/PDF), barcode generation and low stock alerts.
- Add Repository/Service layers and automated tests.

---

## What I learned

- Structuring an enterprise-grade ASP.NET Core MVC project with EF Core and Identity
- Implementing soft-delete and audit patterns with EF Core change tracking
- Seeding demo data through migrations for developer UX
- Building a modern admin dashboard UI with Bootstrap 5 and Chart.js
- Configuring Identity and seeding roles/users at startup

---

If you'd like, I can now:

- Draft a concise GitHub landing README (short intro + screenshots) optimized for recruiters, or
- Wire the dashboard to live data (DashboardController + DashboardViewModel + Repository).

Feedback welcome — tell me which next step you prefer.
