using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class UploadAttendance
    {
        public int Sl { get; set; }
        public string? Filename { get; set; }
        public DateTime? Udate { get; set; }
        public string? Uname { get; set; }
    }
}
