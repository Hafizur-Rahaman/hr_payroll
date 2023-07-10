using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgButtonPermission
    {
        public int BSl { get; set; }
        public int BTitlecode { get; set; }
        public string BTitle { get; set; } = null!;
        public int? EmpSerial { get; set; }
        public string BUser { get; set; } = null!;
        public int BRights { get; set; }
        public DateTime BUdate { get; set; }
        public string BUadmin { get; set; } = null!;
    }
}
