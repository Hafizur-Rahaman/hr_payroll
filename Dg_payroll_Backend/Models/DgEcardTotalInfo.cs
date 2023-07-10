using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgEcardTotalInfo
    {
        public int Serial { get; set; }
        public int? Comid { get; set; }
        public int? EmpId { get; set; }
        public int? Ttalpresent { get; set; }
        public int? Ttabsent { get; set; }
        public int? TotalLate { get; set; }
        public decimal? TotalWh { get; set; }
        public decimal? TotalHoliday { get; set; }
        public decimal? Ttleave { get; set; }
        public decimal? TtwHr { get; set; }
        public decimal? TtOt { get; set; }
        public decimal? TtExot { get; set; }
        public decimal? TtHdot { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public decimal? TthwHr { get; set; }
        public DateTime? Edate { get; set; }
    }
}
