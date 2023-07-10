using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayAttcoveringDay
    {
        public int CdSerial { get; set; }
        public DateTime? CdHday { get; set; }
        public DateTime? CdCovday { get; set; }
        public int CdCompid { get; set; }
        public string? CdCompName { get; set; }
        public int? CdGroupid { get; set; }
        public string? CdUser { get; set; }
        public DateTime? CdUdate { get; set; }
    }
}
