using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayLoanHold
    {
        public int? LhLoanserial { get; set; }
        public DateTime? LhDatetime { get; set; }
        public string? LhUser { get; set; }
        public string? LStatus { get; set; }
    }
}
