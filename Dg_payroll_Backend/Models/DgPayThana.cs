using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayThana
    {
        public int ThId { get; set; }
        public int? ThDivision { get; set; }
        public string? ThDivname { get; set; }
        public int? ThDistrict { get; set; }
        public string? ThDisname { get; set; }
        public string? ThName { get; set; }
        public string? ThUser { get; set; }
        public DateTime? ThUdate { get; set; }
        public int? ThGroupid { get; set; }
        public string? ThNameBangla { get; set; }
    }
}
