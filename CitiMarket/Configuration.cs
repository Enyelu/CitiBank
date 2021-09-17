using CitiMarket.DataBaseConnector;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace CitiMarket
{
    public class Configuration : IDesignTimeDbContextFactory<CitiMarketContext>
    {
        public const string connectingString = "Data Source = LAPTOP-0VSJ0RU3;Initial Catalog = CitiCommerse; Integrated Security = True";
        public IServiceProvider serviceProvider;
        

        public CitiMarketContext CreateDbContext(string[] args)
        {
            var optionBuilder = new DbContextOptionsBuilder<CitiMarketContext>();
            optionBuilder.UseSqlServer(connectingString);
            return new CitiMarketContext(optionBuilder.Options);
        }

        //CitiMarketContext IDesignTimeDbContextFactory<CitiMarketContext>.CreateDbContext(string[] args)
        //{
        //    return default;// throw new NotImplementedException();
        //}
    }
}
