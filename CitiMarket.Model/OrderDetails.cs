using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiMarket.Model
{
    public class OrderDetails
    {
        public string   Id      { get; set; }
        public string   OrderId { get; set; }
        public int      Quantity { get; set; }
        public decimal  TotalPrice { get; set; }
        public DateTime shippedDate { get; set; }
        public Order    Order   { get; set; }
        public Product  Product { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
