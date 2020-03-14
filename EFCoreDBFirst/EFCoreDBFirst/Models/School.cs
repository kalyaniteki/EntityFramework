using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class School
    {
        public int Shid { get; set; }
        public string Sname { get; set; }
        public int? Strength { get; set; }
    }
}
