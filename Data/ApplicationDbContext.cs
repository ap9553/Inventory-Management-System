using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InventoryManagementSystem.Models;

namespace InventoryManagementSystem.Data
{
    /// <summary>
    /// Main database context for the Inventory Management System
    /// Inherits from IdentityDbContext for authentication support
    /// </summary>
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // DbSets for all entities
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<PurchaseItem> PurchaseItems { get; set; }
        public DbSet<Sale> Sales { get; set; }
        public DbSet<SaleItem> SaleItems { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<StockMovement> StockMovements { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Configure global query filter for soft delete
            builder.Entity<Product>().HasQueryFilter(p => !p.IsDeleted);
            builder.Entity<Category>().HasQueryFilter(c => !c.IsDeleted);
            builder.Entity<Supplier>().HasQueryFilter(s => !s.IsDeleted);
            builder.Entity<Customer>().HasQueryFilter(c => !c.IsDeleted);
            builder.Entity<Purchase>().HasQueryFilter(p => !p.IsDeleted);
            builder.Entity<Sale>().HasQueryFilter(s => !s.IsDeleted);
            builder.Entity<Employee>().HasQueryFilter(e => !e.IsDeleted);

            // Configure decimal precision for monetary values
            builder.Entity<Product>()
                .Property(p => p.PurchasePrice)
                .HasColumnType("decimal(18,2)");

            builder.Entity<Product>()
                .Property(p => p.SellingPrice)
                .HasColumnType("decimal(18,2)");

            builder.Entity<PurchaseItem>()
                .Property(pi => pi.UnitPrice)
                .HasColumnType("decimal(18,2)");

            builder.Entity<PurchaseItem>()
                .Property(pi => pi.TotalPrice)
                .HasColumnType("decimal(18,2)");

            builder.Entity<SaleItem>()
                .Property(si => si.UnitPrice)
                .HasColumnType("decimal(18,2)");

            builder.Entity<SaleItem>()
                .Property(si => si.TotalPrice)
                .HasColumnType("decimal(18,2)");

            builder.Entity<Purchase>()
                .Property(p => p.TotalAmount)
                .HasColumnType("decimal(18,2)");

            builder.Entity<Sale>()
                .Property(s => s.TotalAmount)
                .HasColumnType("decimal(18,2)");

            builder.Entity<Sale>()
                .Property(s => s.DiscountAmount)
                .HasColumnType("decimal(18,2)");

            builder.Entity<Sale>()
                .Property(s => s.NetAmount)
                .HasColumnType("decimal(18,2)");

            // Configure relationships
            builder.Entity<Product>()
                .HasOne(p => p.Category)
                .WithMany(c => c.Products)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<Product>()
                .HasOne(p => p.Supplier)
                .WithMany(s => s.Products)
                .HasForeignKey(p => p.SupplierId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<PurchaseItem>()
                .HasOne(pi => pi.Purchase)
                .WithMany(p => p.PurchaseItems)
                .HasForeignKey(pi => pi.PurchaseId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<PurchaseItem>()
                .HasOne(pi => pi.Product)
                .WithMany()
                .HasForeignKey(pi => pi.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<SaleItem>()
                .HasOne(si => si.Sale)
                .WithMany(s => s.SaleItems)
                .HasForeignKey(si => si.SaleId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.Entity<SaleItem>()
                .HasOne(si => si.Product)
                .WithMany()
                .HasForeignKey(si => si.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<StockMovement>()
                .HasOne(sm => sm.Product)
                .WithMany(p => p.StockMovements)
                .HasForeignKey(sm => sm.ProductId)
                .OnDelete(DeleteBehavior.Restrict);

            // Configure unique constraints
            builder.Entity<Category>()
                .HasIndex(c => c.Name)
                .IsUnique();

            builder.Entity<Product>()
                .HasIndex(p => p.SKU)
                .IsUnique();

            builder.Entity<Product>()
                .HasIndex(p => p.Barcode)
                .IsUnique();

            // Seed demo data for development/testing
            var now = DateTime.UtcNow;

            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Accessories", Description = "Computer accessories", CreatedAt = now, UpdatedAt = now, IsDeleted = false },
                new Category { Id = 2, Name = "Displays", Description = "Monitors and displays", CreatedAt = now, UpdatedAt = now, IsDeleted = false },
                new Category { Id = 3, Name = "Peripherals", Description = "Peripherals and webcams", CreatedAt = now, UpdatedAt = now, IsDeleted = false }
            );

            builder.Entity<Supplier>().HasData(
                new Supplier { Id = 1, CompanyName = "Acme Supplies", ContactPerson = "Alice", Phone = "555-0100", Email = "alice@acme.com", CreatedAt = now, UpdatedAt = now, IsDeleted = false },
                new Supplier { Id = 2, CompanyName = "ViewTech", ContactPerson = "Bob", Phone = "555-0200", Email = "bob@viewtech.com", CreatedAt = now, UpdatedAt = now, IsDeleted = false }
            );

            builder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Wireless Mouse", SKU = "PRD-00123", Barcode = "BC-00123", CategoryId = 1, SupplierId = 1, PurchasePrice = 10.00m, SellingPrice = 18.00m, Quantity = 120, ReorderLevel = 50, CreatedAt = now, UpdatedAt = now, IsDeleted = false },
                new Product { Id = 2, Name = "Mechanical Keyboard", SKU = "PRD-00124", Barcode = "BC-00124", CategoryId = 1, SupplierId = 1, PurchasePrice = 25.00m, SellingPrice = 45.00m, Quantity = 45, ReorderLevel = 30, CreatedAt = now, UpdatedAt = now, IsDeleted = false },
                new Product { Id = 3, Name = "27\" Monitor", SKU = "PRD-00125", Barcode = "BC-00125", CategoryId = 2, SupplierId = 2, PurchasePrice = 150.00m, SellingPrice = 220.00m, Quantity = 22, ReorderLevel = 10, CreatedAt = now, UpdatedAt = now, IsDeleted = false },
                new Product { Id = 4, Name = "USB-C Hub", SKU = "PRD-00126", Barcode = "BC-00126", CategoryId = 1, SupplierId = 1, PurchasePrice = 8.00m, SellingPrice = 15.00m, Quantity = 8, ReorderLevel = 15, CreatedAt = now, UpdatedAt = now, IsDeleted = false },
                new Product { Id = 5, Name = "Webcam HD", SKU = "PRD-00127", Barcode = "BC-00127", CategoryId = 3, SupplierId = 2, PurchasePrice = 40.00m, SellingPrice = 70.00m, Quantity = 60, ReorderLevel = 20, CreatedAt = now, UpdatedAt = now, IsDeleted = false }
            );

            builder.Entity<Customer>().HasData(
                new Customer { Id = 1, Name = "Global Tech", Phone = "555-1001", Email = "sales@globaltech.com", CreatedAt = now, UpdatedAt = now, IsDeleted = false },
                new Customer { Id = 2, Name = "OfficeMart", Phone = "555-1002", Email = "orders@officemart.com", CreatedAt = now, UpdatedAt = now, IsDeleted = false },
                new Customer { Id = 3, Name = "AlphaCorp", Phone = "555-1003", Email = "procurement@alphacorp.com", CreatedAt = now, UpdatedAt = now, IsDeleted = false }
            );

            // Purchases
            builder.Entity<Purchase>().HasData(
                new Purchase { Id = 1, PurchaseNumber = "PO-2026-001", PurchaseDate = now.AddDays(-10), SupplierId = 1, TotalAmount = 1200.00m, Status = "Completed", CreatedAt = now.AddDays(-10), UpdatedAt = now.AddDays(-10), IsDeleted = false }
            );

            builder.Entity<PurchaseItem>().HasData(
                new PurchaseItem { Id = 1, PurchaseId = 1, ProductId = 1, Quantity = 200, UnitPrice = 9.50m, TotalPrice = 1900.00m, CreatedAt = now.AddDays(-10), UpdatedAt = now.AddDays(-10), IsDeleted = false }
            );

            // Sales
            builder.Entity<Sale>().HasData(
                new Sale { Id = 1, InvoiceNumber = "INV-2026-001", SaleDate = now.AddDays(-5), CustomerId = 1, TotalAmount = 1230.00m, DiscountAmount = 0m, NetAmount = 1230.00m, PaymentMethod = "Card", Status = "Completed", CreatedAt = now.AddDays(-5), UpdatedAt = now.AddDays(-5), IsDeleted = false }
            );

            builder.Entity<SaleItem>().HasData(
                new SaleItem { Id = 1, SaleId = 1, ProductId = 3, Quantity = 1, UnitPrice = 1230.00m, TotalPrice = 1230.00m, CreatedAt = now.AddDays(-5), UpdatedAt = now.AddDays(-5), IsDeleted = false }
            );
        }

        /// <summary>
        /// Override SaveChanges to automatically set audit fields
        /// </summary>
        public override int SaveChanges()
        {
            UpdateAuditFields();
            return base.SaveChanges();
        }

        /// <summary>
        /// Override SaveChangesAsync to automatically set audit fields
        /// </summary>
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            UpdateAuditFields();
            return base.SaveChangesAsync(cancellationToken);
        }

        /// <summary>
        /// Automatically set CreatedAt and UpdatedAt timestamps
        /// </summary>
        private void UpdateAuditFields()
        {
            var entries = ChangeTracker.Entries()
                .Where(e => e.Entity is BaseEntity && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entry in entries)
            {
                var entity = (BaseEntity)entry.Entity;

                if (entry.State == EntityState.Added)
                {
                    entity.CreatedAt = DateTime.Now;
                }

                entity.UpdatedAt = DateTime.Now;
            }
        }
    }
}
