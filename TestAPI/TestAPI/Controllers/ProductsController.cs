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
        private readonly ApplicationContext _context;
        public Product product = new Product();
        public ProductsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllProducts")]
        public List<Products> GetAllProducts()
        {
            return product.ReadProducts(_context);
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            product.DeleteProduct(id, _context);
            return Ok();
        }

        [HttpPost]
        public IActionResult PostProduct(UpsertProductModel createdProduct)
        {
            product.CreateProduct(createdProduct, _context);
            return Ok(product);
        }


        [HttpPut]
        public IActionResult ProductPut([FromBody] UpsertProductModel products)
        {
            product.UpdateProduct(products, _context);
            return Ok();
        }



    }
}