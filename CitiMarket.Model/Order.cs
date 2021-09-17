using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiMarket.Model
{
    public class Order
    {
        public string   Id                  { get; set; }
        public string   CustomerId          { get; set; }
        public string ShipperId             { get; set; }
        public Customer Customer            { get; set; }
        public DateTime CreationDate         { get; set; }
        public Shipper Shipper               { get; set; }
       
    }
}
