using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgDailySectionwiseAttSummary
    {
        public int Gid { get; set; }
        public int? ComId { get; set; }
        public string? Section { get; set; }
        public int? TotEmp { get; set; }
        public int? Present { get; set; }
        public int? Absent { get; set; }
        public int? Leave { get; set; }
        public DateTime? AttDate { get; set; }
    }
}
