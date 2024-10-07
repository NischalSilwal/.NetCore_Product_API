using DatabasePractice1.DTO;
using DatabasePractice1.Models;

namespace DatabasePractice1.Mappers
{
    public interface IProductMapper
    {
        ProductDto MapToDto(Product product);
        Product MapToEntity(ProductDto productDto);
    }
}
