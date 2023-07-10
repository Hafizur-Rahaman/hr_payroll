using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayBuildingUnit
    {
        public int UnitCode { get; set; }
        public string? UnitName { get; set; }
        public int? CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? Createddt { get; set; }
    }
}
