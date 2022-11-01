using TestAPI.ApiModels;
using TestAPI.Infrastructure;
using TestAPI.Infrastructure.DbModels;
using TestAPI.Infrastructure.DbModels;

namespace TestAPI.Interfaces.IProduct
{
    public interface IProduct
    {
        public List<Products> GetProducts();
        public Task<IAsyncResult> DeleteProduct(int id);
        public Task<IAsyncResult> CreateProduct (UpsertProductModel createdProduct);
        public Task<IAsyncResult> UpdateProduct (UpsertProductModel updatedProduct);
    }
}
