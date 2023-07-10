using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayLeavetransaction
    {
        public int LtrSerial { get; set; }
        public int? LtrGroupid { get; set; }
        public int? LtrCompid { get; set; }
        public DateTime LtrDate { get; set; }
        public int LtrEmpSerial { get; set; }
        public int? LtrCasual { get; set; }
        public int? LtrMedical { get; set; }
        public int? LtrAnual { get; set; }
        public string? LtrUser { get; set; }
        public DateTime? LtrUdate { get; set; }
    }
}
