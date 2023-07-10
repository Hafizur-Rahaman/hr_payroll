using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayDistrict
    {
        public int DiId { get; set; }
        public int? DiDivid { get; set; }
        public string? DiDivname { get; set; }
        public string? DiName { get; set; }
        public int? DiGroupid { get; set; }
        public string? DiUser { get; set; }
        public DateTime? DiUdate { get; set; }
        public string? DiNameBangla { get; set; }
    }
}
