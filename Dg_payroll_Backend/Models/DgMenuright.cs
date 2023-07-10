using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgMenuright
    {
        public int MSl { get; set; }
        public int MTitlecode { get; set; }
        public string MTitle { get; set; } = null!;
        public int? EmpSerial { get; set; }
        public string MUser { get; set; } = null!;
        public int MRights { get; set; }
        public DateTime MUdate { get; set; }
        public string MUadmin { get; set; } = null!;
    }
}
