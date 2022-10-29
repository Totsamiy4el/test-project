namespace TestAPI.ApiModels
{
    public class UpsertProductModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Сharacteristics { get; set; }

        public int ProductTypeId { get; set; }
        public string Description { get; set; }
        public bool Availability { get; set; }
    }

}
