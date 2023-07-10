using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgEmpIncrementInfo
    {
        public int ComCode { get; set; }
        public int IncId { get; set; }
        public int? EmpId { get; set; }
        public DateTime? IncDate { get; set; }
        public string? IncType { get; set; }
        public int? PreviousDesignation { get; set; }
        public int? PromotedDesig { get; set; }
        public decimal? PreviosGross { get; set; }
        public decimal? PreviousBasic { get; set; }
        public string? DependOn { get; set; }
        public decimal? IncGross { get; set; }
        public decimal? IncBasic { get; set; }
        public decimal? CurrentGross { get; set; }
        public decimal? CurrentBasic { get; set; }
        public string? Status { get; set; }
        public string? Enteredby { get; set; }
        public string? Updatedby { get; set; }
        public DateTime? Addtime { get; set; }
        public DateTime? Updatetime { get; set; }
        public string? ApproveBy { get; set; }
        public DateTime? Approvetime { get; set; }
        public string? DependGbasic { get; set; }
        public int? Housrent { get; set; }
        public string? IncTkPerson { get; set; }
        public decimal? IncPercentGss { get; set; }
        public decimal? IncPercentBasic { get; set; }
        public DateTime? CutOfDate { get; set; }
        public int? PvsHousrent { get; set; }
    }
}
