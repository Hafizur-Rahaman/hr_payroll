using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayLeaveInfor
    {
        public int LevSerial { get; set; }
        public int? LevGroupid { get; set; }
        public int? LevCompid { get; set; }
        public int LevYear { get; set; }
        public decimal LevEmpSerial { get; set; }
        public decimal? LevCasual { get; set; }
        public decimal? LevMedical { get; set; }
        public decimal? LevAnual { get; set; }
        public decimal? LevCasualBal { get; set; }
        public decimal? LevMedicalBal { get; set; }
        public decimal? LevAnualBal { get; set; }
        public string? LevUser { get; set; }
        public DateTime? LevUdate { get; set; }
    }
}
