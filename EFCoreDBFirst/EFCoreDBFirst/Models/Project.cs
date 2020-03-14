using System;
using System.Collections.Generic;

namespace EFCoreDBFirst.Models
{
    public partial class Project
    {
        public string ProNo { get; set; }
        public string ProName { get; set; }
        public int? Budget { get; set; }
    }
}
