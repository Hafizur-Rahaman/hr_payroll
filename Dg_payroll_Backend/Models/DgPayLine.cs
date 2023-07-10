using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayLine
    {
        public int LineCode { get; set; }
        public string? LineNo { get; set; }
        public string? LineNoBangla { get; set; }
        public int? CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public int? DepartmentId { get; set; }
        public string? DepartmentName { get; set; }
        public int? SectionId { get; set; }
        public string? SectionName { get; set; }
        public int? BuildingUnitId { get; set; }
        public string? BuildingUnitName { get; set; }
        public int? FloorId { get; set; }
        public string? FloorName { get; set; }
        public int? NMachineOp { get; set; }
        public int? NHelper { get; set; }
        public DateTime? Createdt { get; set; }
        public string? CreatedBy { get; set; }
        public string? ProdPlan { get; set; }
        public int? LineId { get; set; }
        public int? TargetInHrs { get; set; }
    }
}
