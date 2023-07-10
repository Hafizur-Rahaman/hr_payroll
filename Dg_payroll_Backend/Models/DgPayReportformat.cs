using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayReportformat
    {
        public string RepId { get; set; } = null!;
        public string? RepFilename { get; set; }
        public int? RepGroupid { get; set; }
    }
}
