namespace TestAPI.Models
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

        public int TypeID { get; set; }

        public bool Aviability { get; set; }
        public string? Description { get; set; }

        public virtual Type Type { get; set; }

        public virtual ICollection<ProductUser> ProductUsers { get; set; }
        public virtual ICollection<ProductProvider> ProductProviders { get; set; }
        public virtual ICollection<Comment> Comments { get; set; }
    }
}
