namespace TestAPI.Models
{
    public class ProductUser
    {
        public int Id { get; set; }
        public int ProductID { get; set; }
        public int UserID { get; set; }

        public virtual User User { get; set; }

        public virtual Products Products { get; set; }


    }
}
