using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPaySalarycategory
    {
        public int CatId { get; set; }
        public string? CatName { get; set; }
        public int? CatOt { get; set; }
        public int? CtGroupid { get; set; }
    }
}
