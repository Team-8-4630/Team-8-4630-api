using Team_8_4630.Domain.Catalog;

namespace Team_8_4630.Domain.Orders
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Item Item { get; set; } = null!;
        public int Quantity { get; set; }
        public decimal Price => Item.Price * Quantity;
    }
}