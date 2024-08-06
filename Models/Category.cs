using System.ComponentModel.DataAnnotations;

namespace Asp_Store.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? DisplayOrder { get; set; }
    }
}
