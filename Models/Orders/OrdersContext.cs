using Microsoft.EntityFrameworkCore;

namespace LogisticsApp.Models.Orders
{
    public class OrdersContext : DbContext
    {
        public DbSet<Order> Orders { get; set; }

        public string DbPath { get; }

        public OrdersContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "blogging.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
    }

}
