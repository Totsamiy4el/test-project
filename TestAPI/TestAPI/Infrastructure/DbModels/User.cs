
namespace TestAPI.Infrastructure.DbModels
{
    public class User
    {
        public User()
        {
            ProductUsers = new HashSet<ProductUser>();
            Comments = new HashSet<Comment>();
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Password { get; set; }

        public string? IpAdress { get; set; }

        public string Email { get; set; }

        public virtual ICollection<ProductUser> ProductUsers { get; set; }

        public virtual ICollection<Comment> Comments { get; set; }
    }
}
