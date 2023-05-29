using Mango.Services.Products.API.Models.Dto;

namespace Mango.Services.Products.API.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductDto>> GetProducts();
        
        Task<ProductDto> GetProductById (int productId);

        Task<ProductDto> CreatUpdateProduct(ProductDto productDto);

        Task<bool> DeleteProduct(int productId);
    }
}
