using TestAPI.ApiModels;
using TestAPI.Infrastructure;
using TestAPI.Infrastructure.DbModels;
using TestAPI.Infrastructure.DbModels;

namespace TestAPI.Interfaces.IProduct
{
    public interface IProduct
    {
        public List<Products> GetProducts();
        public Task DeleteProduct(int id);
        public Task CreateProduct (UpsertProductModel createdProduct);
        public Task UpdateProduct (UpsertProductModel updatedProduct);
    }
}
