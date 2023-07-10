using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayDeductionsde
    {
        public int DCode { get; set; }
        public string? DDescription { get; set; }
        public string? DType { get; set; }
        public string? DUser { get; set; }
        public DateTime? DUdate { get; set; }
        public int? DGroupid { get; set; }
    }
}
