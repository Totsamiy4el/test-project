using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestAPI.Infrastructure.DbModels
{
    public class ProductProvider
    {
        public int Id { get; set; }

        public int ProviderId { get; set; }

        public int ProductId { get; set; }
        public virtual Products Products { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
