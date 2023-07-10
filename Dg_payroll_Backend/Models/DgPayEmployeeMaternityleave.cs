using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayEmployeeMaternityleave
    {
        public int MlSerial { get; set; }
        public int? MlEmpserial { get; set; }
        public DateTime? MlFromdate { get; set; }
        public DateTime? MlTodate { get; set; }
        public string? MlUser { get; set; }
        public DateTime? MlUdate { get; set; }
    }
}
