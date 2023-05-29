
using Mango.Web.Models;

namespace Mango.Web.Services
{
    public interface IProductService
    {
        Task<T> GetAllProductsAsync<T>();
        Task<T> GetAllProductsByIdAsync<T>(int id);
        Task<T> CreateProduct<T>(ProductDto productDto);
        Task<T> UpdateProduct<T>(ProductDto productDto);
        Task<T> DeleteProduct<T>(int id);
    }
}
