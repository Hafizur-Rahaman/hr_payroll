using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayProcess
    {
        public int? PrGroupid { get; set; }
        public int? PrCompid { get; set; }
        public DateTime? PrDate { get; set; }
        public string? PrUser { get; set; }
        public DateTime? PrUdate { get; set; }
        public bool? PrConfirm { get; set; }
        public string? PrConfUser { get; set; }
        public DateTime? PrConfUdate { get; set; }
    }
}
