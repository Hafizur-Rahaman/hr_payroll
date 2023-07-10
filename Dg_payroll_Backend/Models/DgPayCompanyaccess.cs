using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayCompanyaccess
    {
        public int CaSerial { get; set; }
        public int? CaCompid { get; set; }
        public string? CaCompName { get; set; }
        public int? Permission { get; set; }
        public string? CaAccessuser { get; set; }
        public string? CaUser { get; set; }
        public DateTime? CaUdate { get; set; }
    }
}
