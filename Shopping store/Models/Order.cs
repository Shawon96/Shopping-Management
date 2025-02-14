namespace Shopping_store.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Number { get; set; }

        public string UserId { get; set; }
        public User User { get; set; }
    }
}
