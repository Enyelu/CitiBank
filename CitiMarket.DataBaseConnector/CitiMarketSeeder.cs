using CitiMarket.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiMarket.DataBaseConnector
{
    public class CitiMarketSeeder
    {
        public static async Task SeedCustomerData(CitiMarketContext citiMarketContext)
        {
            try
            {
                citiMarketContext.Database.EnsureCreated();
                if (!citiMarketContext.Customers.Any())
                {
                    var data = File.ReadAllText(@"C:\Users\hp\Desktop\CitiMarket\CitiMarket.DataBaseConnector\Json\Customer.json");

                    var listOfCustomers = JsonConvert.DeserializeObject<List<Customer>>(data);
                    await citiMarketContext.Customers.AddRangeAsync(listOfCustomers);
                    await citiMarketContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task SeedSupplierData(CitiMarketContext citiMarketContext)
        {
            try
            {
                citiMarketContext.Database.EnsureCreated();
                if (!citiMarketContext.Suppliers.Any())
                {
                    var data = File.ReadAllText(@"C:\Users\hp\Desktop\CitiMarket\CitiMarket.DataBaseConnector\Json\Supplier.json");
                

                 var listOfSuppliers = JsonConvert.DeserializeObject<List<Supplier>>(data);
                    await citiMarketContext.Suppliers.AddRangeAsync(listOfSuppliers);
                    await citiMarketContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static async Task SeedCategoryData(CitiMarketContext citiMarketContext)
        {
            try
            {
                citiMarketContext.Database.EnsureCreated();
                if (!citiMarketContext.Categories.Any())
                {
                    var data = File.ReadAllText(@"C:\Users\hp\Desktop\CitiMarket\CitiMarket.DataBaseConnector\Json\Category.json");


                    var listOfCategory = JsonConvert.DeserializeObject<List<Category>>(data);
                    await citiMarketContext.Categories.AddRangeAsync(listOfCategory);
                    await citiMarketContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static async Task SeedProductData(CitiMarketContext citiMarketContext)
        {
            try
            {
                citiMarketContext.Database.EnsureCreated();
                if (!citiMarketContext.Products.Any())
                {
                    var data = File.ReadAllText(@"C:\Users\hp\Desktop\CitiMarket\CitiMarket.DataBaseConnector\Json\Product.json");


                    var listOfProduct = JsonConvert.DeserializeObject<List<Product>>(data);
                    await citiMarketContext.Products.AddRangeAsync(listOfProduct);
                    await citiMarketContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task SeedShipperData(CitiMarketContext citiMarketContext)
        {
            try
            {
                citiMarketContext.Database.EnsureCreated();
                if (!citiMarketContext.Shippers.Any())
                {
                    var data = File.ReadAllText(@"C:\Users\hp\Desktop\CitiMarket\CitiMarket.DataBaseConnector\Json\Shipper.json");


                    var listOfShipper = JsonConvert.DeserializeObject<List<Shipper>>(data);
                    await citiMarketContext.Shippers.AddRangeAsync(listOfShipper);
                    await citiMarketContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task SeedOrderData(CitiMarketContext citiMarketContext)
        {
            try
            {
                citiMarketContext.Database.EnsureCreated();
                if (!citiMarketContext.Orders.Any())
                {
                    var data = File.ReadAllText(@"C:\Users\hp\Desktop\CitiMarket\CitiMarket.DataBaseConnector\Json\Order.json");


                    var listOfOrders = JsonConvert.DeserializeObject<List<Order>>(data);
                    await citiMarketContext.Orders.AddRangeAsync(listOfOrders);
                    await citiMarketContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static async Task SeedOrderDetailData(CitiMarketContext citiMarketContext)
        {
            try
            {
                citiMarketContext.Database.EnsureCreated();
                if (!citiMarketContext.OrderDetails.Any())
                {
                    var data = File.ReadAllText(@"C:\Users\hp\Desktop\CitiMarket\CitiMarket.DataBaseConnector\Json\OrderDetails.json");


                    var listOfOrderDetails = JsonConvert.DeserializeObject<List<OrderDetails>>(data);
                    await citiMarketContext.OrderDetails.AddRangeAsync(listOfOrderDetails);
                    await citiMarketContext.SaveChangesAsync();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

