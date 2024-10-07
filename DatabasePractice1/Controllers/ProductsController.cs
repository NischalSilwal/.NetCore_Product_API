using DatabasePractice1.Models;
using DatabasePractice1.Repo;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace DatabasePractice1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly IProductServices _productService;

        // Dependency Injection
        public ProductsController(IProductServices productService)
        {
            _productService = productService;
        }


        // GET: api/<ControllerCourse>
        [HttpGet]
        public async Task<IEnumerable<Product>> GetProducts()
        {
            return await _productService.GetProductsAsync();
        }

        // GET api/<ControllerCourse>/5
        [HttpGet("{id}")]
        public async Task<Product> Get(int id)
        {
            return await _productService.GetProductByIdAsync(id);
        }

        // POST api/<ControllerCourse>
        [HttpPost]
        public async Task Post([FromBody] Product value)
        {
            await _productService.AddProductAsync(value);
        }

        // PUT api/<ControllerCourse>/5
        [HttpPut("{id}")]
        public async Task Put(int id, [FromBody] Product value)
        {
            await _productService.UpdateProductAsync(id, value);
        }

        // DELETE api/<ControllerCourse>/5
        [HttpDelete("{id}")]
        public async Task Delete(int id)
        {
            await _productService.DeleteProductAsync(id);
        }

    }
}
