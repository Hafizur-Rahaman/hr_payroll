using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgMunetitle
    {
        public decimal MtCode { get; set; }
        public string MtTitle { get; set; } = null!;
        public decimal MtSystem { get; set; }
    }
}
