using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class Item
    {
        public Item()
        {
            Order = new HashSet<Order>();
        }

        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public int? Price { get; set; }

        public virtual ICollection<Order> Order { get; set; }
    }
}
