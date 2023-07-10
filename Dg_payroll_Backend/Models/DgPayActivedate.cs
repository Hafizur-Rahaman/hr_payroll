using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayActivedate
    {
        public int Sl { get; set; }
        public DateTime? PaDate { get; set; }
        public int? PaGroupid { get; set; }
        public string? PaUser { get; set; }
        public DateTime? PaUdate { get; set; }
    }
}
