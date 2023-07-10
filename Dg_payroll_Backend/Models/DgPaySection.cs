using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPaySection
    {
        public int NSectionId { get; set; }
        public string? CSectionDescription { get; set; }
        public string? Secnamebangla { get; set; }
        public int? NUserDept { get; set; }
        public string? NUserDeptName { get; set; }
        public int? NCarder { get; set; }
        public int? NCompanyId { get; set; }
        public string? NCompanyName { get; set; }
        public int? NFloor { get; set; }
        public string? CSupervisor { get; set; }
        public int? NMachineOperator { get; set; }
        public int? NHelper { get; set; }
        public string? CEntUser { get; set; }
        public DateTime? DEntdt { get; set; }
        public string? CSectionBdname { get; set; }
    }
}
