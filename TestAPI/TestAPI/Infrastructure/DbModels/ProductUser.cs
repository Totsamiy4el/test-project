
namespace TestAPI.Infrastructure.DbModels
{
    public class ProductUser
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public virtual Products Products { get; set; }


    }
}
