using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgEarnLivePaymenthistory
    {
        public int ComCode { get; set; }
        public int? GroupId { get; set; }
        public int Year { get; set; }
        public int? AvailedDay { get; set; }
        public string? Enteredby { get; set; }
        public DateTime? Addtime { get; set; }
    }
}
