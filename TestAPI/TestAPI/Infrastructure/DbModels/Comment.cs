
namespace TestAPI.Infrastructure.DbModels
{
    public class Comment
    {
        public int Id { get; set; }
        public string Review { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Rate { get; set; }
        public virtual User User { get; set; }
        public virtual Products Products { get; set; }


    }
}
