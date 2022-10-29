using Microsoft.AspNetCore.Mvc;
using System.Reflection.PortableExecutable;
using TestAPI.ApiModels;
using TestAPI.Infrastructure;
using TestAPI.Infrastructure.DbModels;

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
            return _context.Products.ToList();
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            _context.Products.Remove(_context.Products.FirstOrDefault(product => product.Id == id));
            _context.SaveChanges();
            return Ok();
        }

        [HttpPost]
        public IActionResult PostProduct(UpsertProductModel createdProduct)
        {
            var product = new Products()
            {
                Name = createdProduct.Name,
                Price = createdProduct.Price,
                Ñharacteristics = createdProduct.Ñharacteristics,
                ProductTypeId = createdProduct.ProductTypeId,
                Description = createdProduct.Description,
                Availability = createdProduct.Availability
            };
            _context.Products.Add(product);
            _context.SaveChanges();
            return Ok(product);
        }


        [HttpPut]
        public IActionResult ProductPut([FromBody] UpsertProductModel product)
        {

            var storedProduct = _context.Products.FirstOrDefault(products => products.Id == product.Id);

            if (storedProduct == null)
            {
                return NotFound();
            }
            storedProduct.Name = product.Name;
            storedProduct.Price = product.Price;
            storedProduct.Ñharacteristics = product.Ñharacteristics;
            storedProduct.ProductTypeId = product.ProductTypeId;
            storedProduct.Description = product.Description;
            storedProduct.Availability = product.Availability;
            _context.SaveChanges();

            return Ok(storedProduct);
        }



    }
}