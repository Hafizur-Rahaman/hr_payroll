using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayDepartment
    {
        public int NUserDept { get; set; }
        public string? CDeptname { get; set; }
        public string? Dptnamebangla { get; set; }
        public int? NCompanyId { get; set; }
        public string? NCompanyName { get; set; }
        public string? CEntUser { get; set; }
        public DateTime? DEntdt { get; set; }
        public string? CDptnameBd { get; set; }
    }
}
