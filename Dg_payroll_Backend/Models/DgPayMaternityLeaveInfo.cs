using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayMaternityLeaveInfo
    {
        public int SerialNo { get; set; }
        public int? ComCode { get; set; }
        public int? GroupId { get; set; }
        public int? EmpSerial { get; set; }
        public DateTime? DateOfFirstNotification { get; set; }
        public DateTime? ExpectedDateDelivery { get; set; }
        public DateTime? LevStartDate { get; set; }
        public DateTime? LevEndDate { get; set; }
        public string? Enteredby { get; set; }
        public string? Updatedby { get; set; }
        public DateTime? Addtime { get; set; }
        public DateTime? Updatetime { get; set; }
    }
}
