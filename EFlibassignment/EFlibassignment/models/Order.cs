using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EFlibassignment.models
{
    [Table("Order")]
   public class Order
    {
        [Key]
        public int orderId { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? orderdate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? deliverydate { get; set; }
        [Required]
        public int itemId { get; set; }
        [ForeignKey("itemId")]
       
        public Item Item { get; set; }
             
    }
}
