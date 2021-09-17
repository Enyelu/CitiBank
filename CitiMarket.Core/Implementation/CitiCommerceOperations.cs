using CitiMarket.Core.Interface;
using CitiMarket.DataBaseConnector;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace CitiMarket.Core.Implementation
{
    public  class CitiCommerceOperations: ICitiCommerceOperations
    {
        public static IServiceProvider serviceProvider;
        CitiMarketContext citiMarketContext;


        public CitiCommerceOperations(CitiMarketContext _citiMarketContext)
        {
            this.citiMarketContext = _citiMarketContext;
        }


        public void DisplayTopSales()
        {

            //Display sales reports at least 10 customers. 

            var reportTen = citiMarketContext.OrderDetails

                .Include(a => a.Order)
                .ThenInclude(b => b.Customer)
                    .ThenInclude(d => d.Address)
                .Include(c => c.Products).ToList();

            foreach (var item in reportTen)
            {

                foreach (var column in item.Products)
                {
                    decimal totalPrice =  column.Quantity *column.UnitPrice;

                    Console.WriteLine($"{column.ProductName} {column.CreationDate} {column.Quantity} {column.AvailabilityStatus} {column.UnitPrice} {totalPrice}");
                }
            }

        }
    }
}
