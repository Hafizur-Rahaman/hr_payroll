using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayTiffinBillRulesdesignationwise
    {
        public int Serial { get; set; }
        public int? GroupId { get; set; }
        public int? ComCode { get; set; }
        public decimal? UptoTime { get; set; }
        public int? Designation { get; set; }
        public int? AmountPerDay { get; set; }
        public string? Entedby { get; set; }
        public string? Updatedby { get; set; }
        public DateTime? Addtime { get; set; }
        public DateTime? Updatetime { get; set; }
    }
}
