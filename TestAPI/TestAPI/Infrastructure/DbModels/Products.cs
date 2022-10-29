using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestAPI.Infrastructure.DbModels
{
    public class Products
    {
        public Products()
        {
            ProductUsers = new HashSet<ProductUser>();
            ProductProviders = new HashSet<ProductProvider>();
            Comments = new HashSet<Comment>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Сharacteristics { get; set; }

        public int ProductTypeId { get; set; }
        public string? Description { get; set; }
        public bool Availability { get; set; }

        public virtual ProductType ProductType { get; set; }

        public virtual ICollection<ProductUser> ProductUsers { get; set; }
        public virtual ICollection<ProductProvider> ProductProviders { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
