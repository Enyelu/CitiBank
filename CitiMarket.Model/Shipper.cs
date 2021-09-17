using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiMarket.Model
{
    public class Shipper
    {
        public string Id { get; set; }
        public Order order { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Number { get; set; }
       
    }
}
