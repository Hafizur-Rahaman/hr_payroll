using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class AllProcess
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? Date { get; set; }
    }
}
