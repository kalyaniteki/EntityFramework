using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFDataAccessLayer.models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        [StringLength(5)]
        public string Eid { get; set; }
        [Required]
        [StringLength(30)]
        public string ename { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? joindate { get; set; }
        [StringLength(30)]
        public string designation { get; set; }
        public decimal? salary { get; set; }
        public int projectID { get; set; }
        //navigation property
        [ForeignKey("projectID")]
        public project project { get; set; }

         

    }
}
