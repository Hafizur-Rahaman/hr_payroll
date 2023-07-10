using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgLunchInoutSetup
    {
        public int LSerial { get; set; }
        public int? GroupId { get; set; }
        public int? ComId { get; set; }
        public string? ComName { get; set; }
        public decimal? LunchInTime { get; set; }
        public decimal? LunchOutTime { get; set; }
        public string? Enteredby { get; set; }
        public string? Updatedby { get; set; }
        public DateTime? Addtime { get; set; }
        public DateTime? Updatetime { get; set; }
    }
}
