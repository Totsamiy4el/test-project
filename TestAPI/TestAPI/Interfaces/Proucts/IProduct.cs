using TestAPI.ApiModels;
using TestAPI.Infrastructure;
using TestAPI.Infrastructure.DbModels;

namespace TestAPI.Interfaces.Proucts
{
    public interface IProduct
    {
        public List<Products> ReadProducts(ApplicationContext context);
        public Task DeleteProduct(int id, ApplicationContext context);
        public Task CreateProduct (UpsertProductModel createdProduct, ApplicationContext context);
        public Task UpdateProduct (UpsertProductModel updatedProduct, ApplicationContext context);
    }
}
