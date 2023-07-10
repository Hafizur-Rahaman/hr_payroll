using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPaySpecialholiday
    {
        public int Serial { get; set; }
        public DateTime? ShDate { get; set; }
        public string? ShDescription { get; set; }
        public int? ShCompid { get; set; }
        public string? ShCompName { get; set; }
        public int? ShGroupid { get; set; }
        public string? ShUser { get; set; }
        public DateTime? ShUdate { get; set; }
    }
}
