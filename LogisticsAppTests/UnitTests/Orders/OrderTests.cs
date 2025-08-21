using LogisticsApp.Models.Items;
using LogisticsApp.Models.Orders;
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
        public void GetOrdersSucceeds()
        {
            //arrange
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

            Order Order1 = new Order
            {
                OrderId = 1,
                Buyer = "Buyer",
                Seller = "seller",
                PurchaseDate = DateTime.Now,
                ShippingDate = DateTime.Now,
                DeliveryDate = DateTime.Now,
                Items = 
            }

            //act
            //query table object


            //assert
            //compare

        }
    }
}
