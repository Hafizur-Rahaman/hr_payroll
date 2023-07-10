using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayAnnualeearnleavePayment
    {
        public int? ComCode { get; set; }
        public int? GroupId { get; set; }
        public int LevYear { get; set; }
        public decimal EmpSerial { get; set; }
        public decimal? LevAnnualBal { get; set; }
        public decimal? AvailDays { get; set; }
        public decimal? PayableDays { get; set; }
        public decimal? RatePerDay { get; set; }
        public decimal? PayableAmt { get; set; }
        public string? Entereby { get; set; }
        public string? Updatedby { get; set; }
        public DateTime? Addtime { get; set; }
        public DateTime? Updatetime { get; set; }
        public int? StampCharge { get; set; }
    }
}
