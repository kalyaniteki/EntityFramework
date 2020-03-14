using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class Customer
    {
        public string Customerid { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    }
}
