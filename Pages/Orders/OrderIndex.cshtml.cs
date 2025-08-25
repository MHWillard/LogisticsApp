using LogisticsApp.Controllers;
using LogisticsApp.Models.Orders;
using LogisticsApp.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace LogisticsApp.Pages
{
    public class OrderModel : PageModel
    {
        private readonly OrdersContext _context;
        private OrdersController _orderController;
        public OrderIndexViewModel OrderList { get; set; }

        public OrderModel(OrdersContext context)
        {
            _context = context;
            _orderController = new OrdersController(_context);
        }

        public async Task OnGetAsync(int pageNumber = 1, int pageSize = 10)
        {
            var totalOrders = await _context.Orders.CountAsync();
            var orders = await _orderController.GetOrders();
        }
    }

}
