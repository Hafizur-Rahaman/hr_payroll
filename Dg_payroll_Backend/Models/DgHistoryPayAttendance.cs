using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgHistoryPayAttendance
    {
        public int? AtGroupid { get; set; }
        public int? AtCompid { get; set; }
        public decimal? AtEmpSerial { get; set; }
        public string? AtProxid { get; set; }
        public DateTime? AtDate { get; set; }
        public decimal? AtIntime { get; set; }
        public DateTime? AtOutdate { get; set; }
        public decimal? AtOuttime { get; set; }
        public decimal? AtLate { get; set; }
        public decimal? AtShift { get; set; }
        public decimal? AtWorkHrs { get; set; }
        public decimal? AtWorkMin { get; set; }
        public decimal? AtOtHrs { get; set; }
        public decimal? AtOtMin { get; set; }
        public decimal? AtExotHrs { get; set; }
        public decimal? AtExotMin { get; set; }
        public string? AtStatus { get; set; }
        public string? AtStatusCode { get; set; }
        public string? AtUser { get; set; }
        public DateTime? AtUdate { get; set; }
    }
}
