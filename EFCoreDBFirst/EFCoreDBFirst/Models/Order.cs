using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class Order
    {
        public int OrderId { get; set; }
        public DateTime? Orderdate { get; set; }
        public DateTime? Deliverydate { get; set; }
        public int ItemId { get; set; }

        public virtual Item Item { get; set; }
    }
}
