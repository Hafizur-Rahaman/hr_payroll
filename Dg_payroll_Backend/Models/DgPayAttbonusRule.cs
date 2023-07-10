using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayAttbonusRule
    {
        public int AtbrSerial { get; set; }
        public int? ComId { get; set; }
        public string? ComName { get; set; }
        public int? AtbrAbsentdays { get; set; }
        public int? AtbrLate { get; set; }
        public int? AtbrLeave { get; set; }
        public int? AtbrGroupid { get; set; }
        public string? Updatedby { get; set; }
        public DateTime? Updatedtime { get; set; }
    }
}
