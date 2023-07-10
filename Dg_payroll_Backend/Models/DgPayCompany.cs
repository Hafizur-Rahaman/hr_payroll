using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayCompany
    {
        public int ComId { get; set; }
        public string? ComName { get; set; }
        public string? ComAd1 { get; set; }
        public string? ComAd2 { get; set; }
        public string? ComTel { get; set; }
        public string? ComEmail { get; set; }
        public string? ComWeb { get; set; }
        public int? ComGid { get; set; }
        public string? ComUser { get; set; }
        public DateTime? ComUdate { get; set; }
        public string? ComNameBangla { get; set; }
        public string? ComAd1Bangla { get; set; }
        public string? ComAd2Bangla { get; set; }
    }
}
