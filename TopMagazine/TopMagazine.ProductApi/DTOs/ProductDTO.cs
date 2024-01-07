using System.ComponentModel.DataAnnotations;
using TopMagazine.ProductApi.Models;

namespace TopMagazine.ProductApi.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é requerido")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "O preço é requerido")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "A descrição é requerida")]
        [MinLength(5)]
        [MaxLength(200)]
        public string? Description { get; set; }

        [Required(ErrorMessage = "O stock é requerido")]
        [Range(1, 9999)]
        public long Stock { get; set; }
        public string? ImageURL { get; set; }
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
    }
}
