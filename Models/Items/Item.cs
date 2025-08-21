namespace LogisticsApp.Models.Items
{
    public class Item
    {
        public int ItemId { get; set; }

        public int ItemDetailId { get; set; }
        public int OrderId { get; set; }

        public int Quantity { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
