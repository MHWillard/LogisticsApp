using LogisticsApp.Models.Items;

namespace LogisticsApp.Models.Orders
{
    public class Order
    {
        public int OrderId { get; set; }
        public string Buyer { get; set; }
        public string Seller { get; set; }
        public DateTime PurchaseDate { get; set; }
        public DateTime ShippingDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public List<Item> Items { get; set; }
    }
}
