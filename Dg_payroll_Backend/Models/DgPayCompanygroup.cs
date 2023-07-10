using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayCompanygroup
    {
        public int? Gcode { get; set; }
        public string? Gname { get; set; }
        public string? Gadd { get; set; }
        public string? Gtel { get; set; }
        public string? Guser { get; set; }
        public DateTime? Gudate { get; set; }
        public DateTime? GexpDate { get; set; }
    }
}
