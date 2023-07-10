using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPrintShiftchange
    {
        public int PlEmpserial { get; set; }
        public int? PlCompid { get; set; }
        public DateTime? PlStartdate { get; set; }
        public DateTime? PlEnddate { get; set; }
        public string? PlUser { get; set; }
    }
}
