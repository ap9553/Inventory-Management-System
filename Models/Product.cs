using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models
{
    /// <summary>
    /// Product entity representing inventory items
    /// </summary>
    public class Product : BaseEntity
    {
        [Required(ErrorMessage = "Product name is required")]
        [StringLength(200, ErrorMessage = "Product name cannot exceed 200 characters")]
        [Display(Name = "Product Name")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "SKU is required")]
        [StringLength(50, ErrorMessage = "SKU cannot exceed 50 characters")]
        [Display(Name = "SKU")]
        public string SKU { get; set; } = string.Empty;

        [StringLength(50, ErrorMessage = "Barcode cannot exceed 50 characters")]
        [Display(Name = "Barcode")]
        public string? Barcode { get; set; }

        [StringLength(1000, ErrorMessage = "Description cannot exceed 1000 characters")]
        [Display(Name = "Description")]
        public string? Description { get; set; }

        [Required(ErrorMessage = "Category is required")]
        [Display(Name = "Category")]
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "Supplier is required")]
        [Display(Name = "Supplier")]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Purchase price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Purchase price must be greater than 0")]
        [Display(Name = "Purchase Price")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PurchasePrice { get; set; }

        [Required(ErrorMessage = "Selling price is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Selling price must be greater than 0")]
        [Display(Name = "Selling Price")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SellingPrice { get; set; }

        [Required(ErrorMessage = "Quantity is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity cannot be negative")]
        [Display(Name = "Quantity in Stock")]
        public int Quantity { get; set; } = 0;

        [Required(ErrorMessage = "Reorder level is required")]
        [Range(0, int.MaxValue, ErrorMessage = "Reorder level cannot be negative")]
        [Display(Name = "Reorder Level")]
        public int ReorderLevel { get; set; } = 10;

        [StringLength(500, ErrorMessage = "Image path cannot exceed 500 characters")]
        [Display(Name = "Product Image")]
        public string? ImagePath { get; set; }

        [Display(Name = "Is Active")]
        public bool IsActive { get; set; } = true;

        // Navigation properties
        [ForeignKey("CategoryId")]
        public virtual Category Category { get; set; } = null!;

        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; } = null!;

        public virtual ICollection<StockMovement> StockMovements { get; set; } = new List<StockMovement>();

        // Computed property for low stock alert
        [NotMapped]
        public bool IsLowStock => Quantity <= ReorderLevel;

        // Computed property for profit margin
        [NotMapped]
        public decimal ProfitMargin => SellingPrice - PurchasePrice;

        // Computed property for profit percentage
        [NotMapped]
        public decimal ProfitPercentage => PurchasePrice > 0 ? ((SellingPrice - PurchasePrice) / PurchasePrice) * 100 : 0;
    }
}
