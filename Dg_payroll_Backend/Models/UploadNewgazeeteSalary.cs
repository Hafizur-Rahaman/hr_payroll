using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class UploadNewgazeeteSalary
    {
        public int Slno { get; set; }
        public int? EmpId { get; set; }
        public int? PrvGross { get; set; }
        public decimal? IncAmount { get; set; }
        public decimal? CurrentGross { get; set; }
    }
}
