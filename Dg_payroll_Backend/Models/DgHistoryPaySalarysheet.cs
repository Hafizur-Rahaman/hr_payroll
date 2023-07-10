using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgHistoryPaySalarysheet
    {
        public int? SsGroupid { get; set; }
        public int? SsCompid { get; set; }
        public DateTime? SsDate { get; set; }
        public decimal? SsEmpSerial { get; set; }
        public int? SsWorkabledays { get; set; }
        public int? SsWeeklyholidays { get; set; }
        public int? SsSpecialholidays { get; set; }
        public int? SsPresentdays { get; set; }
        public int? SsAbsentdays { get; set; }
        public int? SsCasualleave { get; set; }
        public int? SsMedicalleave { get; set; }
        public int? SsAnualleave { get; set; }
        public int? SsEdays { get; set; }
        public decimal? SsBasicsalary { get; set; }
        public decimal? SsMedical { get; set; }
        public decimal? SsTraveling { get; set; }
        public decimal? SsFood { get; set; }
        public decimal? SsHouserent { get; set; }
        public decimal? SsSpacola { get; set; }
        public decimal? SsArrears { get; set; }
        public decimal? SsGrossalary { get; set; }
        public decimal? SsGrossalaryPay { get; set; }
        public decimal? SsOtherallowances { get; set; }
        public decimal? SsAbsence { get; set; }
        public decimal? SsAdvance { get; set; }
        public decimal? SsMeal { get; set; }
        public decimal? SsTax { get; set; }
        public decimal? SsPf { get; set; }
        public decimal? SsStamp { get; set; }
        public decimal? SsOtherdeduction { get; set; }
        public decimal? SsPayablesal { get; set; }
        public decimal? SsAttbonus { get; set; }
        public decimal? SsOvertimehrs { get; set; }
        public decimal? SsOvertimerate { get; set; }
        public decimal? SsOvertimevalue { get; set; }
        public decimal? SsOvertimehrsEx { get; set; }
        public decimal? SsOvertimerateEx { get; set; }
        public decimal? SsOvertimevalueEx { get; set; }
        public decimal? SsNetsalary { get; set; }
        public decimal? SsNetsalaryEx { get; set; }
        public bool? SsConfirmed { get; set; }
    }
}
