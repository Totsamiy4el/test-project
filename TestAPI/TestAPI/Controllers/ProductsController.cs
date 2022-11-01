using Microsoft.AspNetCore.Mvc;
using TestAPI.ApiModels;
using TestAPI.Infrastructure;
using TestAPI.Infrastructure.DbModels;
using TestAPI.Interfaces.IProduct;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        public IProduct _product;
        public ProductsController(IProduct product)
        {
            _product = product;
        }

        [HttpGet("GetAllProducts")]
        public List<Products> GetAllProducts()
        {
            return _product.GetProducts();
        }

        [HttpDelete]
        public IActionResult DeleteProduct(int id)
        {
            _product.DeleteProduct(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult PostProduct(UpsertProductModel createdProduct)
        {
            _product.CreateProduct(createdProduct);
            return Ok(_product);
        }


        [HttpPut]
        public IActionResult ProductPut([FromBody] UpsertProductModel products)
        {
            _product.UpdateProduct(products);
            return Ok();
        }



    }
}