using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class Employee
    {
        public int? EmpNo { get; set; }
        public string EmpFname { get; set; }
        public string EmpLname { get; set; }
        public string DeptNo { get; set; }
    }
}
