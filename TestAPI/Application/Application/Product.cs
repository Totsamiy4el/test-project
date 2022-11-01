using Microsoft.EntityFrameworkCore;
using TestAPI.ApiModels;
using TestAPI.Infrastructure;
using TestAPI.Infrastructure.DbModels;
using TestAPI.Interfaces.IProduct;

namespace TestAPI.Application
{
    public class Product : IProduct
    {
        private readonly ApplicationContext _context;  
        public Product(ApplicationContext context)
        {
            _context = context;
        }
        public List<Products> GetProducts()
        {
            return _context.Products.ToList();
        }
        public async Task<IAsyncResult> DeleteProduct(int id)
        {
            var product = await _context.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (product == null) 
            {
                return Task.FromException(new Exception("Not Found!")); 
            }
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return Task.CompletedTask;
        }
        public async Task<IAsyncResult> CreateProduct(UpsertProductModel createdProduct)
        {
            var product = new Products()
            {
                Name = createdProduct.Name,
                Price = createdProduct.Price,
                Сharacteristics = createdProduct.Сharacteristics,
                ProductTypeId = createdProduct.ProductTypeId,
                Description = createdProduct.Description,
                Availability = createdProduct.Availability
            };
            _context.Products.Add(product);
            await _context.SaveChangesAsync();
            return Task.CompletedTask;
        }
        public async Task<IAsyncResult> UpdateProduct(UpsertProductModel product)
        {
            var storedProduct = await _context.Products.FirstOrDefaultAsync(products => products.Id == product.Id);

            if (storedProduct == null)
            {
                return Task.FromException(new Exception("Not Found!"));
            }
            storedProduct.Name = product.Name;
            storedProduct.Price = product.Price;
            storedProduct.Сharacteristics = product.Сharacteristics;
            storedProduct.ProductTypeId = product.ProductTypeId;
            storedProduct.Description = product.Description;
            storedProduct.Availability = product.Availability;
            await _context.SaveChangesAsync();

            return Task.CompletedTask;
        }
    }
}
