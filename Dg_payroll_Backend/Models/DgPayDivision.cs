using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayDivision
    {
        public int DivId { get; set; }
        public string? DivName { get; set; }
        public string? DivNameBangla { get; set; }
        public int? DivGroupid { get; set; }
        public string? DivUser { get; set; }
        public DateTime? DivUdate { get; set; }
    }
}
