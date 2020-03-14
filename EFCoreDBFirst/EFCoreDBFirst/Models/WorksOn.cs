using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class WorksOn
    {
        public int Eid { get; set; }
        public string Pno { get; set; }
        public string Job { get; set; }
        public DateTime? EDate { get; set; }
    }
}
