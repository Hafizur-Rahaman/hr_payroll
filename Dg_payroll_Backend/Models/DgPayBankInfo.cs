using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayBankInfo
    {
        public int BankCode { get; set; }
        public string? BankName { get; set; }
        public string? BankAddress { get; set; }
        public string? TelephoneNo { get; set; }
        public string? Fax { get; set; }
        public int? CountryCode { get; set; }
        public string? SwiftCode { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? CreatedBy { get; set; }
        public string? Bshortname { get; set; }
    }
}
