using DatabasePractice1.Models;
using DatabasePractice1.Data;
using Microsoft.EntityFrameworkCore;
using DatabasePractice1.Handler;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace DatabasePractice1.Repo
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _context;
        private readonly IErrorHandlingService<string> _errorHandlingService;

        public ProductRepository(ApplicationDbContext context, IErrorHandlingService<string> errorHandlingService)
        {
            _context = context;
            _errorHandlingService = errorHandlingService;
        }

        public async Task<IEnumerable<Product>> GetAllProductsAsync()
        {
            try
            {
                return await _context.Products.ToListAsync();
            }
            catch (Exception ex)
            {
                _errorHandlingService.SetError($"Error in GetAllProductsAsync: {ex.Message}");
                throw;
            }
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
            try
            {
                return await _context.Products.FindAsync(id);
            }
            catch (Exception ex)
            {
                _errorHandlingService.SetError($"Error in GetProductByIdAsync: {ex.Message}");
                throw;
            }
        }

        public async Task AddProductAsync(Product product)
        {
            try
            {
                await _context.Products.AddAsync(product);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _errorHandlingService.SetError($"Error in AddProductAsync: {ex.Message}");
                throw;
            }
        }

        public async Task UpdateProductAsync(Product product)
        {
            try
            {
                var productDetail = await _context.Products.FindAsync(product.Id);
                if (productDetail == null)
                {
                    throw new KeyNotFoundException("Product not found.");
                }

                productDetail.Name = product.Name;
                productDetail.Price = product.Price;
                productDetail.Description = product.Description;

                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _errorHandlingService.SetError($"Error in UpdateProductAsync: {ex.Message}");
                throw;
            }
        }

        public async Task DeleteProductAsync(int id)
        {
            try
            {
                var product = await _context.Products.FindAsync(id);
                if (product != null)
                {
                    _context.Products.Remove(product);
                    await _context.SaveChangesAsync();
                }
            }
            catch (Exception ex)
            {
                _errorHandlingService.SetError($"Error in DeleteProductAsync: {ex.Message}");
                throw;
            }
        }

        public async Task UploadFileAsync(ImageDetail imageDetail)
        {
            try
            {
                await _context.Images.AddAsync(imageDetail);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _errorHandlingService.SetError($"Error in UploadFileAsync: {ex.Message}");
                throw;
            }
        }
    }
}