using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayFloor
    {
        public int NFloor { get; set; }
        public string? CFloorDescriptin { get; set; }
        public string? CFloorDescriptinBangla { get; set; }
        public string? CEntUser { get; set; }
        public DateTime? DEntdt { get; set; }
        public int? BuildingUid { get; set; }
        public string? BuildingUiname { get; set; }
        public int? CompanyId { get; set; }
        public string? CompanyName { get; set; }
        public string? CFloorDescriptinBd { get; set; }
    }
}
