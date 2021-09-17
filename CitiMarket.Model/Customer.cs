using System;
using System.Collections.Generic;

namespace CitiMarket.Model
{
    public class Customer
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string LaststName { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public DateTime CreationDate { get; set; }

       
        public Address Address { get; set; }
    }
}
