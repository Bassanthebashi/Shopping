namespace Shopping.Data.Models
{
    public class Order
    {
        public Guid Id { get; set; }

        public string UserId { get; set; }

        public User User { get; set; }
        public bool Approval { get; set; }=false;

        public ICollection<OrderItem> OrderItems{ get; set; }
    }
}
