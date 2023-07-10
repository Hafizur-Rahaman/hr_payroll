using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgEmpTransferInfo
    {
        public int TransId { get; set; }
        public DateTime? TransDate { get; set; }
        public int? PreEmpSerial { get; set; }
        public int? PreEmpNo { get; set; }
        public string? EmpName { get; set; }
        public int? PreDepartment { get; set; }
        public int? PreDesignation { get; set; }
        public int? PreSection { get; set; }
        public int? PreBuilding { get; set; }
        public int? PreFloor { get; set; }
        public int? PreLine { get; set; }
        public int? NewDepartment { get; set; }
        public int? NewSection { get; set; }
        public int? NewLine { get; set; }
        public int? NewFloor { get; set; }
        public int? FromCompany { get; set; }
        public int? Toconpany { get; set; }
        public string? Reason { get; set; }
        public string? Enteredby { get; set; }
        public string? Updatedby { get; set; }
        public DateTime? Addtime { get; set; }
        public DateTime? Updatetime { get; set; }
        public int? Groupid { get; set; }
        public int? NewBuilding { get; set; }
        public int? NewDesignation { get; set; }
        public string? Status { get; set; }
        public int? NewShift { get; set; }
        public int? EmpNoNew { get; set; }
        public DateTime? ConfirmedDate { get; set; }
        public string? Confirmedby { get; set; }
    }
}
