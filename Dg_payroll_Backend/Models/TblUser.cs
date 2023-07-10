using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public string? FullName { get; set; }
        public string? EmailId { get; set; }
        public string? Password { get; set; }
        public string? Designation { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? CompId { get; set; }
        public string? EmpId { get; set; }
        public string? ActiveStatus { get; set; }
        public int? EmpSerial { get; set; }
        public int? Compliance { get; set; }
    }
}
