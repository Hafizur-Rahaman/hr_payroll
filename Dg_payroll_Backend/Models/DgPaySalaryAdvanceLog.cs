using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPaySalaryAdvanceLog
    {
        public int Serial { get; set; }
        public int? SaplCompid { get; set; }
        public DateTime? SaplDate { get; set; }
        public int? SaplDays { get; set; }
        public string? SaplUser { get; set; }
        public DateTime? SaplUdate { get; set; }
    }
}
