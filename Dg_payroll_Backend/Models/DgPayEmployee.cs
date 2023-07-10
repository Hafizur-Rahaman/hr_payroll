﻿using System;
using System.Collections.Generic;

namespace Dg_payroll.Models
{
    public partial class DgPayEmployee
    {
        public int EmpSerial { get; set; }
        public int? Groupid { get; set; }
        public int? Compid { get; set; }
        public string? CompName { get; set; }
        public int? EmpNo { get; set; }
        public string? EmpRef { get; set; }
        public int? EmpProxid { get; set; }
        public string? PiFirstname { get; set; }
        public string? PiLastname { get; set; }
        public string? PiFullname { get; set; }
        public string? PiNameinbangla { get; set; }
        public string? PiPermanentAdd1 { get; set; }
        public string? PiPermanentAdd2 { get; set; }
        public string? PiPermanentAdd1Bangla { get; set; }
        public string? PiPermanentAdd2Bangla { get; set; }
        public string? PiPresentAdd1 { get; set; }
        public string? PiPresentAdd2 { get; set; }
        public string? PiPostoffice { get; set; }
        public string? PiPostofficeBangla { get; set; }
        public string? PiEmergencyno { get; set; }
        public string? PiEmpcontactno { get; set; }
        public int? PiDivision { get; set; }
        public string? PiDivisionName { get; set; }
        public int? PiDistrict { get; set; }
        public string? PiDistrictName { get; set; }
        public int? PiThana { get; set; }
        public string? PiThanaName { get; set; }
        public string? PiSex { get; set; }
        public DateTime? PiBirthdate { get; set; }
        public string? PiBloodgroup { get; set; }
        public string? PiNic { get; set; }
        public string? PiMaritalstatus { get; set; }
        public int? PiNoofchild { get; set; }
        public string? PiFarthersname { get; set; }
        public string? PiFcontactno { get; set; }
        public string? PiMothersname { get; set; }
        public string? PiMcontactno { get; set; }
        public string? PiReligoin { get; set; }
        public string? PiNationality { get; set; }
        public string? PiNominee { get; set; }
        public string? PiNomineeAd1 { get; set; }
        public string? PiNomineeAd2 { get; set; }
        public string? PiNomineeNic { get; set; }
        public string? PiSpouse { get; set; }
        public DateTime? OiJoineddate { get; set; }
        public int? OiDesignation { get; set; }
        public string? OiDesignationName { get; set; }
        public int? OiGarde { get; set; }
        public string? OiGardeName { get; set; }
        public int? OiSalcategory { get; set; }
        public string? OiSalcategoryName { get; set; }
        public int? OiDepartment { get; set; }
        public string? OiDepartmenteName { get; set; }
        public int? OiSection { get; set; }
        public string? OiSectionName { get; set; }
        public int? OiBulding { get; set; }
        public string? OiBuldingName { get; set; }
        public int? OiFloor { get; set; }
        public string? OiFloorName { get; set; }
        public int? OiLine { get; set; }
        public string? OiLineName { get; set; }
        public int? OiShift { get; set; }
        public string? OiShiftName { get; set; }
        public decimal? OiBasicsalary { get; set; }
        public decimal? OiGrossalary { get; set; }
        public decimal? OiMedical { get; set; }
        public decimal? OiTraveling { get; set; }
        public decimal? OiFood { get; set; }
        public decimal? OiHouserent { get; set; }
        public decimal? OiSpacola { get; set; }
        public decimal? OiProvidentfund { get; set; }
        public int? OiBank { get; set; }
        public string? OiBankName { get; set; }
        public string? OiBankacno { get; set; }
        public string? OiWeeklyholiday { get; set; }
        public string? OiProcessName { get; set; }
        public string? OiProcessNameBangla { get; set; }
        public DateTime? OiConfDate { get; set; }
        public bool? OiActive { get; set; }
        public DateTime? OiInactiveDate { get; set; }
        public string? OiInactiveReson { get; set; }
        public string? EmpLastedituser { get; set; }
        public DateTime? Emplasteditudate { get; set; }
        public string? EmpUser { get; set; }
        public DateTime? EmpUdate { get; set; }
        public string? PiFathernamebangla { get; set; }
        public string? PiMothernamebangla { get; set; }
        public string? GrossSalaryBangla { get; set; }
        public string? PiPresentVillageBgl { get; set; }
        public string? PiPresentPoBgl { get; set; }
        public int? PiPresentDivision { get; set; }
        public string? PiPresentDivisionName { get; set; }
        public int? PiPresentDistrict { get; set; }
        public string? PiPresentDistrictName { get; set; }
        public int? PiPresentThana { get; set; }
        public string? PiPresentThanaName { get; set; }
        public DateTime? ShiftRosteredDate { get; set; }
    }
}