using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
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
        public List<Products> ReadProducts()
        {
            return _context.Products.ToList();
        }
        public Task DeleteProduct(int id)
        {
            var product = _context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null) 
            { 
                return Task.FromException(new Exception("Not Found!")); 
            }
            _context.Products.Remove(product);
            _context.SaveChanges();
            return Task.CompletedTask;
        }
        public Task CreateProduct(UpsertProductModel createdProduct)
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
            _context.SaveChanges();
            return Task.CompletedTask;
        }
        public Task UpdateProduct([FromBody] UpsertProductModel product)
        {
            var storedProduct = _context.Products.FirstOrDefault(products => products.Id == product.Id);

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
            _context.SaveChanges();

            return Task.CompletedTask;
        }
    }
}
