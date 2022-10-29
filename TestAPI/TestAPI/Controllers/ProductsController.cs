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
        public ProductsController(ApplicationContext context)
        {
            _context = context;
        }

        [HttpGet("GetAllProducts")]
        public List<Products> GetAllProducts()
        {
            var readProduct = new CrudOperations();
            return readProduct.ReadProducts(_context);
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            var deleteProduct = new CrudOperations();
            deleteProduct.DeleteProduct(id, _context);
            return Ok();
        }

        [HttpPost]
        public IActionResult PostProduct(UpsertProductModel createdProduct)
        {
            var product = new CrudOperations();
            product.CreateProduct(createdProduct, _context);
            return Ok(product);
        }


        [HttpPut]
        public IActionResult ProductPut([FromBody] UpsertProductModel product)
        {

            var products = new CrudOperations();
            products.UpdateProduct(product,_context);
            return Ok();
        }



    }
}