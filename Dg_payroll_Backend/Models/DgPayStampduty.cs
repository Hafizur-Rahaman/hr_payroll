using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayStampduty
    {
        public int SdSalcat { get; set; }
        public decimal? SdStapduty { get; set; }
        public int SdCompid { get; set; }
        public int SdGroupid { get; set; }
        public string? SdUser { get; set; }
        public DateTime? SdUdate { get; set; }
    }
}
