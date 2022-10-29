using Microsoft.AspNetCore.Mvc;
using System.Reflection.PortableExecutable;
using TestAPI.ApiModels;
using TestAPI.Infrastructure;
using TestAPI.Infrastructure.DbModels;
using TestAPI.Application;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        public Product product;

        private readonly ApplicationContext _context;
        public ProductsController(ApplicationContext context)
        {
            _context = context;
            product = new Product(_context);
        }

         

        [HttpGet("GetAllProducts")]
        public List<Products> GetAllProducts()
        {
            return product.GetProducts();
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            product.DeleteProduct(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult PostProduct(UpsertProductModel createdProduct)
        {
            product.CreateProduct(createdProduct);
            return Ok(product);
        }


        [HttpPut]
        public IActionResult ProductPut([FromBody] UpsertProductModel products)
        {
            product.UpdateProduct(products);
            return Ok();
        }



    }
}