using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayAttbonu
    {
        public int AttbSerial { get; set; }
        public int? AttbDesignation { get; set; }
        public string? AttbDesignationName { get; set; }
        public decimal? AttbValue { get; set; }
        public int? AttbCompid { get; set; }
        public string? AttbCompidName { get; set; }
        public int? AttbGroupid { get; set; }
        public string? AttbUser { get; set; }
        public DateTime? AttbUdate { get; set; }
    }
}
