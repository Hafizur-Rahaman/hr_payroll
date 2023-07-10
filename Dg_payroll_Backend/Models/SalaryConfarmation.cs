using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class SalaryConfarmation
    {
        public int Serial { get; set; }
        public DateTime? CMonth { get; set; }
        public DateTime? CYear { get; set; }
        public int? CStatus { get; set; }
    }
}
