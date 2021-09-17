
using CitiMarket.Core.Implementation;
using CitiMarket.DataBaseConnector;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using System;

namespace CitiMarket
{
    class Program
    {
        public static IServiceProvider serviceProvider;
        static void Main(string[] args)
        {
            Configuration configuration = new Configuration();
            //string connectionString = Configuration.connectingString;
            ConfigureServices();

            CitiMarketContext context = serviceProvider.GetRequiredService<CitiMarketContext>();

            CitiCommerceOperations citiCommerceOperations = new CitiCommerceOperations(context);
            citiCommerceOperations.DisplayTopSales();
        //    Configuration configuringServices = new Configuration();
        //    ConfiguringServices();
            CitiMarketContext citiMarketContext = serviceProvider.GetRequiredService<CitiMarketContext>();
            CitiMarketSeeder.SeedCustomerData(citiMarketContext).Wait();
            CitiMarketSeeder.SeedSupplierData(citiMarketContext).Wait();
            CitiMarketSeeder.SeedCategoryData(citiMarketContext).Wait();
            CitiMarketSeeder.SeedProductData(citiMarketContext).Wait();
           CitiMarketSeeder.SeedShipperData(citiMarketContext).Wait();
           CitiMarketSeeder.SeedOrderData(citiMarketContext).Wait();
            CitiMarketSeeder.SeedOrderDetailData(citiMarketContext).Wait();
        }
        //public static void ConfiguringServices()
        //{
        //    var services = new ServiceCollection();
        //    services.AddDbContext<CitiMarketContext>(options => options.UseSqlServer(connectionString));
        //    serviceProvider = services.BuildServiceProvider();
        //}
       public  static void ConfigureServices()
        {
            string connectingString = "Data Source = LAPTOP-0VSJ0RU3;Initial Catalog = CitiCommerse; Integrated Security = True";
        var services = new ServiceCollection();
            services.AddDbContext<CitiMarketContext>(options => options.UseSqlServer(connectingString));

            serviceProvider = services.BuildServiceProvider();
        }

    }
}
