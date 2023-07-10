using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayDesignation
    {
        public int DecId { get; set; }
        public string? DecName { get; set; }
        public string? DecNameBangla { get; set; }
        public string? DecUser { get; set; }
        public DateTime? DecUdate { get; set; }
        public int? DecGroupid { get; set; }
        public decimal? HdAllownAmt { get; set; }
    }
}
