using LogisticsApp.Controllers;
using LogisticsApp.Models.Items;
using LogisticsApp.Models.Orders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace LogisticsAppTests.UnitTests.Orders
{
    public class OrderTests
    {
        [Fact]
        public async Task GetOrdersSucceeds()
        {
            //arrange
            //mock DB
            var options = new DbContextOptionsBuilder<OrdersContext>()
                .UseInMemoryDatabase(databaseName: "GetOrdersSucceeds")
                .Options;

            //database setup, object that we're looking for
            Item Item1 = new Item
            {
                ItemId = 1,
                ItemDetailId = 1,
                OrderId = 1,
                Quantity = 1,
                Name = "item1",
                Description = "item1dec"
            };

            Item Item2 = new Item
            {
                ItemId = 2,
                ItemDetailId = 2,
                OrderId = 1,
                Quantity = 2,
                Name = "item2",
                Description = "item2dec"
            };

            List<Item> items = new List<Item> { Item1, Item2 };

            Order Order1 = new Order
            {
                OrderId = 1,
                Buyer = "Buyer",
                Seller = "seller",
                PurchaseDate = DateTime.Now,
                ShippingDate = DateTime.Now,
                DeliveryDate = DateTime.Now,
                Items = items
            };

            OrdersContext context = new OrdersContext();
            OrdersController ordersController = new OrdersController(context);
            context.Orders.Add(Order1);
            context.SaveChanges();

            //act
            //query table object
            var result = await ordersController.GetOrders();

            //assert
            Assert.Single(result);
            var returnedOrder = result[0];
            Assert.Equal(Order1.OrderId, returnedOrder.OrderId);
            Assert.Equal(Order1.Buyer, returnedOrder.Buyer);
            Assert.Equal(Order1.Seller, returnedOrder.Seller);
            Assert.Equal(Order1.Items.Count, returnedOrder.Items.Count);
            Assert.Equal(Order1.Items[0].Name, returnedOrder.Items[0].Name);
            Assert.Equal(Order1.Items[1].Name, returnedOrder.Items[1].Name);
        }
    }
}
