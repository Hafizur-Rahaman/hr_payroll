using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayLoancategory
    {
        public int LcId { get; set; }
        public string? LcCategory { get; set; }
        public string? LcUser { get; set; }
        public DateTime? LcUdate { get; set; }
    }
}
