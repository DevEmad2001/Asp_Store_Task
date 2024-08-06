using System.ComponentModel.DataAnnotations;

namespace Asp_Store.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }=null;
        [Required]
        public decimal Price { get; set; }
        public string? Description { get; set; }= null;

    }
}
