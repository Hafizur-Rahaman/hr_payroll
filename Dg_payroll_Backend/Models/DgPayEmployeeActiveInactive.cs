using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayEmployeeActiveInactive
    {
        public int? AiEmpseral { get; set; }
        public bool? AiActiveInactive { get; set; }
        public DateTime? AiDate { get; set; }
        public string? AiComents { get; set; }
        public string? AiReson { get; set; }
        public string? AiUser { get; set; }
        public DateTime? AiUdate { get; set; }
    }
}
