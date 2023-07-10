using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayEidbonusPayment
    {
        public int? ComCode { get; set; }
        public int? Year { get; set; }
        public int? EmpId { get; set; }
        public decimal? BonusAmt { get; set; }
        public string? Enteredby { get; set; }
        public string? Updatedby { get; set; }
        public DateTime? Addtime { get; set; }
        public DateTime? Updatetime { get; set; }
    }
}
