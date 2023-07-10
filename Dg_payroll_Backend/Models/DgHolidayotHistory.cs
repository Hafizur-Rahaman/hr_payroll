using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgHolidayotHistory
    {
        public int Serial { get; set; }
        public int? Comid { get; set; }
        public int? EmpId { get; set; }
        public decimal? OtRate { get; set; }
        public decimal? OtHrs { get; set; }
        public decimal? OtValue { get; set; }
        public int? Month { get; set; }
        public int? Year { get; set; }
        public decimal? CalValueHot { get; set; }
    }
}
