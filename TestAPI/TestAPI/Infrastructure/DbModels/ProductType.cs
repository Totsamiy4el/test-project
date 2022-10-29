using System.ComponentModel.DataAnnotations;

namespace TestAPI.Infrastructure.DbModels
{
    public class ProductType
    {
        public ProductType()
        {
            Products = new HashSet<Products>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string CPU { get; set; }

        public string VideoCard { get; set; }

        public string RAM { get; set; }

        public string Mamory { get; set; }

        public virtual ICollection<Products> Products { get; set; }

    }
}
