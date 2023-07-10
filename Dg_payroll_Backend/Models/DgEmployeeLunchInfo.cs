using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgEmployeeLunchInfo
    {
        public int? ComCode { get; set; }
        public int? Groupid { get; set; }
        public decimal? AtEmpSerial { get; set; }
        public string? AtProxid { get; set; }
        public DateTime? AtDate { get; set; }
        public decimal? AtIntime { get; set; }
        public decimal? AtOuttime { get; set; }
    }
}
