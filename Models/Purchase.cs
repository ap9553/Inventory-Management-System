using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models
{
    /// <summary>
    /// Purchase entity representing purchase orders from suppliers
    /// </summary>
    public class Purchase : BaseEntity
    {
        [Required(ErrorMessage = "Purchase number is required")]
        [StringLength(50, ErrorMessage = "Purchase number cannot exceed 50 characters")]
        [Display(Name = "Purchase Number")]
        public string PurchaseNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "Purchase date is required")]
        [Display(Name = "Purchase Date")]
        [DataType(DataType.Date)]
        public DateTime PurchaseDate { get; set; } = DateTime.Now;

        [Required(ErrorMessage = "Supplier is required")]
        [Display(Name = "Supplier")]
        public int SupplierId { get; set; }

        [Required(ErrorMessage = "Total amount is required")]
        [Range(0.01, double.MaxValue, ErrorMessage = "Total amount must be greater than 0")]
        [Display(Name = "Total Amount")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        [Required(ErrorMessage = "Status is required")]
        [StringLength(50, ErrorMessage = "Status cannot exceed 50 characters")]
        [Display(Name = "Status")]
        public string Status { get; set; } = "Pending"; // Pending, Completed, Cancelled

        [StringLength(500, ErrorMessage = "Notes cannot exceed 500 characters")]
        [Display(Name = "Notes")]
        public string? Notes { get; set; }

        [StringLength(100, ErrorMessage = "Created by field cannot exceed 100 characters")]
        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }

        // Navigation properties
        [ForeignKey("SupplierId")]
        public virtual Supplier Supplier { get; set; } = null!;

        public virtual ICollection<PurchaseItem> PurchaseItems { get; set; } = new List<PurchaseItem>();
    }
}
