using DatabasePractice1.Models;
using DatabasePractice1.Repo;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DatabasePractice1.Services
{
    public class ProductService : IProductServices
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetProductsAsync()
        {
            // Consider adding error handling here
            return await _productRepository.GetAllProductsAsync(); // Fixed method name
        }

        public async Task<Product> GetProductByIdAsync(int productId)
        {
            // Consider adding error handling here
            return await _productRepository.GetProductByIdAsync(productId);
        }

        public async Task AddProductAsync(Product product)
        {
            // Consider adding error handling here
            await _productRepository.AddProductAsync(product);
        }

        public async Task UpdateProductAsync(int id, Product product)
        {
            // Consider adding error handling here
            await _productRepository.UpdateProductAsync(product); // Updated to match the repository method signature
        }

        public async Task DeleteProductAsync(int productId)
        {
            // Consider adding error handling here
            await _productRepository.DeleteProductAsync(productId);
        }
    }
}
