using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InventoryManagementSystem.Models
{
    /// <summary>
    /// StockMovement entity for tracking inventory changes
    /// </summary>
    public class StockMovement : BaseEntity
    {
        [Required(ErrorMessage = "Product is required")]
        [Display(Name = "Product")]
        public int ProductId { get; set; }

        [Required(ErrorMessage = "Movement type is required")]
        [StringLength(50, ErrorMessage = "Movement type cannot exceed 50 characters")]
        [Display(Name = "Movement Type")]
        public string MovementType { get; set; } = string.Empty; // Purchase, Sale, Adjustment, Return

        [Required(ErrorMessage = "Quantity is required")]
        [Display(Name = "Quantity")]
        public int Quantity { get; set; }

        [Required(ErrorMessage = "Previous stock is required")]
        [Display(Name = "Previous Stock")]
        public int PreviousStock { get; set; }

        [Required(ErrorMessage = "New stock is required")]
        [Display(Name = "New Stock")]
        public int NewStock { get; set; }

        [Display(Name = "Reference Number")]
        [StringLength(50, ErrorMessage = "Reference number cannot exceed 50 characters")]
        public string? ReferenceNumber { get; set; }

        [StringLength(500, ErrorMessage = "Notes cannot exceed 500 characters")]
        [Display(Name = "Notes")]
        public string? Notes { get; set; }

        [StringLength(100, ErrorMessage = "Created by field cannot exceed 100 characters")]
        [Display(Name = "Created By")]
        public string? CreatedBy { get; set; }

        // Navigation properties
        [ForeignKey("ProductId")]
        public virtual Product Product { get; set; } = null!;
    }
}
