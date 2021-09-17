using CitiMarket.Model;
using Microsoft.EntityFrameworkCore;
using System;

namespace CitiMarket.DataBaseConnector
{
    public class CitiMarketContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public  DbSet<OrderDetails> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Shipper> Shippers { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }

        public CitiMarketContext(DbContextOptions<CitiMarketContext> options) : base(options)
        {

        }

        public CitiMarketContext()
        {
        }
    }
}
