using LogisticsApp.Models.Orders;

namespace LogisticsApp.ViewModels
{
    public class OrderIndexViewModel
    {
        public List<Order> Orders { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
    }
}
