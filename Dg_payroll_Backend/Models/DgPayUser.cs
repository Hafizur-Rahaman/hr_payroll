using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayUser
    {
        public int NUserId { get; set; }
        public string CUserName { get; set; } = null!;
        public string? CUserFullname { get; set; }
        public string? CPassWord { get; set; }
        public int? NUlevelId { get; set; }
        public int? NUserDept { get; set; }
        public DateTime? CEntDate { get; set; }
        public int? NSectionId { get; set; }
        public string? Email { get; set; }
        public int? NCompanyId { get; set; }
        public int? NUgroup { get; set; }
        public string? ActivityStatus { get; set; }
        public string? PermissionStatus { get; set; }
        public string? ThemeName { get; set; }
        public string? ThemeImg { get; set; }
        public string? Signtr { get; set; }
        public bool? Compliance { get; set; }
        public bool? Compliance2 { get; set; }
        public string? UserType { get; set; }
    }
}
