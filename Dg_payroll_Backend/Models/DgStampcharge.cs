using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgStampcharge
    {
        public int Id { get; set; }
        public int ComId { get; set; }
        public string? ComName { get; set; }
        public int? Stamp { get; set; }
    }
}
