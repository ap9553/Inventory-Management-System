using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    /// <summary>
    /// UserRole entity for custom role management and permissions
    /// </summary>
    public class UserRole : BaseEntity
    {
        [Required(ErrorMessage = "Role name is required")]
        [StringLength(50, ErrorMessage = "Role name cannot exceed 50 characters")]
        [Display(Name = "Role Name")]
        public string RoleName { get; set; } = string.Empty;

        [StringLength(200, ErrorMessage = "Description cannot exceed 200 characters")]
        [Display(Name = "Description")]
        public string? Description { get; set; }

        // Permission flags
        [Display(Name = "Can Manage Products")]
        public bool CanManageProducts { get; set; } = false;

        [Display(Name = "Can Manage Sales")]
        public bool CanManageSales { get; set; } = false;

        [Display(Name = "Can Manage Purchases")]
        public bool CanManagePurchases { get; set; } = false;

        [Display(Name = "Can Manage Users")]
        public bool CanManageUsers { get; set; } = false;

        [Display(Name = "Can View Reports")]
        public bool CanViewReports { get; set; } = false;

        [Display(Name = "Can Manage Suppliers")]
        public bool CanManageSuppliers { get; set; } = false;

        [Display(Name = "Can Manage Customers")]
        public bool CanManageCustomers { get; set; } = false;
    }
}
