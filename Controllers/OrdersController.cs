using LogisticsApp.Models.Orders;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Threading.Tasks;
using static OpenQA.Selenium.PrintOptions;

namespace LogisticsApp.Controllers
{
    public class OrdersController : Controller
    {
        private readonly OrdersContext _context;

        public OrdersController(OrdersContext context)
        {
            _context = context;
        }

        public async Task<Order> GetOrder()
        {
            var order = await _context.Orders.FirstOrDefaultAsync();

            return order;
        }

        public async Task<List<Order>> GetOrders()
        {
            var orders = await _context.Orders
                .OrderBy(o => o.OrderId)
                .ToListAsync();

            return orders;
        }
    }
}
