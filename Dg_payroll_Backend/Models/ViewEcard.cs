using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class ViewEcard
    {
        public int AtEmpSerial { get; set; }
        public int? EmpNo { get; set; }
        public DateTime AtDate { get; set; }
        public decimal? AtIntime { get; set; }
        public decimal? AtOuttime { get; set; }
        public decimal? Wkhrs { get; set; }
        public decimal? Ot { get; set; }
        public decimal? Exot { get; set; }
        public decimal? Otcomp { get; set; }
        public decimal? Exotcomp { get; set; }
        public string? ShName { get; set; }
        public decimal? AtLate { get; set; }
        public int? AtCompid { get; set; }
        public string? AtStatus { get; set; }
        public string? AtStatusCode { get; set; }
        public int ShCode { get; set; }
        public int EmpSerial { get; set; }
        public bool? AtCoverday { get; set; }
        public string? AtUser { get; set; }
        public DateTime? AtUdate { get; set; }
        public int? ExotcompHr { get; set; }
        public decimal? ExotcompMin { get; set; }
        public bool? AtManual { get; set; }
        public string? AtHoliday { get; set; }
        public decimal? Whot { get; set; }
        public decimal? Othd { get; set; }
        public decimal? Exothd { get; set; }
    }
}
