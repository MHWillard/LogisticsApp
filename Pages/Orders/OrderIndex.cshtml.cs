using LogisticsApp.Models.Orders;
using LogisticsApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LogisticsApp.Pages
{
    public class OrderModel : PageModel
    {
        private readonly OrdersContext _context;
        public OrderIndexViewModel OrderList { get; set; }

        public OrderModel(OrdersContext context)
        {
            _context = context;
        }

        public void OnGet()
        {
        }
    }

}
