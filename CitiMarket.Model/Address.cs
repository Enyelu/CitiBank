using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiMarket.Model
{
    public class Address
    {
        public string Id { get; set; }
        public string HouseNum { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
