namespace Shopping.Data.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description{ get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }

        public string Image { get; set; }

    }
}
