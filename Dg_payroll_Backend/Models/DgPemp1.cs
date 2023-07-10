using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPemp1
    {
        public int? EmpNo { get; set; }
        public decimal AtEmpSerial { get; set; }
        public string? AtProxid { get; set; }
        public DateTime AtDate { get; set; }
        public string? AtStatus { get; set; }
        public string? AtStatusCode { get; set; }
        public string? PiFullname { get; set; }
        public int? OiDesignation { get; set; }
    }
}
