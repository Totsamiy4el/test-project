
namespace TestAPI.Infrastructure.DbModels
{
    public class Provider
    {
        public Provider()
        {
            ProductProviders = new HashSet<ProductProvider>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal? Price { get; set; }

        public string Email { get; set; }

        public virtual ICollection<ProductProvider> ProductProviders { get; private set; }
    }
}
