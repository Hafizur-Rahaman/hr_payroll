using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayDeducation
    {
        public int DSerial { get; set; }
        public decimal? DEmpSerial { get; set; }
        public int? DGroupid { get; set; }
        public int? DCompid { get; set; }
        public DateTime? DDate { get; set; }
        public int? DId { get; set; }
        public decimal? DValue { get; set; }
        public string? DUser { get; set; }
        public DateTime? DUdate { get; set; }
    }
}
