using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgAnnualLeaveAllucation
    {
        public int Serial { get; set; }
        public int Year { get; set; }
        public int Comid { get; set; }
        public string? ComName { get; set; }
        public int? Groupid { get; set; }
        public int? Casual { get; set; }
        public int? Madical { get; set; }
        public int? Annual { get; set; }
        public string? Enteredby { get; set; }
        public string? Updatedby { get; set; }
        public DateTime? Addtime { get; set; }
        public DateTime? Updatedtime { get; set; }
    }
}
