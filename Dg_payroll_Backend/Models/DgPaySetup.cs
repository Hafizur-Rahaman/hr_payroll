using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPaySetup
    {
        public int? SetupCode { get; set; }
        public string? SetupTitle { get; set; }
        public string SetupDescription { get; set; } = null!;
        public string? SetupStatus { get; set; }
        public decimal? SetupValue { get; set; }
        public int SetupCompGroup { get; set; }
    }
}
