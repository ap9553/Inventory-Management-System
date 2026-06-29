using System.ComponentModel.DataAnnotations;

namespace InventoryManagementSystem.Models
{
    /// <summary>
    /// Base entity class containing common properties for all entities
    /// Implements soft delete pattern and audit fields
    /// </summary>
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Created Date")]
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        [Display(Name = "Last Updated")]
        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        [Display(Name = "Is Deleted")]
        public bool IsDeleted { get; set; } = false;
    }
}
