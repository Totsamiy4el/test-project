using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using TestAPI.ApiModels;
using TestAPI.Infrastructure;
using TestAPI.Infrastructure.DbModels;
using TestAPI.Interfaces.Proucts;

namespace TestAPI.Application
{
    public class CrudOperations : IProduct
    {
        
        public List<Products> ReadProducts(ApplicationContext context)
        {
            return context.Products.ToList();
        }
        public Task DeleteProduct(int id,ApplicationContext context)
        {
            var product = context.Products.FirstOrDefault(p => p.Id == id);
            if (product == null) 
            { 
                return Task.FromException(new Exception("Not Found!")); 
            }
            context.Products.Remove(product);
            context.SaveChanges();
            return Task.CompletedTask;
        }
        public Task CreateProduct(UpsertProductModel createdProduct, ApplicationContext context)
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
            context.Products.Add(product);
            context.SaveChanges();
            return Task.CompletedTask;
        }
        public Task UpdateProduct([FromBody] UpsertProductModel product, ApplicationContext context)
        {
            var storedProduct = context.Products.FirstOrDefault(products => products.Id == product.Id);

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
            context.SaveChanges();

            return Task.CompletedTask;
        }
    }
}
