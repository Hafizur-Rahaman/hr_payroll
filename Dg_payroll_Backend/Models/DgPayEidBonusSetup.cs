using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayEidBonusSetup
    {
        public int EbSerial { get; set; }
        public int Gid { get; set; }
        public int? ComCode { get; set; }
        public string? ComName { get; set; }
        public int? Groupid { get; set; }
        public string? Type { get; set; }
        public string? Dependon { get; set; }
        public decimal? Days365 { get; set; }
        public decimal? Days270 { get; set; }
        public decimal? Days180 { get; set; }
        public decimal? Days90 { get; set; }
        public decimal? Bellowdays90 { get; set; }
        public string? Enteredby { get; set; }
        public string? Updatedby { get; set; }
        public DateTime? Addtime { get; set; }
        public DateTime? Updatetime { get; set; }
        public int? StampCharge { get; set; }
        public int? SalaryCategory { get; set; }
        public string? CategoryName { get; set; }
        public string? TypeDays365 { get; set; }
        public string? TypeDays270 { get; set; }
        public string? TypeDays180 { get; set; }
        public string? TypeDays90 { get; set; }
        public string? TypeDays90less { get; set; }
    }
}
