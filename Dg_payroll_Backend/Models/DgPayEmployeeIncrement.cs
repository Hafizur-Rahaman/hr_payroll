using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayEmployeeIncrement
    {
        public int Serial { get; set; }
        public decimal? SiEmpserial { get; set; }
        public DateTime? SiDate { get; set; }
        public decimal? SiBasicsalary { get; set; }
        public decimal? SiGrossalary { get; set; }
        public decimal? SiMedical { get; set; }
        public decimal? SiTraveling { get; set; }
        public decimal? SiFood { get; set; }
        public decimal? SiHouserent { get; set; }
        public decimal? SiSpacola { get; set; }
        public decimal? SiIncrement { get; set; }
        public string? SiUser { get; set; }
        public DateTime? SiUdate { get; set; }
    }
}
