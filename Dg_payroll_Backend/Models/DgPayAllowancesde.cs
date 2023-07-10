using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayAllowancesde
    {
        public int AlCode { get; set; }
        public string? AlDescription { get; set; }
        public string? AlType { get; set; }
        public string? AlUser { get; set; }
        public DateTime? AlUdate { get; set; }
        public int? AlGroupid { get; set; }
    }
}
