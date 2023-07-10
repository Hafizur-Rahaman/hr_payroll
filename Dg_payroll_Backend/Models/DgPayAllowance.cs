using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayAllowance
    {
        public int AlSerial { get; set; }
        public decimal AlEmpSerial { get; set; }
        public int? AlGroupid { get; set; }
        public int? AlCompid { get; set; }
        public DateTime? AlDate { get; set; }
        public int? AlId { get; set; }
        public decimal? AlValue { get; set; }
        public string? AlUser { get; set; }
        public DateTime? AlUdate { get; set; }
    }
}
