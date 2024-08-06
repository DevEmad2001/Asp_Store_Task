using System.ComponentModel.DataAnnotations;

namespace Asp_Store.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; } = null;
        [Required]
        public string? Address { get; set; } = null;
        [Required]
        public string? Email { get; set; } = string.Empty;
        [Required]
        public string? Phone { get; set; } = string.Empty;
    }
}
