using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiMarket.Model
{
    public class Product
    {
        public string Id                 { get; set; }
        public string ProductName        { get; set; }
        public string ProductDescription { get; set;}
        public decimal UnitPrice         { get; set; }
        public int Quantity              { get; set; }
        public string AvailabilityStatus     { get; set; }
        public DateTime CreationDate     { get; set; }
        ICollection<Supplier> Suppliers  { get; set; }
        public string CategoryId { get; set; }
        public Category  Category        { get; set; }
    }
}
