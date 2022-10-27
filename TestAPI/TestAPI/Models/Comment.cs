namespace TestAPI.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Review { get; set; }
        public int ProductID { get; set; }
        public int UserID { get; set; }
        public int Rate { get; set; }
        public virtual User User { get; set; }
        public virtual Products Products { get; set; }


    }
}
