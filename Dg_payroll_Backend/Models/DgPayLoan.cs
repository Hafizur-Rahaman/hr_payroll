using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayLoan
    {
        public int LLoanserial { get; set; }
        public int? LEmpserial { get; set; }
        public DateTime? LDate { get; set; }
        public decimal? LLoan { get; set; }
        public int? LPeriod { get; set; }
        public decimal? LRental { get; set; }
        public decimal? LBalance { get; set; }
        public int? LCat { get; set; }
        public DateTime? LStartdate { get; set; }
        public bool? LActive { get; set; }
        public string? LUser { get; set; }
        public DateTime? LUdate { get; set; }
    }
}
