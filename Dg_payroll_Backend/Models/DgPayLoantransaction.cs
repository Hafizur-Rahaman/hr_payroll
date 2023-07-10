using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayLoantransaction
    {
        public int? LtEmpserial { get; set; }
        public DateTime? ItDate { get; set; }
        public int? ItPeriod { get; set; }
        public decimal? ItRental { get; set; }
        public string? ItUser { get; set; }
        public DateTime? ItUdate { get; set; }
    }
}
