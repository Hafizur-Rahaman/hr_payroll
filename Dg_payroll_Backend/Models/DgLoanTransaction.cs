using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgLoanTransaction
    {
        public int TransId { get; set; }
        public int EmpSerial { get; set; }
        public int? InstallMonth { get; set; }
        public decimal? InstallAmt { get; set; }
        public int? InstallNumber { get; set; }
        public DateTime? TransDate { get; set; }
        public string? Enteredby { get; set; }
        public string? Updatedby { get; set; }
        public DateTime? Addtime { get; set; }
        public DateTime? Updatetime { get; set; }
        public int? DueInstallNo { get; set; }
    }
}
