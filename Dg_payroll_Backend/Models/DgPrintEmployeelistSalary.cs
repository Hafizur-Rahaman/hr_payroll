using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPrintEmployeelistSalary
    {
        public int PlEmpserial { get; set; }
        public int? PlCompid { get; set; }
        public int? PlDepartment { get; set; }
        public int? PlSection { get; set; }
        public int? PlBuilding { get; set; }
        public int? PlFloor { get; set; }
        public int? PlLine { get; set; }
        public int? PlSalcat { get; set; }
        public DateTime? PlStartdate { get; set; }
        public DateTime? PlEnddate { get; set; }
        public string? PlUser { get; set; }
    }
}
