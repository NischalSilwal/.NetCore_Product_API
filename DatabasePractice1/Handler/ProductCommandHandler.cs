using DatabasePractice1.command;
using DatabasePractice1.Models;
using DatabasePractice1.Repo;
using System.Threading.Tasks;

namespace DatabasePractice1.Handler
{
    public class ProductCommandHandler
    {
        private readonly IProductRepository _productRepository;

        public ProductCommandHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task AddProductAsync(ProductCommand command)
        {
            // Create a new product instance from the command
            var product = new Product
            {
                Name = command.Name,
                Price = command.Price,
                Description = command.Description
            };

            // Call the repository method to add the product
            await _productRepository.AddProductAsync(product); // Ensure this method is called
        }

        public async Task UpdateProductAsync(ProductCommand command)
        {
            // Create a new product instance from the command
            var product = new Product
            {
                Id = command.Id, // Ensure the command has an Id property
                Name = command.Name,
                Price = command.Price,
                Description = command.Description
            };

            // Call the repository method to update the product
            await _productRepository.UpdateProductAsync(product); // Ensure this method is called
        }

        public async Task DeleteProductAsync(int id)
        {
            // Call the repository method to delete the product
            await _productRepository.DeleteProductAsync(id); // Ensure this method is called
        }

        // Add other command handler methods as needed (e.g., UploadFileAsync)
    }
}
