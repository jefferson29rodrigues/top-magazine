using TopMagazine.ProductApi.DTOs;

namespace TopMagazine.ProductApi.Services
{
    public interface IProductService 
    {
        Task<IEnumerable<ProductDTO>> GetProducts();
        Task<ProductDTO> GetProductById();
        Task<ProductDTO> AddProduct(ProductDTO productDTO);
        Task<ProductDTO> UpdateProduct(ProductDTO productDTO);
        Task<ProductDTO> RemoveProduct(int id);

    }
}
