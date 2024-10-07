using DatabasePractice1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabasePractice1.Repo
{
    public interface IProductServices
    {
        Task<IEnumerable<Product>> GetProductsAsync(); // Change to async
        Task<Product> GetProductByIdAsync(int productId); // Change to async
        Task AddProductAsync(Product product); // Change to async
        Task UpdateProductAsync(int id, Product product); // Change to async
        Task DeleteProductAsync(int productId); // Change to async
    }
}
