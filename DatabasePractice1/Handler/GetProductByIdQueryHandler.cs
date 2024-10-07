using DatabasePractice1.Models;
using DatabasePractice1.Query;
using DatabasePractice1.Repo;
using System.Threading.Tasks;

namespace DatabasePractice1.Handler
{
    public class GetProductByIdQueryHandler
    {
        private readonly IProductRepository _productRepository;

        public GetProductByIdQueryHandler(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> Handle(ProductQuery query)
        {
            return await _productRepository.GetProductByIdAsync(query.Id);
        }
    }

}
