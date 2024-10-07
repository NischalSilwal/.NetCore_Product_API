using DatabasePractice1.Data;
using DatabasePractice1.Handler;
using DatabasePractice1.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabasePractice1.Repo
{
    public interface IProductRepository
    {
        Task<IEnumerable<Product>> GetAllProductsAsync();
        Task<Product> GetProductByIdAsync(int id);
        Task AddProductAsync(Product product);
        Task UpdateProductAsync(Product product);
        Task DeleteProductAsync(int id);
        Task UploadFileAsync(ImageDetail imageDetail);
    }
}