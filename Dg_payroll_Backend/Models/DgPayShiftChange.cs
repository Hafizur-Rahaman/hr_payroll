using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayShiftChange
    {
        public int ScSerial { get; set; }
        public decimal? ScEmpserial { get; set; }
        public DateTime? ScEffectDate { get; set; }
        public DateTime? ScEndDate { get; set; }
        public int? ScOldShift { get; set; }
        public int? ScNewShift { get; set; }
        public string? ScUser { get; set; }
        public DateTime? ScUdate { get; set; }
    }
}
