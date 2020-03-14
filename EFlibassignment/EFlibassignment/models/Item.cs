using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


namespace EFlibassignment.models
{
   [Table("Item")]
    public class Item
    {
        [Key]
        public int itemId { get; set; }
        [Required]
        public string itemName { get; set; }
        public int? price { get; set; }

        public IEnumerable<Order> Orders { get; set; }

    }
}
