using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayShift
    {
        public int ShCode { get; set; }
        public string? ShName { get; set; }
        public int? ShComp { get; set; }
        public string? ShCompName { get; set; }
        public int? ShGroupid { get; set; }
        public decimal? ShInTime { get; set; }
        public decimal? ShOutTime { get; set; }
        public decimal? ShLateafter { get; set; }
        public decimal? ShComplianceOut { get; set; }
        public decimal? ShOtcountTime { get; set; }
        public bool? ShSameDayOut { get; set; }
        public string? ShUser { get; set; }
        public DateTime? ShUdate { get; set; }
        public decimal? IntimeStart { get; set; }
        public decimal? IntimeStop { get; set; }
        public decimal? OuttimeStart { get; set; }
        public decimal? OuttimeStop { get; set; }
        public int? LunchHours { get; set; }
    }
}
