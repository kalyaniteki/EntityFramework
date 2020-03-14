using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EFDataAccessLayer.models
{
    [Table("project")]
    public class project
    {
        [Key]//set primary key
        public int projectID { get; set; }
        [Required]// to make col as notnull
        [StringLength(30)]
        public string pname { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? sdate { get; set; }
        [Column(TypeName = "Date")]
        public DateTime? edate { get; set; }

        //set one to many relation with Employee
        public IEnumerable<Employee> Employees { get; set; }
    }
}
