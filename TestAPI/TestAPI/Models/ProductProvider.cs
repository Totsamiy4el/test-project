namespace TestAPI.Models
{
    public class ProductProvider
    {
        public int Id { get; set; }

        public int ProviderID { get; set; }

        public int ProductID { get; set; }

        public virtual Products Products { get; set; }
        public virtual Provider Provider { get; set; }
    }
}
