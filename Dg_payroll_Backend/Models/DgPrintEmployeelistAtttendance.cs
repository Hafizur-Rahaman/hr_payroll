using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPrintEmployeelistAtttendance
    {
        public int Sl { get; set; }
        public int PlEmpserial { get; set; }
        public int? PlCompid { get; set; }
        public DateTime? PlStartdate { get; set; }
        public DateTime? PlEnddate { get; set; }
        public string? PlUser { get; set; }
    }
}
