using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitiMarket.Model
{
   public  class Supplier
   {
        public string Id                       { get; set; }
        public string SupplierFirstName        { get; set; }
        public string SupplierLastName         { get; set; }
        public string SupplierPhoneNumber      { get; set; }
        public string SupplierEmail            { get; set; }
        public ICollection<Product> Products   { get; set; }
   }
}
