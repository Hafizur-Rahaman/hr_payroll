using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgAnnualTtotalPresent
    {
        public int? ComId { get; set; }
        public DateTime? BaseOnDate { get; set; }
        public int? EmpSerial { get; set; }
        public int? TotalPresentDays { get; set; }
        public int? Groupid { get; set; }
        public int? Year { get; set; }
    }
}
