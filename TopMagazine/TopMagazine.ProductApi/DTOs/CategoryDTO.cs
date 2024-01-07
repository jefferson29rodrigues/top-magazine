using System.ComponentModel.DataAnnotations;
using TopMagazine.ProductApi.Models;

namespace TopMagazine.ProductApi.DTOs
{
    public class CategoryDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome é requerido")]
        [MinLength(3)]
        [MaxLength(100)]
        public string? Name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
