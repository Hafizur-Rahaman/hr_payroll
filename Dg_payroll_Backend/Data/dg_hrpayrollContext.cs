using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Dg_payroll.Models;

namespace Dg_payroll.Data
{
    public partial class dg_hrpayrollContext : DbContext
    {
        public dg_hrpayrollContext()
        {
        }

        public dg_hrpayrollContext(DbContextOptions<dg_hrpayrollContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AllProcess> AllProcesses { get; set; } = null!;
        public virtual DbSet<DgAnnualLeaveAllucation> DgAnnualLeaveAllucations { get; set; } = null!;
        public virtual DbSet<DgAnnualTtotalPresent> DgAnnualTtotalPresents { get; set; } = null!;
        public virtual DbSet<DgButtonPermission> DgButtonPermissions { get; set; } = null!;
        public virtual DbSet<DgDailySectionwiseAttSummary> DgDailySectionwiseAttSummaries { get; set; } = null!;
        public virtual DbSet<DgEarnLivePaymenthistory> DgEarnLivePaymenthistories { get; set; } = null!;
        public virtual DbSet<DgEcardTotalInfo> DgEcardTotalInfos { get; set; } = null!;
        public virtual DbSet<DgEmpIncrementInfo> DgEmpIncrementInfos { get; set; } = null!;
        public virtual DbSet<DgEmpTransferInfo> DgEmpTransferInfos { get; set; } = null!;
        public virtual DbSet<DgEmployeeLunchInfo> DgEmployeeLunchInfos { get; set; } = null!;
        public virtual DbSet<DgHistoryPayAttendance> DgHistoryPayAttendances { get; set; } = null!;
        public virtual DbSet<DgHistoryPaySalarysheet> DgHistoryPaySalarysheets { get; set; } = null!;
        public virtual DbSet<DgHolidayotHistory> DgHolidayotHistories { get; set; } = null!;
        public virtual DbSet<DgLoanTransaction> DgLoanTransactions { get; set; } = null!;
        public virtual DbSet<DgLunchInoutSetup> DgLunchInoutSetups { get; set; } = null!;
        public virtual DbSet<DgMenuright> DgMenurights { get; set; } = null!;
        public virtual DbSet<DgMunetitle> DgMunetitles { get; set; } = null!;
        public virtual DbSet<DgPayActivedate> DgPayActivedates { get; set; } = null!;
        public virtual DbSet<DgPayAllowance> DgPayAllowances { get; set; } = null!;
        public virtual DbSet<DgPayAllowancesde> DgPayAllowancesdes { get; set; } = null!;
        public virtual DbSet<DgPayAnnualeearnleavePayment> DgPayAnnualeearnleavePayments { get; set; } = null!;
        public virtual DbSet<DgPayAttCoverignDay> DgPayAttCoverignDays { get; set; } = null!;
        public virtual DbSet<DgPayAttaataImportsetupThum> DgPayAttaataImportsetupThums { get; set; } = null!;
        public virtual DbSet<DgPayAttbonu> DgPayAttbonus { get; set; } = null!;
        public virtual DbSet<DgPayAttbonusRule> DgPayAttbonusRules { get; set; } = null!;
        public virtual DbSet<DgPayAttcoveringDay> DgPayAttcoveringDays { get; set; } = null!;
        public virtual DbSet<DgPayAttdataImportsetup> DgPayAttdataImportsetups { get; set; } = null!;
        public virtual DbSet<DgPayAttdataImportsetupFace> DgPayAttdataImportsetupFaces { get; set; } = null!;
        public virtual DbSet<DgPayAttendance> DgPayAttendances { get; set; } = null!;
        public virtual DbSet<DgPayBankInfo> DgPayBankInfos { get; set; } = null!;
        public virtual DbSet<DgPayBuildingUnit> DgPayBuildingUnits { get; set; } = null!;
        public virtual DbSet<DgPayCompany> DgPayCompanies { get; set; } = null!;
        public virtual DbSet<DgPayCompanyaccess> DgPayCompanyaccesses { get; set; } = null!;
        public virtual DbSet<DgPayCompanygroup> DgPayCompanygroups { get; set; } = null!;
        public virtual DbSet<DgPayDeducation> DgPayDeducations { get; set; } = null!;
        public virtual DbSet<DgPayDeductionsde> DgPayDeductionsdes { get; set; } = null!;
        public virtual DbSet<DgPayDepartment> DgPayDepartments { get; set; } = null!;
        public virtual DbSet<DgPayDesignation> DgPayDesignations { get; set; } = null!;
        public virtual DbSet<DgPayDistrict> DgPayDistricts { get; set; } = null!;
        public virtual DbSet<DgPayDivision> DgPayDivisions { get; set; } = null!;
        public virtual DbSet<DgPayEidBonusSetup> DgPayEidBonusSetups { get; set; } = null!;
        public virtual DbSet<DgPayEidbonusPayment> DgPayEidbonusPayments { get; set; } = null!;
        public virtual DbSet<DgPayEmployee> DgPayEmployees { get; set; } = null!;
        public virtual DbSet<DgPayEmployeeActiveInactive> DgPayEmployeeActiveInactives { get; set; } = null!;
        public virtual DbSet<DgPayEmployeeIncrement> DgPayEmployeeIncrements { get; set; } = null!;
        public virtual DbSet<DgPayEmployeeMaternityleave> DgPayEmployeeMaternityleaves { get; set; } = null!;
        public virtual DbSet<DgPayEmployeedbnrRemoveThi> DgPayEmployeedbnrRemoveThis { get; set; } = null!;
        public virtual DbSet<DgPayFloor> DgPayFloors { get; set; } = null!;
        public virtual DbSet<DgPayGrade> DgPayGrades { get; set; } = null!;
        public virtual DbSet<DgPayLeaveInfor> DgPayLeaveInfors { get; set; } = null!;
        public virtual DbSet<DgPayLeavetransaction> DgPayLeavetransactions { get; set; } = null!;
        public virtual DbSet<DgPayLine> DgPayLines { get; set; } = null!;
        public virtual DbSet<DgPayLoan> DgPayLoans { get; set; } = null!;
        public virtual DbSet<DgPayLoanHold> DgPayLoanHolds { get; set; } = null!;
        public virtual DbSet<DgPayLoancategory> DgPayLoancategories { get; set; } = null!;
        public virtual DbSet<DgPayLoantransaction> DgPayLoantransactions { get; set; } = null!;
        public virtual DbSet<DgPayMaternityLeaveInfo> DgPayMaternityLeaveInfos { get; set; } = null!;
        public virtual DbSet<DgPayMonthlyattendance> DgPayMonthlyattendances { get; set; } = null!;
        public virtual DbSet<DgPayProcess> DgPayProcesses { get; set; } = null!;
        public virtual DbSet<DgPayReportformat> DgPayReportformats { get; set; } = null!;
        public virtual DbSet<DgPayReportname> DgPayReportnames { get; set; } = null!;
        public virtual DbSet<DgPaySalaryAdvance> DgPaySalaryAdvances { get; set; } = null!;
        public virtual DbSet<DgPaySalaryAdvanceLog> DgPaySalaryAdvanceLogs { get; set; } = null!;
        public virtual DbSet<DgPaySalarycategory> DgPaySalarycategories { get; set; } = null!;
        public virtual DbSet<DgPaySalaryconfirmation> DgPaySalaryconfirmations { get; set; } = null!;
        public virtual DbSet<DgPaySalarysheet> DgPaySalarysheets { get; set; } = null!;
        public virtual DbSet<DgPaySection> DgPaySections { get; set; } = null!;
        public virtual DbSet<DgPaySetup> DgPaySetups { get; set; } = null!;
        public virtual DbSet<DgPayShift> DgPayShifts { get; set; } = null!;
        public virtual DbSet<DgPayShiftChange> DgPayShiftChanges { get; set; } = null!;
        public virtual DbSet<DgPaySpecialholiday> DgPaySpecialholidays { get; set; } = null!;
        public virtual DbSet<DgPayStampduty> DgPayStampduties { get; set; } = null!;
        public virtual DbSet<DgPayThana> DgPayThanas { get; set; } = null!;
        public virtual DbSet<DgPayTiffinBillRulesdesignationwise> DgPayTiffinBillRulesdesignationwises { get; set; } = null!;
        public virtual DbSet<DgPayTiffinbillrule> DgPayTiffinbillrules { get; set; } = null!;
        public virtual DbSet<DgPayUser> DgPayUsers { get; set; } = null!;
        public virtual DbSet<DgPemp1> DgPemp1s { get; set; } = null!;
        public virtual DbSet<DgPrintEmployeelist> DgPrintEmployeelists { get; set; } = null!;
        public virtual DbSet<DgPrintEmployeelistAtttendance> DgPrintEmployeelistAtttendances { get; set; } = null!;
        public virtual DbSet<DgPrintEmployeelistLeave> DgPrintEmployeelistLeaves { get; set; } = null!;
        public virtual DbSet<DgPrintEmployeelistSalary> DgPrintEmployeelistSalaries { get; set; } = null!;
        public virtual DbSet<DgPrintShiftchange> DgPrintShiftchanges { get; set; } = null!;
        public virtual DbSet<DgStampcharge> DgStampcharges { get; set; } = null!;
        public virtual DbSet<ECard> ECards { get; set; } = null!;
        public virtual DbSet<SalaryConfarmation> SalaryConfarmations { get; set; } = null!;
        public virtual DbSet<Serial> Serials { get; set; } = null!;
        public virtual DbSet<Table1> Table1s { get; set; } = null!;
        public virtual DbSet<TblUser> TblUsers { get; set; } = null!;
        public virtual DbSet<UploadAttendance> UploadAttendances { get; set; } = null!;
        public virtual DbSet<UploadNewgazeeteSalary> UploadNewgazeeteSalaries { get; set; } = null!;
        public virtual DbSet<ViewEcard> ViewEcards { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AllProcess>(entity =>
            {
                entity.ToTable("All_process");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<DgAnnualLeaveAllucation>(entity =>
            {
                entity.HasKey(e => new { e.Serial, e.Year, e.Comid })
                    .HasName("PK_Annual_Leave_Allucation");

                entity.ToTable("dg_annual_leave_allucation");

                entity.Property(e => e.Serial)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("serial");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.Property(e => e.Comid).HasColumnName("comid");

                entity.Property(e => e.Addtime)
                    .HasColumnType("datetime")
                    .HasColumnName("addtime");

                entity.Property(e => e.Annual).HasColumnName("annual");

                entity.Property(e => e.Casual).HasColumnName("casual");

                entity.Property(e => e.ComName)
                    .HasMaxLength(50)
                    .HasColumnName("comName");

                entity.Property(e => e.Enteredby)
                    .HasMaxLength(30)
                    .HasColumnName("enteredby");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.Madical).HasColumnName("madical");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(30)
                    .HasColumnName("updatedby");

                entity.Property(e => e.Updatedtime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedtime");
            });

            modelBuilder.Entity<DgAnnualTtotalPresent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_annual_ttotal_present");

                entity.Property(e => e.BaseOnDate)
                    .HasColumnType("date")
                    .HasColumnName("base_on_date");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.EmpSerial).HasColumnName("emp_serial");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.TotalPresentDays).HasColumnName("total_presentDays");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<DgButtonPermission>(entity =>
            {
                entity.HasKey(e => e.BSl);

                entity.ToTable("dg_button_permissions");

                entity.Property(e => e.BSl).HasColumnName("b_sl");

                entity.Property(e => e.BRights).HasColumnName("b_rights");

                entity.Property(e => e.BTitle)
                    .HasMaxLength(100)
                    .HasColumnName("b_title");

                entity.Property(e => e.BTitlecode).HasColumnName("b_titlecode");

                entity.Property(e => e.BUadmin)
                    .HasMaxLength(10)
                    .HasColumnName("b_uadmin");

                entity.Property(e => e.BUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("b_udate");

                entity.Property(e => e.BUser)
                    .HasMaxLength(10)
                    .HasColumnName("b_user");

                entity.Property(e => e.EmpSerial).HasColumnName("Emp_serial");
            });

            modelBuilder.Entity<DgDailySectionwiseAttSummary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_daily_sectionwise_att_summary");

                entity.Property(e => e.AttDate)
                    .HasColumnType("datetime")
                    .HasColumnName("att_date");

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.Gid)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("gid");

                entity.Property(e => e.Section).HasMaxLength(50);
            });

            modelBuilder.Entity<DgEarnLivePaymenthistory>(entity =>
            {
                entity.HasKey(e => new { e.ComCode, e.Year })
                    .HasName("PK_Earn_Live_paymentHistory");

                entity.ToTable("dg_earn_live_paymenthistory");

                entity.Property(e => e.ComCode).HasColumnName("com_code");

                entity.Property(e => e.Addtime)
                    .HasColumnType("datetime")
                    .HasColumnName("addtime");

                entity.Property(e => e.AvailedDay).HasColumnName("availedDay");

                entity.Property(e => e.Enteredby)
                    .HasMaxLength(50)
                    .HasColumnName("enteredby");

                entity.Property(e => e.GroupId).HasColumnName("groupID");
            });

            modelBuilder.Entity<DgEcardTotalInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_ECard_Total_Info");

                entity.Property(e => e.Comid).HasColumnName("comid");

                entity.Property(e => e.Edate).HasColumnType("date");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.Serial)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("serial");

                entity.Property(e => e.TotalHoliday)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("totalHoliday");

                entity.Property(e => e.TotalLate).HasColumnName("total_late");

                entity.Property(e => e.TotalWh)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("total_WH");

                entity.Property(e => e.TtExot)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ttEXOT");

                entity.Property(e => e.TtHdot)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("Tt_HDOT");

                entity.Property(e => e.TtOt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ttOT");

                entity.Property(e => e.Ttabsent).HasColumnName("ttabsent");

                entity.Property(e => e.Ttalpresent).HasColumnName("ttalpresent");

                entity.Property(e => e.TthwHr)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TTHwHR");

                entity.Property(e => e.Ttleave)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ttleave");

                entity.Property(e => e.TtwHr)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("TTwHR");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<DgEmpIncrementInfo>(entity =>
            {
                entity.HasKey(e => e.IncId);

                entity.ToTable("dg_emp_increment_info");

                entity.Property(e => e.IncId).HasColumnName("inc_id");

                entity.Property(e => e.Addtime)
                    .HasColumnType("datetime")
                    .HasColumnName("addtime");

                entity.Property(e => e.ApproveBy)
                    .HasMaxLength(30)
                    .HasColumnName("approveBy");

                entity.Property(e => e.Approvetime)
                    .HasColumnType("datetime")
                    .HasColumnName("approvetime");

                entity.Property(e => e.ComCode).HasColumnName("com_code");

                entity.Property(e => e.CurrentBasic)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("current_basic");

                entity.Property(e => e.CurrentGross)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("current_gross");

                entity.Property(e => e.CutOfDate)
                    .HasColumnType("date")
                    .HasColumnName("cut_of_date");

                entity.Property(e => e.DependGbasic)
                    .HasMaxLength(30)
                    .HasColumnName("DependGBasic");

                entity.Property(e => e.DependOn)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("depend_on");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.Enteredby)
                    .HasMaxLength(30)
                    .HasColumnName("enteredby");

                entity.Property(e => e.Housrent).HasColumnName("housrent");

                entity.Property(e => e.IncBasic)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("inc_basic");

                entity.Property(e => e.IncDate)
                    .HasColumnType("date")
                    .HasColumnName("inc_date");

                entity.Property(e => e.IncGross)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("inc_gross");

                entity.Property(e => e.IncPercentBasic)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("inc_percent_Basic");

                entity.Property(e => e.IncPercentGss)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("inc_percent_gss");

                entity.Property(e => e.IncTkPerson)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .HasColumnName("inc_tk_person");

                entity.Property(e => e.IncType)
                    .HasMaxLength(50)
                    .HasColumnName("inc_type");

                entity.Property(e => e.PreviosGross)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("previos_gross");

                entity.Property(e => e.PreviousBasic)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("previous_basic");

                entity.Property(e => e.PreviousDesignation).HasColumnName("previous_Designation");

                entity.Property(e => e.PromotedDesig).HasColumnName("Promoted_Desig");

                entity.Property(e => e.PvsHousrent).HasColumnName("PVS_housrent");

                entity.Property(e => e.Status)
                    .HasMaxLength(20)
                    .HasColumnName("status");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(30)
                    .HasColumnName("updatedby");

                entity.Property(e => e.Updatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatetime");
            });

            modelBuilder.Entity<DgEmpTransferInfo>(entity =>
            {
                entity.HasKey(e => e.TransId);

                entity.ToTable("dg_emp_transfer_info");

                entity.Property(e => e.TransId).HasColumnName("trans_id");

                entity.Property(e => e.Addtime)
                    .HasColumnType("datetime")
                    .HasColumnName("addtime");

                entity.Property(e => e.ConfirmedDate)
                    .HasColumnType("datetime")
                    .HasColumnName("confirmed_date");

                entity.Property(e => e.Confirmedby)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("confirmedby");

                entity.Property(e => e.EmpName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("emp_name");

                entity.Property(e => e.EmpNoNew).HasColumnName("emp_no_new");

                entity.Property(e => e.Enteredby)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("enteredby");

                entity.Property(e => e.FromCompany).HasColumnName("From_company");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.NewBuilding).HasColumnName("new_building");

                entity.Property(e => e.NewDepartment).HasColumnName("new_Department");

                entity.Property(e => e.NewDesignation).HasColumnName("new_designation");

                entity.Property(e => e.NewFloor).HasColumnName("new_floor");

                entity.Property(e => e.NewLine).HasColumnName("new_line");

                entity.Property(e => e.NewSection).HasColumnName("new_section");

                entity.Property(e => e.NewShift).HasColumnName("new_shift");

                entity.Property(e => e.PreBuilding).HasColumnName("pre_building");

                entity.Property(e => e.PreDepartment).HasColumnName("pre_department");

                entity.Property(e => e.PreDesignation).HasColumnName("pre_designation");

                entity.Property(e => e.PreEmpNo).HasColumnName("pre_emp_no");

                entity.Property(e => e.PreEmpSerial).HasColumnName("pre_emp_serial");

                entity.Property(e => e.PreFloor).HasColumnName("pre_floor");

                entity.Property(e => e.PreLine).HasColumnName("pre_line");

                entity.Property(e => e.PreSection).HasColumnName("pre_section");

                entity.Property(e => e.Reason)
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("reason");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Open')");

                entity.Property(e => e.Toconpany).HasColumnName("toconpany");

                entity.Property(e => e.TransDate)
                    .HasColumnType("date")
                    .HasColumnName("trans_date");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("updatedby");

                entity.Property(e => e.Updatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatetime");
            });

            modelBuilder.Entity<DgEmployeeLunchInfo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_employee_lunch_info");

                entity.Property(e => e.AtDate)
                    .HasColumnType("date")
                    .HasColumnName("at_date");

                entity.Property(e => e.AtEmpSerial)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("at_emp_serial");

                entity.Property(e => e.AtIntime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_intime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtOuttime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_outtime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtProxid)
                    .HasMaxLength(10)
                    .HasColumnName("at_proxid");

                entity.Property(e => e.ComCode).HasColumnName("com_code");

                entity.Property(e => e.Groupid).HasColumnName("groupid");
            });

            modelBuilder.Entity<DgHistoryPayAttendance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_history_pay_attendance");

                entity.Property(e => e.AtCompid).HasColumnName("at_compid");

                entity.Property(e => e.AtDate)
                    .HasColumnType("date")
                    .HasColumnName("at_date");

                entity.Property(e => e.AtEmpSerial)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("at_emp_serial");

                entity.Property(e => e.AtExotHrs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_exot_hrs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtExotMin)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_exot_min")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtGroupid).HasColumnName("at_groupid");

                entity.Property(e => e.AtIntime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_intime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtLate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_late")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtOtHrs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_ot_hrs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtOtMin)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_ot_min")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtOutdate)
                    .HasColumnType("date")
                    .HasColumnName("at_outdate");

                entity.Property(e => e.AtOuttime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_outtime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtProxid)
                    .HasMaxLength(10)
                    .HasColumnName("at_proxid");

                entity.Property(e => e.AtShift)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_shift")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtStatus)
                    .HasMaxLength(30)
                    .HasColumnName("at_status");

                entity.Property(e => e.AtStatusCode)
                    .HasMaxLength(3)
                    .HasColumnName("at_status_code");

                entity.Property(e => e.AtUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("at_udate");

                entity.Property(e => e.AtUser)
                    .HasMaxLength(15)
                    .HasColumnName("at_user");

                entity.Property(e => e.AtWorkHrs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_work_hrs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtWorkMin)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_work_min")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DgHistoryPaySalarysheet>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_history_pay_salarysheet");

                entity.Property(e => e.SsAbsence)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_absence");

                entity.Property(e => e.SsAbsentdays).HasColumnName("ss_absentdays");

                entity.Property(e => e.SsAdvance)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_advance");

                entity.Property(e => e.SsAnualleave).HasColumnName("ss_anualleave");

                entity.Property(e => e.SsArrears)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_arrears")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsAttbonus)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_attbonus");

                entity.Property(e => e.SsBasicsalary)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_basicsalary")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsCasualleave).HasColumnName("ss_casualleave");

                entity.Property(e => e.SsCompid).HasColumnName("ss_compid");

                entity.Property(e => e.SsConfirmed)
                    .HasColumnName("ss_confirmed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsDate)
                    .HasColumnType("date")
                    .HasColumnName("ss_date");

                entity.Property(e => e.SsEdays).HasColumnName("ss_edays");

                entity.Property(e => e.SsEmpSerial)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_emp_serial");

                entity.Property(e => e.SsFood)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_food")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsGrossalary)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_grossalary")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsGrossalaryPay)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_grossalaryPay")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsGroupid).HasColumnName("ss_groupid");

                entity.Property(e => e.SsHouserent)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_houserent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsMeal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_meal");

                entity.Property(e => e.SsMedical)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_medical")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsMedicalleave).HasColumnName("ss_medicalleave");

                entity.Property(e => e.SsNetsalary)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_netsalary");

                entity.Property(e => e.SsNetsalaryEx)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_netsalaryEX");

                entity.Property(e => e.SsOtherallowances)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_otherallowances");

                entity.Property(e => e.SsOtherdeduction)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_otherdeduction");

                entity.Property(e => e.SsOvertimehrs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ss_overtimehrs");

                entity.Property(e => e.SsOvertimehrsEx)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ss_overtimehrsEX");

                entity.Property(e => e.SsOvertimerate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ss_overtimerate");

                entity.Property(e => e.SsOvertimerateEx)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ss_overtimerateEX");

                entity.Property(e => e.SsOvertimevalue)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_overtimevalue");

                entity.Property(e => e.SsOvertimevalueEx)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_overtimevalueEX");

                entity.Property(e => e.SsPayablesal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_payablesal");

                entity.Property(e => e.SsPf)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_pf");

                entity.Property(e => e.SsPresentdays).HasColumnName("ss_presentdays");

                entity.Property(e => e.SsSpacola)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_spacola")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsSpecialholidays).HasColumnName("ss_specialholidays");

                entity.Property(e => e.SsStamp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_stamp");

                entity.Property(e => e.SsTax)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_tax");

                entity.Property(e => e.SsTraveling)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_traveling")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsWeeklyholidays).HasColumnName("ss_weeklyholidays");

                entity.Property(e => e.SsWorkabledays).HasColumnName("ss_workabledays");
            });

            modelBuilder.Entity<DgHolidayotHistory>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_holidayot_history");

                entity.Property(e => e.CalValueHot)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("cal_valueHOT");

                entity.Property(e => e.Comid).HasColumnName("comid");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.Month).HasColumnName("month");

                entity.Property(e => e.OtHrs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ot_hrs");

                entity.Property(e => e.OtRate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ot_rate");

                entity.Property(e => e.OtValue)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ot_value");

                entity.Property(e => e.Serial)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("serial");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<DgLoanTransaction>(entity =>
            {
                entity.HasKey(e => new { e.TransId, e.EmpSerial })
                    .HasName("PK_Loan_Transaction");

                entity.ToTable("dg_loan_transaction");

                entity.Property(e => e.TransId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("trans_id");

                entity.Property(e => e.EmpSerial).HasColumnName("emp_serial");

                entity.Property(e => e.Addtime)
                    .HasColumnType("datetime")
                    .HasColumnName("addtime");

                entity.Property(e => e.DueInstallNo).HasColumnName("due_install_no");

                entity.Property(e => e.Enteredby)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("enteredby");

                entity.Property(e => e.InstallAmt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("install_amt");

                entity.Property(e => e.InstallMonth).HasColumnName("install_month");

                entity.Property(e => e.InstallNumber)
                    .HasColumnName("install_number")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.TransDate)
                    .HasColumnType("datetime")
                    .HasColumnName("trans_date");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("updatedby");

                entity.Property(e => e.Updatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatetime");
            });

            modelBuilder.Entity<DgLunchInoutSetup>(entity =>
            {
                entity.HasKey(e => e.LSerial);

                entity.ToTable("dg_lunch_inout_setup");

                entity.Property(e => e.LSerial).HasColumnName("l_serial");

                entity.Property(e => e.Addtime)
                    .HasColumnType("datetime")
                    .HasColumnName("addtime");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.ComName)
                    .HasMaxLength(50)
                    .HasColumnName("com_Name");

                entity.Property(e => e.Enteredby)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("enteredby");

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.LunchInTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("lunch_inTime");

                entity.Property(e => e.LunchOutTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("lunch_outTime");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(30)
                    .HasColumnName("updatedby");

                entity.Property(e => e.Updatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatetime");
            });

            modelBuilder.Entity<DgMenuright>(entity =>
            {
                entity.HasKey(e => e.MSl);

                entity.ToTable("dg_menurights");

                entity.Property(e => e.MSl).HasColumnName("m_sl");

                entity.Property(e => e.EmpSerial).HasColumnName("Emp_serial");

                entity.Property(e => e.MRights).HasColumnName("m_rights");

                entity.Property(e => e.MTitle)
                    .HasMaxLength(100)
                    .HasColumnName("m_title");

                entity.Property(e => e.MTitlecode).HasColumnName("m_titlecode");

                entity.Property(e => e.MUadmin)
                    .HasMaxLength(10)
                    .HasColumnName("m_uadmin");

                entity.Property(e => e.MUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("m_udate");

                entity.Property(e => e.MUser)
                    .HasMaxLength(10)
                    .HasColumnName("m_user");
            });

            modelBuilder.Entity<DgMunetitle>(entity =>
            {
                entity.HasKey(e => e.MtCode)
                    .HasName("PK_Munetitles");

                entity.ToTable("dg_munetitles");

                entity.Property(e => e.MtCode)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("mt_code");

                entity.Property(e => e.MtSystem)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("mt_system");

                entity.Property(e => e.MtTitle)
                    .HasMaxLength(50)
                    .HasColumnName("mt_title");
            });

            modelBuilder.Entity<DgPayActivedate>(entity =>
            {
                entity.HasKey(e => e.Sl);

                entity.ToTable("dg_pay_activedate");

                entity.Property(e => e.Sl).HasColumnName("sl");

                entity.Property(e => e.PaDate)
                    .HasColumnType("date")
                    .HasColumnName("pa_date");

                entity.Property(e => e.PaGroupid).HasColumnName("pa_groupid");

                entity.Property(e => e.PaUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("pa_udate");

                entity.Property(e => e.PaUser)
                    .HasMaxLength(15)
                    .HasColumnName("pa_user");
            });

            modelBuilder.Entity<DgPayAllowance>(entity =>
            {
                entity.HasKey(e => e.AlSerial)
                    .HasName("PK_dg_pay_allowances_1");

                entity.ToTable("dg_pay_allowances");

                entity.Property(e => e.AlSerial).HasColumnName("al_serial");

                entity.Property(e => e.AlCompid).HasColumnName("al_compid");

                entity.Property(e => e.AlDate)
                    .HasColumnType("date")
                    .HasColumnName("al_date");

                entity.Property(e => e.AlEmpSerial)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("al_emp_serial");

                entity.Property(e => e.AlGroupid).HasColumnName("al_groupid");

                entity.Property(e => e.AlId).HasColumnName("al_id");

                entity.Property(e => e.AlUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("al_udate");

                entity.Property(e => e.AlUser)
                    .HasMaxLength(15)
                    .HasColumnName("al_user");

                entity.Property(e => e.AlValue)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("al_value");
            });

            modelBuilder.Entity<DgPayAllowancesde>(entity =>
            {
                entity.HasKey(e => e.AlCode)
                    .HasName("PK_Pay_AllowancesDes");

                entity.ToTable("dg_pay_allowancesdes");

                entity.Property(e => e.AlCode).HasColumnName("al_code");

                entity.Property(e => e.AlDescription)
                    .HasMaxLength(20)
                    .HasColumnName("al_description");

                entity.Property(e => e.AlGroupid).HasColumnName("al_groupid");

                entity.Property(e => e.AlType)
                    .HasMaxLength(2)
                    .HasColumnName("al_type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AlUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("al_udate");

                entity.Property(e => e.AlUser)
                    .HasMaxLength(15)
                    .HasColumnName("al_user");
            });

            modelBuilder.Entity<DgPayAnnualeearnleavePayment>(entity =>
            {
                entity.HasKey(e => new { e.LevYear, e.EmpSerial })
                    .HasName("PK_Pay_AnnualEarnleave_Payment");

                entity.ToTable("dg_pay_annualeearnleave_payment");

                entity.Property(e => e.LevYear).HasColumnName("lev_year");

                entity.Property(e => e.EmpSerial)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("emp_serial");

                entity.Property(e => e.Addtime)
                    .HasColumnType("datetime")
                    .HasColumnName("addtime");

                entity.Property(e => e.AvailDays)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("avail_days");

                entity.Property(e => e.ComCode).HasColumnName("com_code");

                entity.Property(e => e.Entereby)
                    .HasMaxLength(50)
                    .HasColumnName("entereby");

                entity.Property(e => e.GroupId).HasColumnName("group_id");

                entity.Property(e => e.LevAnnualBal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("lev_annual_bal");

                entity.Property(e => e.PayableAmt)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("payable_amt");

                entity.Property(e => e.PayableDays)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("payableDays");

                entity.Property(e => e.RatePerDay)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("rate_per_day");

                entity.Property(e => e.StampCharge).HasColumnName("stampCharge");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(50)
                    .HasColumnName("updatedby");

                entity.Property(e => e.Updatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatetime");
            });

            modelBuilder.Entity<DgPayAttCoverignDay>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_Pay_AttCoverign_Days");

                entity.Property(e => e.CdCompid).HasColumnName("cd_compid");

                entity.Property(e => e.CdCovday)
                    .HasColumnType("date")
                    .HasColumnName("cd_covday");

                entity.Property(e => e.CdGroupid).HasColumnName("cd_groupid");

                entity.Property(e => e.CdHday)
                    .HasColumnType("date")
                    .HasColumnName("cd_hday");

                entity.Property(e => e.CdUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("cd_udate");

                entity.Property(e => e.CdUser)
                    .HasMaxLength(15)
                    .HasColumnName("cd_user");
            });

            modelBuilder.Entity<DgPayAttaataImportsetupThum>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_pay_attaataImportsetup_thum");

                entity.Property(e => e.AdiCode)
                    .HasMaxLength(10)
                    .HasColumnName("adi_code");

                entity.Property(e => e.AdiCompany).HasColumnName("adi_company");

                entity.Property(e => e.AdiGroupid).HasColumnName("adi_groupid");

                entity.Property(e => e.AdiNoofposition).HasColumnName("adi_noofposition");

                entity.Property(e => e.AdiStposition).HasColumnName("adi_stposition");
            });

            modelBuilder.Entity<DgPayAttbonu>(entity =>
            {
                entity.HasKey(e => e.AttbSerial);

                entity.ToTable("dg_pay_attbonus");

                entity.Property(e => e.AttbSerial).HasColumnName("attb_serial");

                entity.Property(e => e.AttbCompid).HasColumnName("attb_compid");

                entity.Property(e => e.AttbCompidName)
                    .HasMaxLength(50)
                    .HasColumnName("attb_compidName");

                entity.Property(e => e.AttbDesignation).HasColumnName("attb_designation");

                entity.Property(e => e.AttbDesignationName)
                    .HasMaxLength(50)
                    .HasColumnName("attb_designationName");

                entity.Property(e => e.AttbGroupid).HasColumnName("attb_groupid");

                entity.Property(e => e.AttbUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("attb_udate");

                entity.Property(e => e.AttbUser)
                    .HasMaxLength(10)
                    .HasColumnName("attb_user");

                entity.Property(e => e.AttbValue)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("attb_value")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DgPayAttbonusRule>(entity =>
            {
                entity.HasKey(e => e.AtbrSerial);

                entity.ToTable("dg_pay_attbonus_rules");

                entity.Property(e => e.AtbrSerial).HasColumnName("atbr_serial");

                entity.Property(e => e.AtbrAbsentdays).HasColumnName("atbr_absentdays");

                entity.Property(e => e.AtbrGroupid).HasColumnName("atbr_groupid");

                entity.Property(e => e.AtbrLate).HasColumnName("atbr_late");

                entity.Property(e => e.AtbrLeave).HasColumnName("atbr_leave");

                entity.Property(e => e.ComId).HasColumnName("ComID");

                entity.Property(e => e.ComName).HasMaxLength(50);

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(30)
                    .HasColumnName("updatedby");

                entity.Property(e => e.Updatedtime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatedtime");
            });

            modelBuilder.Entity<DgPayAttcoveringDay>(entity =>
            {
                entity.HasKey(e => e.CdSerial)
                    .HasName("PK_dg_pay_attcoverign_days");

                entity.ToTable("dg_pay_attcovering_days");

                entity.Property(e => e.CdSerial).HasColumnName("cd_serial");

                entity.Property(e => e.CdCompName)
                    .HasMaxLength(50)
                    .HasColumnName("cd_compName");

                entity.Property(e => e.CdCompid).HasColumnName("cd_compid");

                entity.Property(e => e.CdCovday)
                    .HasColumnType("date")
                    .HasColumnName("cd_covday");

                entity.Property(e => e.CdGroupid).HasColumnName("cd_groupid");

                entity.Property(e => e.CdHday)
                    .HasColumnType("date")
                    .HasColumnName("cd_hday");

                entity.Property(e => e.CdUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("cd_udate");

                entity.Property(e => e.CdUser)
                    .HasMaxLength(15)
                    .HasColumnName("cd_user");
            });

            modelBuilder.Entity<DgPayAttdataImportsetup>(entity =>
            {
                entity.HasKey(e => e.Sl);

                entity.ToTable("dg_pay_attdataImportsetup");

                entity.Property(e => e.Sl).HasColumnName("sl");

                entity.Property(e => e.AdiCode)
                    .HasMaxLength(10)
                    .HasColumnName("adi_code");

                entity.Property(e => e.AdiCompany).HasColumnName("adi_company");

                entity.Property(e => e.AdiGroupid).HasColumnName("adi_groupid");

                entity.Property(e => e.AdiNoofposition).HasColumnName("adi_noofposition");

                entity.Property(e => e.AdiStposition).HasColumnName("adi_stposition");
            });

            modelBuilder.Entity<DgPayAttdataImportsetupFace>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_pay_attdataImportsetup_face");

                entity.Property(e => e.AdiCode)
                    .HasMaxLength(10)
                    .HasColumnName("adi_code");

                entity.Property(e => e.AdiCompany).HasColumnName("adi_company");

                entity.Property(e => e.AdiGroupid).HasColumnName("adi_groupid");

                entity.Property(e => e.AdiNoofposition).HasColumnName("adi_noofposition");

                entity.Property(e => e.AdiStposition).HasColumnName("adi_stposition");
            });

            modelBuilder.Entity<DgPayAttendance>(entity =>
            {
                entity.HasKey(e => new { e.AtEmpSerial, e.AtDate })
                    .HasName("PK_Pay_Attendance")
                    .IsClustered(false);

                entity.ToTable("dg_pay_attendance");

                entity.Property(e => e.AtEmpSerial).HasColumnName("at_emp_serial");

                entity.Property(e => e.AtDate)
                    .HasColumnType("date")
                    .HasColumnName("at_date");

                entity.Property(e => e.AtCompid).HasColumnName("at_compid");

                entity.Property(e => e.AtCoverday)
                    .HasColumnName("at_coverday")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtExotHrs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_exot_hrs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtExotMin)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_exot_min")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtExtra).HasColumnName("At_Extra");

                entity.Property(e => e.AtGroupid).HasColumnName("at_groupid");

                entity.Property(e => e.AtHoliday)
                    .HasMaxLength(2)
                    .HasColumnName("at_holiday");

                entity.Property(e => e.AtIntime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_intime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtLate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_late")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtManual)
                    .HasColumnName("at_manual")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtOtHrs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_ot_hrs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtOtMin)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_ot_min")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtOutdate)
                    .HasColumnType("date")
                    .HasColumnName("at_outdate");

                entity.Property(e => e.AtOuttime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_outtime")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtProxid)
                    .HasMaxLength(10)
                    .HasColumnName("at_proxid");

                entity.Property(e => e.AtShift)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_shift")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtStatus)
                    .HasMaxLength(30)
                    .HasColumnName("at_status");

                entity.Property(e => e.AtStatusCode)
                    .HasMaxLength(3)
                    .HasColumnName("at_status_code");

                entity.Property(e => e.AtUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("at_udate");

                entity.Property(e => e.AtUser)
                    .HasMaxLength(15)
                    .HasColumnName("at_user");

                entity.Property(e => e.AtWorkHrs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_work_hrs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AtWorkMin)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_work_min")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DgPayBankInfo>(entity =>
            {
                entity.HasKey(e => e.BankCode);

                entity.ToTable("dg_pay_BankInfo");

                entity.Property(e => e.BankCode).HasColumnName("Bank_Code");

                entity.Property(e => e.BankAddress)
                    .HasMaxLength(200)
                    .HasColumnName("Bank_Address");

                entity.Property(e => e.BankName)
                    .HasMaxLength(100)
                    .HasColumnName("Bank_Name");

                entity.Property(e => e.Bshortname).HasMaxLength(5);

                entity.Property(e => e.CountryCode).HasColumnName("Country_Code");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .HasColumnName("Created_By");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("Created_Date");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.SwiftCode)
                    .HasMaxLength(50)
                    .HasColumnName("Swift_Code");

                entity.Property(e => e.TelephoneNo)
                    .HasMaxLength(15)
                    .HasColumnName("Telephone_No");
            });

            modelBuilder.Entity<DgPayBuildingUnit>(entity =>
            {
                entity.HasKey(e => e.UnitCode);

                entity.ToTable("dg_pay_BuildingUnit");

                entity.Property(e => e.UnitCode).HasColumnName("Unit_Code");

                entity.Property(e => e.CompanyId).HasColumnName("Company_ID");

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .HasColumnName("Company_Name");

                entity.Property(e => e.CreatedBy).HasMaxLength(20);

                entity.Property(e => e.Createddt).HasColumnType("smalldatetime");

                entity.Property(e => e.UnitName)
                    .HasMaxLength(50)
                    .HasColumnName("Unit_Name");
            });

            modelBuilder.Entity<DgPayCompany>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_pay_company");

                entity.Property(e => e.ComAd1)
                    .HasMaxLength(50)
                    .HasColumnName("com_ad1");

                entity.Property(e => e.ComAd1Bangla)
                    .HasMaxLength(50)
                    .HasColumnName("com_ad1Bangla");

                entity.Property(e => e.ComAd2)
                    .HasMaxLength(50)
                    .HasColumnName("com_ad2");

                entity.Property(e => e.ComAd2Bangla)
                    .HasMaxLength(50)
                    .HasColumnName("com_ad2Bangla");

                entity.Property(e => e.ComEmail)
                    .HasMaxLength(50)
                    .HasColumnName("com_email");

                entity.Property(e => e.ComGid).HasColumnName("com_gid");

                entity.Property(e => e.ComId).HasColumnName("com_id");

                entity.Property(e => e.ComName)
                    .HasMaxLength(50)
                    .HasColumnName("com_name");

                entity.Property(e => e.ComNameBangla)
                    .HasMaxLength(50)
                    .HasColumnName("com_nameBangla");

                entity.Property(e => e.ComTel)
                    .HasMaxLength(50)
                    .HasColumnName("com_tel");

                entity.Property(e => e.ComUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("com_udate");

                entity.Property(e => e.ComUser)
                    .HasMaxLength(30)
                    .HasColumnName("com_user");

                entity.Property(e => e.ComWeb)
                    .HasMaxLength(30)
                    .HasColumnName("com_web");
            });

            modelBuilder.Entity<DgPayCompanyaccess>(entity =>
            {
                entity.HasKey(e => e.CaSerial);

                entity.ToTable("dg_pay_companyaccess");

                entity.Property(e => e.CaSerial).HasColumnName("ca_serial");

                entity.Property(e => e.CaAccessuser)
                    .HasMaxLength(15)
                    .HasColumnName("ca_accessuser");

                entity.Property(e => e.CaCompName)
                    .HasMaxLength(50)
                    .HasColumnName("ca_compName");

                entity.Property(e => e.CaCompid).HasColumnName("ca_compid");

                entity.Property(e => e.CaUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ca_udate");

                entity.Property(e => e.CaUser)
                    .HasMaxLength(15)
                    .HasColumnName("ca_user");

                entity.Property(e => e.Permission).HasColumnName("permission");
            });

            modelBuilder.Entity<DgPayCompanygroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_pay_companygroup");

                entity.Property(e => e.Gadd).HasMaxLength(100);

                entity.Property(e => e.Gcode).HasColumnName("GCode");

                entity.Property(e => e.GexpDate)
                    .HasColumnType("datetime")
                    .HasColumnName("GExpDate");

                entity.Property(e => e.Gname).HasMaxLength(100);

                entity.Property(e => e.Gtel).HasMaxLength(50);

                entity.Property(e => e.Gudate).HasColumnType("datetime");

                entity.Property(e => e.Guser).HasMaxLength(15);
            });

            modelBuilder.Entity<DgPayDeducation>(entity =>
            {
                entity.HasKey(e => e.DSerial);

                entity.ToTable("dg_pay_deducations");

                entity.Property(e => e.DSerial).HasColumnName("d_serial");

                entity.Property(e => e.DCompid).HasColumnName("d_compid");

                entity.Property(e => e.DDate)
                    .HasColumnType("date")
                    .HasColumnName("d_date");

                entity.Property(e => e.DEmpSerial)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("d_emp_serial");

                entity.Property(e => e.DGroupid).HasColumnName("d_groupid");

                entity.Property(e => e.DId).HasColumnName("d_id");

                entity.Property(e => e.DUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("d_udate");

                entity.Property(e => e.DUser)
                    .HasMaxLength(15)
                    .HasColumnName("d_user");

                entity.Property(e => e.DValue)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("d_value");
            });

            modelBuilder.Entity<DgPayDeductionsde>(entity =>
            {
                entity.HasKey(e => e.DCode)
                    .HasName("PK_Pay_DeductionsDes");

                entity.ToTable("dg_pay_deductionsdes");

                entity.Property(e => e.DCode).HasColumnName("d_code");

                entity.Property(e => e.DDescription)
                    .HasMaxLength(20)
                    .HasColumnName("d_description");

                entity.Property(e => e.DGroupid).HasColumnName("d_groupid");

                entity.Property(e => e.DType)
                    .HasMaxLength(2)
                    .HasColumnName("d_type")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("d_udate");

                entity.Property(e => e.DUser)
                    .HasMaxLength(15)
                    .HasColumnName("d_user");
            });

            modelBuilder.Entity<DgPayDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_pay_Department");

                entity.Property(e => e.CDeptname)
                    .HasMaxLength(50)
                    .HasColumnName("cDeptname");

                entity.Property(e => e.CDptnameBd)
                    .HasMaxLength(100)
                    .HasColumnName("cDptnameBD");

                entity.Property(e => e.CEntUser)
                    .HasMaxLength(20)
                    .HasColumnName("cEntUser");

                entity.Property(e => e.DEntdt)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dEntdt")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Dptnamebangla)
                    .HasMaxLength(100)
                    .HasColumnName("dptnamebangla");

                entity.Property(e => e.NCompanyId).HasColumnName("nCompanyID");

                entity.Property(e => e.NCompanyName)
                    .HasMaxLength(50)
                    .HasColumnName("nCompany_name");

                entity.Property(e => e.NUserDept).HasColumnName("nUserDept");
            });

            modelBuilder.Entity<DgPayDesignation>(entity =>
            {
                entity.HasKey(e => e.DecId);

                entity.ToTable("dg_pay_designation");

                entity.Property(e => e.DecId).HasColumnName("dec_id");

                entity.Property(e => e.DecGroupid).HasColumnName("dec_groupid");

                entity.Property(e => e.DecName)
                    .HasMaxLength(30)
                    .HasColumnName("dec_name");

                entity.Property(e => e.DecNameBangla)
                    .HasMaxLength(30)
                    .HasColumnName("dec_name_bangla");

                entity.Property(e => e.DecUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("dec_udate");

                entity.Property(e => e.DecUser)
                    .HasMaxLength(15)
                    .HasColumnName("dec_user");

                entity.Property(e => e.HdAllownAmt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("hd_allownAmt");
            });

            modelBuilder.Entity<DgPayDistrict>(entity =>
            {
                entity.HasKey(e => e.DiId);

                entity.ToTable("dg_pay_district");

                entity.Property(e => e.DiId).HasColumnName("di_id");

                entity.Property(e => e.DiDivid).HasColumnName("di_divid");

                entity.Property(e => e.DiDivname)
                    .HasMaxLength(30)
                    .HasColumnName("di_divname");

                entity.Property(e => e.DiGroupid).HasColumnName("di_groupid");

                entity.Property(e => e.DiName)
                    .HasMaxLength(30)
                    .HasColumnName("di_name");

                entity.Property(e => e.DiNameBangla)
                    .HasMaxLength(30)
                    .HasColumnName("di_nameBangla");

                entity.Property(e => e.DiUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("di_udate");

                entity.Property(e => e.DiUser)
                    .HasMaxLength(15)
                    .HasColumnName("di_user");
            });

            modelBuilder.Entity<DgPayDivision>(entity =>
            {
                entity.HasKey(e => e.DivId);

                entity.ToTable("dg_pay_division");

                entity.Property(e => e.DivId).HasColumnName("div_id");

                entity.Property(e => e.DivGroupid).HasColumnName("div_groupid");

                entity.Property(e => e.DivName)
                    .HasMaxLength(30)
                    .HasColumnName("div_name");

                entity.Property(e => e.DivNameBangla)
                    .HasMaxLength(30)
                    .HasColumnName("div_name_bangla");

                entity.Property(e => e.DivUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("div_udate");

                entity.Property(e => e.DivUser)
                    .HasMaxLength(15)
                    .HasColumnName("div_user");
            });

            modelBuilder.Entity<DgPayEidBonusSetup>(entity =>
            {
                entity.HasKey(e => e.EbSerial);

                entity.ToTable("dg_pay_eid_bonus_setup");

                entity.Property(e => e.EbSerial).HasColumnName("eb_serial");

                entity.Property(e => e.Addtime)
                    .HasColumnType("datetime")
                    .HasColumnName("addtime");

                entity.Property(e => e.Bellowdays90)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bellowdays_90");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(30)
                    .HasColumnName("category_name");

                entity.Property(e => e.ComCode).HasColumnName("com_code");

                entity.Property(e => e.ComName)
                    .HasMaxLength(50)
                    .HasColumnName("com_name");

                entity.Property(e => e.Days180)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("days_180");

                entity.Property(e => e.Days270)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("days_270");

                entity.Property(e => e.Days365)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("days_365");

                entity.Property(e => e.Days90)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("days_90");

                entity.Property(e => e.Dependon)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("dependon");

                entity.Property(e => e.Enteredby)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("enteredby");

                entity.Property(e => e.Gid).HasColumnName("gid");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.SalaryCategory).HasColumnName("salary_category");

                entity.Property(e => e.StampCharge).HasColumnName("stampCharge");

                entity.Property(e => e.Type)
                    .HasMaxLength(20)
                    .HasColumnName("type");

                entity.Property(e => e.TypeDays180)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("type_days_180");

                entity.Property(e => e.TypeDays270)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("type_days_270");

                entity.Property(e => e.TypeDays365)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("type_days_365");

                entity.Property(e => e.TypeDays90)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("type_days_90");

                entity.Property(e => e.TypeDays90less)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("type_days_90Less");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("updatedby");

                entity.Property(e => e.Updatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatetime");
            });

            modelBuilder.Entity<DgPayEidbonusPayment>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_pay_eidbonus_payment");

                entity.Property(e => e.Addtime)
                    .HasColumnType("datetime")
                    .HasColumnName("addtime");

                entity.Property(e => e.BonusAmt)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("bonus_amt");

                entity.Property(e => e.ComCode).HasColumnName("com_code");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.Enteredby)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("enteredby");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("updatedby");

                entity.Property(e => e.Updatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatetime");

                entity.Property(e => e.Year).HasColumnName("year");
            });

            modelBuilder.Entity<DgPayEmployee>(entity =>
            {
                entity.HasKey(e => e.EmpSerial);

                entity.ToTable("dg_pay_Employee");

                entity.Property(e => e.EmpSerial).HasColumnName("emp_serial");

                entity.Property(e => e.CompName)
                    .HasMaxLength(50)
                    .HasColumnName("comp_name");

                entity.Property(e => e.Compid).HasColumnName("compid");

                entity.Property(e => e.EmpLastedituser)
                    .HasMaxLength(15)
                    .HasColumnName("emp_lastedituser");

                entity.Property(e => e.EmpNo).HasColumnName("emp_no");

                entity.Property(e => e.EmpProxid).HasColumnName("emp_proxid");

                entity.Property(e => e.EmpRef)
                    .HasMaxLength(50)
                    .HasColumnName("emp_ref");

                entity.Property(e => e.EmpUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("emp_udate");

                entity.Property(e => e.EmpUser)
                    .HasMaxLength(10)
                    .HasColumnName("emp_user");

                entity.Property(e => e.Emplasteditudate)
                    .HasColumnType("datetime")
                    .HasColumnName("emplasteditudate");

                entity.Property(e => e.GrossSalaryBangla)
                    .HasMaxLength(100)
                    .HasColumnName("Gross_salary_Bangla");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.OiActive)
                    .HasColumnName("oi_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.OiBank)
                    .HasColumnName("oi_bank")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OiBankName)
                    .HasMaxLength(100)
                    .HasColumnName("oi_bank_name");

                entity.Property(e => e.OiBankacno)
                    .HasMaxLength(20)
                    .HasColumnName("oi_bankacno")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OiBasicsalary)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("oi_basicsalary")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OiBulding)
                    .HasColumnName("oi_bulding")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OiBuldingName)
                    .HasMaxLength(20)
                    .HasColumnName("oi_bulding_name");

                entity.Property(e => e.OiConfDate)
                    .HasColumnType("date")
                    .HasColumnName("oi_ConfDate");

                entity.Property(e => e.OiDepartment)
                    .HasColumnName("oi_department")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OiDepartmenteName)
                    .HasMaxLength(50)
                    .HasColumnName("oi_departmente_name");

                entity.Property(e => e.OiDesignation)
                    .HasColumnName("oi_designation")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OiDesignationName)
                    .HasMaxLength(50)
                    .HasColumnName("oi_designation_name");

                entity.Property(e => e.OiFloor)
                    .HasColumnName("oi_floor")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OiFloorName)
                    .HasMaxLength(30)
                    .HasColumnName("oi_floor_name");

                entity.Property(e => e.OiFood)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("oi_food")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OiGarde)
                    .HasColumnName("oi_garde")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OiGardeName)
                    .HasMaxLength(20)
                    .HasColumnName("oi_garde_name");

                entity.Property(e => e.OiGrossalary)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("oi_grossalary")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OiHouserent)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("oi_houserent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OiInactiveDate)
                    .HasColumnType("datetime")
                    .HasColumnName("oi_inactive_date");

                entity.Property(e => e.OiInactiveReson)
                    .HasMaxLength(10)
                    .HasColumnName("oi_inactive_reson");

                entity.Property(e => e.OiJoineddate)
                    .HasColumnType("date")
                    .HasColumnName("oi_joineddate");

                entity.Property(e => e.OiLine)
                    .HasColumnName("oi_line")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OiLineName)
                    .HasMaxLength(20)
                    .HasColumnName("oi_line_name");

                entity.Property(e => e.OiMedical)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("oi_medical")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OiProcessName)
                    .HasMaxLength(30)
                    .HasColumnName("oi_ProcessName");

                entity.Property(e => e.OiProcessNameBangla)
                    .HasMaxLength(10)
                    .HasColumnName("oi_ProcessName_Bangla");

                entity.Property(e => e.OiProvidentfund)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("oi_providentfund");

                entity.Property(e => e.OiSalcategory)
                    .HasColumnName("oi_salcategory")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OiSalcategoryName)
                    .HasMaxLength(20)
                    .HasColumnName("oi_salcategory_name");

                entity.Property(e => e.OiSection)
                    .HasColumnName("oi_section")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OiSectionName)
                    .HasMaxLength(50)
                    .HasColumnName("oi_section_name");

                entity.Property(e => e.OiShift)
                    .HasColumnName("oi_shift")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OiShiftName)
                    .HasMaxLength(20)
                    .HasColumnName("oi_shift_name");

                entity.Property(e => e.OiSpacola)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("oi_spacola")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OiTraveling)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("oi_traveling")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OiWeeklyholiday)
                    .HasMaxLength(15)
                    .HasColumnName("oi_weeklyholiday");

                entity.Property(e => e.PiBirthdate)
                    .HasColumnType("date")
                    .HasColumnName("pi_birthdate");

                entity.Property(e => e.PiBloodgroup)
                    .HasMaxLength(3)
                    .HasColumnName("pi_bloodgroup");

                entity.Property(e => e.PiDistrict).HasColumnName("pi_district");

                entity.Property(e => e.PiDistrictName)
                    .HasMaxLength(30)
                    .HasColumnName("pi_district_name");

                entity.Property(e => e.PiDivision).HasColumnName("pi_division");

                entity.Property(e => e.PiDivisionName)
                    .HasMaxLength(30)
                    .HasColumnName("pi_division_name");

                entity.Property(e => e.PiEmergencyno)
                    .HasMaxLength(100)
                    .HasColumnName("pi_emergencyno");

                entity.Property(e => e.PiEmpcontactno)
                    .HasMaxLength(20)
                    .HasColumnName("pi_empcontactno");

                entity.Property(e => e.PiFarthersname)
                    .HasMaxLength(40)
                    .HasColumnName("pi_farthersname");

                entity.Property(e => e.PiFathernamebangla)
                    .HasMaxLength(45)
                    .HasColumnName("pi_Fathernamebangla");

                entity.Property(e => e.PiFcontactno)
                    .HasMaxLength(20)
                    .HasColumnName("pi_fcontactno");

                entity.Property(e => e.PiFirstname)
                    .HasMaxLength(100)
                    .HasColumnName("pi_firstname");

                entity.Property(e => e.PiFullname)
                    .HasMaxLength(100)
                    .HasColumnName("pi_fullname");

                entity.Property(e => e.PiLastname)
                    .HasMaxLength(100)
                    .HasColumnName("pi_lastname");

                entity.Property(e => e.PiMaritalstatus)
                    .HasMaxLength(10)
                    .HasColumnName("pi_maritalstatus");

                entity.Property(e => e.PiMcontactno)
                    .HasMaxLength(20)
                    .HasColumnName("pi_mcontactno");

                entity.Property(e => e.PiMothernamebangla)
                    .HasMaxLength(45)
                    .HasColumnName("pi_Mothernamebangla");

                entity.Property(e => e.PiMothersname)
                    .HasMaxLength(40)
                    .HasColumnName("pi_mothersname");

                entity.Property(e => e.PiNameinbangla)
                    .HasMaxLength(100)
                    .HasColumnName("pi_nameinbangla");

                entity.Property(e => e.PiNationality)
                    .HasMaxLength(30)
                    .HasColumnName("pi_nationality");

                entity.Property(e => e.PiNic)
                    .HasMaxLength(20)
                    .HasColumnName("pi_nic");

                entity.Property(e => e.PiNominee)
                    .HasMaxLength(40)
                    .HasColumnName("pi_nominee");

                entity.Property(e => e.PiNomineeAd1)
                    .HasMaxLength(50)
                    .HasColumnName("pi_nominee_ad1");

                entity.Property(e => e.PiNomineeAd2)
                    .HasMaxLength(30)
                    .HasColumnName("pi_nominee_ad2");

                entity.Property(e => e.PiNomineeNic)
                    .HasMaxLength(50)
                    .HasColumnName("pi_nomineeNIC");

                entity.Property(e => e.PiNoofchild).HasColumnName("pi_noofchild");

                entity.Property(e => e.PiPermanentAdd1)
                    .HasMaxLength(100)
                    .HasColumnName("pi_permanent_add1");

                entity.Property(e => e.PiPermanentAdd1Bangla)
                    .HasMaxLength(100)
                    .HasColumnName("pi_permanent_add1_bangla");

                entity.Property(e => e.PiPermanentAdd2)
                    .HasMaxLength(100)
                    .HasColumnName("pi_permanent_add2");

                entity.Property(e => e.PiPermanentAdd2Bangla)
                    .HasMaxLength(100)
                    .HasColumnName("pi_permanent_add2_bangla");

                entity.Property(e => e.PiPostoffice)
                    .HasMaxLength(100)
                    .HasColumnName("pi_postoffice");

                entity.Property(e => e.PiPostofficeBangla)
                    .HasMaxLength(100)
                    .HasColumnName("pi_postoffice_bangla");

                entity.Property(e => e.PiPresentAdd1)
                    .HasMaxLength(100)
                    .HasColumnName("pi_present_add1");

                entity.Property(e => e.PiPresentAdd2)
                    .HasMaxLength(100)
                    .HasColumnName("pi_present_add2");

                entity.Property(e => e.PiPresentDistrict).HasColumnName("pi_present_District");

                entity.Property(e => e.PiPresentDistrictName)
                    .HasMaxLength(30)
                    .HasColumnName("pi_present_District_name");

                entity.Property(e => e.PiPresentDivision).HasColumnName("pi_present_Division");

                entity.Property(e => e.PiPresentDivisionName)
                    .HasMaxLength(30)
                    .HasColumnName("pi_present_Division_name");

                entity.Property(e => e.PiPresentPoBgl)
                    .HasMaxLength(100)
                    .HasColumnName("pi_present_PO_Bgl");

                entity.Property(e => e.PiPresentThana).HasColumnName("pi_present_Thana");

                entity.Property(e => e.PiPresentThanaName)
                    .HasMaxLength(30)
                    .HasColumnName("pi_present_Thana_name");

                entity.Property(e => e.PiPresentVillageBgl)
                    .HasMaxLength(100)
                    .HasColumnName("pi_present_village_Bgl");

                entity.Property(e => e.PiReligoin)
                    .HasMaxLength(30)
                    .HasColumnName("pi_religoin");

                entity.Property(e => e.PiSex)
                    .HasMaxLength(6)
                    .HasColumnName("pi_sex");

                entity.Property(e => e.PiSpouse)
                    .HasMaxLength(40)
                    .HasColumnName("pi_spouse");

                entity.Property(e => e.PiThana).HasColumnName("pi_thana");

                entity.Property(e => e.PiThanaName)
                    .HasMaxLength(30)
                    .HasColumnName("pi_thana_name");

                entity.Property(e => e.ShiftRosteredDate)
                    .HasColumnType("datetime")
                    .HasColumnName("shift_rostered_date");
            });

            modelBuilder.Entity<DgPayEmployeeActiveInactive>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_pay_employee_activeInactive");

                entity.Property(e => e.AiActiveInactive).HasColumnName("ai_ActiveInactive");

                entity.Property(e => e.AiComents).HasColumnName("ai_coments");

                entity.Property(e => e.AiDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ai_date");

                entity.Property(e => e.AiEmpseral).HasColumnName("ai_empseral");

                entity.Property(e => e.AiReson)
                    .HasMaxLength(15)
                    .HasColumnName("ai_reson");

                entity.Property(e => e.AiUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ai_udate");

                entity.Property(e => e.AiUser)
                    .HasMaxLength(15)
                    .HasColumnName("ai_user");
            });

            modelBuilder.Entity<DgPayEmployeeIncrement>(entity =>
            {
                entity.HasKey(e => e.Serial);

                entity.ToTable("dg_pay_employee_increment");

                entity.Property(e => e.Serial).HasColumnName("serial");

                entity.Property(e => e.SiBasicsalary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("si_basicsalary");

                entity.Property(e => e.SiDate)
                    .HasColumnType("date")
                    .HasColumnName("si_date");

                entity.Property(e => e.SiEmpserial)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("si_empserial");

                entity.Property(e => e.SiFood)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("si_food");

                entity.Property(e => e.SiGrossalary)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("si_grossalary");

                entity.Property(e => e.SiHouserent)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("si_houserent");

                entity.Property(e => e.SiIncrement)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("si_Increment");

                entity.Property(e => e.SiMedical)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("si_medical");

                entity.Property(e => e.SiSpacola)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("si_spacola");

                entity.Property(e => e.SiTraveling)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("si_traveling");

                entity.Property(e => e.SiUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("si_udate");

                entity.Property(e => e.SiUser)
                    .HasMaxLength(15)
                    .HasColumnName("si_user");
            });

            modelBuilder.Entity<DgPayEmployeeMaternityleave>(entity =>
            {
                entity.HasKey(e => e.MlSerial);

                entity.ToTable("dg_pay_employee_maternityleave");

                entity.Property(e => e.MlSerial).HasColumnName("ml_serial");

                entity.Property(e => e.MlEmpserial).HasColumnName("ml_empserial");

                entity.Property(e => e.MlFromdate)
                    .HasColumnType("date")
                    .HasColumnName("ml_fromdate");

                entity.Property(e => e.MlTodate)
                    .HasColumnType("date")
                    .HasColumnName("ml_todate");

                entity.Property(e => e.MlUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ml_udate");

                entity.Property(e => e.MlUser)
                    .HasMaxLength(15)
                    .HasColumnName("ml_user");
            });

            modelBuilder.Entity<DgPayEmployeedbnrRemoveThi>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_pay_employeedbnr_remove_this");

                entity.Property(e => e.Compid).HasColumnName("compid");

                entity.Property(e => e.EmpNo).HasColumnName("emp_no");

                entity.Property(e => e.EmpProxid)
                    .HasMaxLength(10)
                    .HasColumnName("emp_proxid");

                entity.Property(e => e.EmpRef)
                    .HasMaxLength(10)
                    .HasColumnName("emp_ref");

                entity.Property(e => e.EmpSerial)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("emp_serial");

                entity.Property(e => e.Groupid).HasColumnName("groupid");

                entity.Property(e => e.OiActive).HasColumnName("oi_active");

                entity.Property(e => e.OiBank).HasColumnName("oi_bank");

                entity.Property(e => e.OiBankacno)
                    .HasMaxLength(20)
                    .HasColumnName("oi_bankacno");

                entity.Property(e => e.OiBasicsalary)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("oi_basicsalary");

                entity.Property(e => e.OiBulding).HasColumnName("oi_bulding");

                entity.Property(e => e.OiDepartment).HasColumnName("oi_department");

                entity.Property(e => e.OiDesignation).HasColumnName("oi_designation");

                entity.Property(e => e.OiFloor).HasColumnName("oi_floor");

                entity.Property(e => e.OiFood)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("oi_food");

                entity.Property(e => e.OiGarde).HasColumnName("oi_garde");

                entity.Property(e => e.OiGrossalary)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("oi_grossalary");

                entity.Property(e => e.OiHouserent)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("oi_houserent");

                entity.Property(e => e.OiJoineddate)
                    .HasColumnType("datetime")
                    .HasColumnName("oi_joineddate");

                entity.Property(e => e.OiLine).HasColumnName("oi_line");

                entity.Property(e => e.OiMedical)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("oi_medical");

                entity.Property(e => e.OiProvidentfund)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("oi_providentfund");

                entity.Property(e => e.OiSalcategory).HasColumnName("oi_salcategory");

                entity.Property(e => e.OiSection).HasColumnName("oi_section");

                entity.Property(e => e.OiShift).HasColumnName("oi_shift");

                entity.Property(e => e.OiSpacola)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("oi_spacola");

                entity.Property(e => e.OiTraveling)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("oi_traveling");

                entity.Property(e => e.OiWeeklyholiday)
                    .HasMaxLength(15)
                    .HasColumnName("oi_weeklyholiday");

                entity.Property(e => e.PiBirthdate)
                    .HasColumnType("date")
                    .HasColumnName("pi_birthdate");

                entity.Property(e => e.PiBloodgroup)
                    .HasMaxLength(6)
                    .HasColumnName("pi_bloodgroup");

                entity.Property(e => e.PiDistrict).HasColumnName("pi_district");

                entity.Property(e => e.PiDivision).HasColumnName("pi_division");

                entity.Property(e => e.PiFarthersname)
                    .HasMaxLength(40)
                    .HasColumnName("pi_farthersname");

                entity.Property(e => e.PiFcontactno)
                    .HasMaxLength(20)
                    .HasColumnName("pi_fcontactno");

                entity.Property(e => e.PiFirstname)
                    .HasMaxLength(15)
                    .HasColumnName("pi_firstname");

                entity.Property(e => e.PiFullname)
                    .HasMaxLength(50)
                    .HasColumnName("pi_fullname");

                entity.Property(e => e.PiLastname)
                    .HasMaxLength(30)
                    .HasColumnName("pi_lastname");

                entity.Property(e => e.PiMaritalstatus)
                    .HasMaxLength(10)
                    .HasColumnName("pi_maritalstatus");

                entity.Property(e => e.PiMcontactno)
                    .HasMaxLength(30)
                    .HasColumnName("pi_mcontactno");

                entity.Property(e => e.PiMothersname)
                    .HasMaxLength(30)
                    .HasColumnName("pi_mothersname");

                entity.Property(e => e.PiNameinbangla)
                    .HasMaxLength(45)
                    .HasColumnName("pi_nameinbangla");

                entity.Property(e => e.PiNationality)
                    .HasMaxLength(30)
                    .HasColumnName("pi_nationality");

                entity.Property(e => e.PiNic)
                    .HasMaxLength(20)
                    .HasColumnName("pi_nic");

                entity.Property(e => e.PiNominee)
                    .HasMaxLength(40)
                    .HasColumnName("pi_nominee");

                entity.Property(e => e.PiNoofchild).HasColumnName("pi_noofchild");

                entity.Property(e => e.PiPermanentAdd1)
                    .HasMaxLength(50)
                    .HasColumnName("pi_permanent_add1");

                entity.Property(e => e.PiPermanentAdd2)
                    .HasMaxLength(30)
                    .HasColumnName("pi_permanent_add2");

                entity.Property(e => e.PiPresentAdd1)
                    .HasMaxLength(50)
                    .HasColumnName("pi_present_add1");

                entity.Property(e => e.PiPresentAdd2)
                    .HasMaxLength(30)
                    .HasColumnName("pi_present_add2");

                entity.Property(e => e.PiReligoin)
                    .HasMaxLength(30)
                    .HasColumnName("pi_religoin");

                entity.Property(e => e.PiSex)
                    .HasMaxLength(6)
                    .HasColumnName("pi_sex");

                entity.Property(e => e.PiSpouse)
                    .HasMaxLength(40)
                    .HasColumnName("pi_spouse");

                entity.Property(e => e.PiThana).HasColumnName("pi_thana");
            });

            modelBuilder.Entity<DgPayFloor>(entity =>
            {
                entity.HasKey(e => e.NFloor);

                entity.ToTable("dg_pay_Floor");

                entity.Property(e => e.NFloor).HasColumnName("nFloor");

                entity.Property(e => e.BuildingUid).HasColumnName("BuildingUID");

                entity.Property(e => e.BuildingUiname)
                    .HasMaxLength(30)
                    .HasColumnName("BuildingUIName");

                entity.Property(e => e.CEntUser)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cEntUser");

                entity.Property(e => e.CFloorDescriptin)
                    .HasMaxLength(20)
                    .HasColumnName("cFloor_Descriptin");

                entity.Property(e => e.CFloorDescriptinBangla)
                    .HasMaxLength(20)
                    .HasColumnName("cFloor_Descriptin_bangla");

                entity.Property(e => e.CFloorDescriptinBd)
                    .HasMaxLength(50)
                    .HasColumnName("cFloor_DescriptinBD");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.DEntdt)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dEntdt")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<DgPayGrade>(entity =>
            {
                entity.HasKey(e => e.GrdId)
                    .HasName("PK_Grade");

                entity.ToTable("dg_pay_grade");

                entity.Property(e => e.GrdId).HasColumnName("Grd_id");

                entity.Property(e => e.GrdGroupid).HasColumnName("Grd_Groupid");

                entity.Property(e => e.GrdName)
                    .HasMaxLength(60)
                    .HasColumnName("Grd_Name");
            });

            modelBuilder.Entity<DgPayLeaveInfor>(entity =>
            {
                entity.HasKey(e => new { e.LevSerial, e.LevYear, e.LevEmpSerial })
                    .HasName("PK_Pay_LeaveInfor");

                entity.ToTable("dg_pay_leaveInfor");

                entity.Property(e => e.LevSerial)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("lev_serial");

                entity.Property(e => e.LevYear).HasColumnName("lev_year");

                entity.Property(e => e.LevEmpSerial)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("lev_emp_serial");

                entity.Property(e => e.LevAnual)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("lev_anual")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LevAnualBal)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("lev_anual_bal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LevCasual)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("lev_casual")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LevCasualBal)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("lev_casual_bal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LevCompid).HasColumnName("lev_compid");

                entity.Property(e => e.LevGroupid).HasColumnName("lev_groupid");

                entity.Property(e => e.LevMedical)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("lev_medical")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LevMedicalBal)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("lev_medical_bal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LevUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lev_udate");

                entity.Property(e => e.LevUser)
                    .HasMaxLength(10)
                    .HasColumnName("lev_user");
            });

            modelBuilder.Entity<DgPayLeavetransaction>(entity =>
            {
                entity.HasKey(e => new { e.LtrDate, e.LtrEmpSerial })
                    .HasName("PK_Pay_LeaveTransaction");

                entity.ToTable("dg_pay_leavetransaction");

                entity.Property(e => e.LtrDate)
                    .HasColumnType("datetime")
                    .HasColumnName("ltr_date")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LtrEmpSerial).HasColumnName("ltr_emp_serial");

                entity.Property(e => e.LtrAnual)
                    .HasColumnName("ltr_anual")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LtrCasual)
                    .HasColumnName("ltr_casual")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LtrCompid).HasColumnName("ltr_compid");

                entity.Property(e => e.LtrGroupid).HasColumnName("ltr_groupid");

                entity.Property(e => e.LtrMedical)
                    .HasColumnName("ltr_medical")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LtrSerial)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ltr_serial");

                entity.Property(e => e.LtrUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ltr_udate");

                entity.Property(e => e.LtrUser)
                    .HasMaxLength(15)
                    .HasColumnName("ltr_user");
            });

            modelBuilder.Entity<DgPayLine>(entity =>
            {
                entity.HasKey(e => e.LineCode);

                entity.ToTable("dg_pay_Line");

                entity.Property(e => e.LineCode).HasColumnName("Line_Code");

                entity.Property(e => e.BuildingUnitId).HasColumnName("BuildingUnitID");

                entity.Property(e => e.BuildingUnitName).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.Createdt).HasColumnType("smalldatetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.DepartmentName).HasMaxLength(30);

                entity.Property(e => e.FloorId).HasColumnName("FloorID");

                entity.Property(e => e.FloorName).HasMaxLength(50);

                entity.Property(e => e.LineId).HasColumnName("Line_ID");

                entity.Property(e => e.LineNo)
                    .HasMaxLength(30)
                    .HasColumnName("Line_No");

                entity.Property(e => e.LineNoBangla)
                    .HasMaxLength(30)
                    .HasColumnName("Line_No_Bangla");

                entity.Property(e => e.NHelper).HasColumnName("nHelper");

                entity.Property(e => e.NMachineOp).HasColumnName("nMachineOp");

                entity.Property(e => e.ProdPlan).HasMaxLength(1);

                entity.Property(e => e.SectionId).HasColumnName("SectionID");

                entity.Property(e => e.SectionName).HasMaxLength(20);
            });

            modelBuilder.Entity<DgPayLoan>(entity =>
            {
                entity.HasKey(e => e.LLoanserial);

                entity.ToTable("dg_pay_loan");

                entity.Property(e => e.LLoanserial).HasColumnName("l_loanserial");

                entity.Property(e => e.LActive)
                    .HasColumnName("l_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LBalance)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("l_balance");

                entity.Property(e => e.LCat).HasColumnName("l_cat");

                entity.Property(e => e.LDate)
                    .HasColumnType("date")
                    .HasColumnName("l_date");

                entity.Property(e => e.LEmpserial).HasColumnName("l_empserial");

                entity.Property(e => e.LLoan)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("l_loan");

                entity.Property(e => e.LPeriod).HasColumnName("l_period");

                entity.Property(e => e.LRental)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("l_rental");

                entity.Property(e => e.LStartdate)
                    .HasColumnType("date")
                    .HasColumnName("l_startdate");

                entity.Property(e => e.LUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("l_udate");

                entity.Property(e => e.LUser)
                    .HasMaxLength(15)
                    .HasColumnName("l_user");
            });

            modelBuilder.Entity<DgPayLoanHold>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_pay_loan_hold");

                entity.Property(e => e.LStatus)
                    .HasMaxLength(10)
                    .HasColumnName("l_status");

                entity.Property(e => e.LhDatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("lh_datetime");

                entity.Property(e => e.LhLoanserial).HasColumnName("lh_loanserial");

                entity.Property(e => e.LhUser)
                    .HasMaxLength(15)
                    .HasColumnName("lh_user");
            });

            modelBuilder.Entity<DgPayLoancategory>(entity =>
            {
                entity.HasKey(e => e.LcId);

                entity.ToTable("dg_pay_loancategory");

                entity.Property(e => e.LcId).HasColumnName("lc_id");

                entity.Property(e => e.LcCategory)
                    .HasMaxLength(20)
                    .HasColumnName("lc_category");

                entity.Property(e => e.LcUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("lc_udate");

                entity.Property(e => e.LcUser)
                    .HasMaxLength(15)
                    .HasColumnName("lc_user");
            });

            modelBuilder.Entity<DgPayLoantransaction>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_pay_loantransaction");

                entity.Property(e => e.ItDate)
                    .HasColumnType("date")
                    .HasColumnName("it_date");

                entity.Property(e => e.ItPeriod).HasColumnName("it_period");

                entity.Property(e => e.ItRental)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("it_rental");

                entity.Property(e => e.ItUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("it_udate");

                entity.Property(e => e.ItUser)
                    .HasMaxLength(15)
                    .HasColumnName("it_user");

                entity.Property(e => e.LtEmpserial).HasColumnName("lt_empserial");
            });

            modelBuilder.Entity<DgPayMaternityLeaveInfo>(entity =>
            {
                entity.HasKey(e => e.SerialNo);

                entity.ToTable("dg_Pay_Maternity_leave_info");

                entity.Property(e => e.SerialNo).HasColumnName("serialNo");

                entity.Property(e => e.Addtime)
                    .HasColumnType("datetime")
                    .HasColumnName("addtime");

                entity.Property(e => e.ComCode).HasColumnName("com_code");

                entity.Property(e => e.DateOfFirstNotification)
                    .HasColumnType("datetime")
                    .HasColumnName("date_of_first_notification");

                entity.Property(e => e.EmpSerial).HasColumnName("emp_serial");

                entity.Property(e => e.Enteredby)
                    .HasMaxLength(30)
                    .HasColumnName("enteredby");

                entity.Property(e => e.ExpectedDateDelivery)
                    .HasColumnType("datetime")
                    .HasColumnName("expected_date_delivery");

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.LevEndDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lev_end_date");

                entity.Property(e => e.LevStartDate)
                    .HasColumnType("datetime")
                    .HasColumnName("lev_start_date");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(30)
                    .HasColumnName("updatedby");

                entity.Property(e => e.Updatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatetime");
            });

            modelBuilder.Entity<DgPayMonthlyattendance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_pay_monthlyattendance");

                entity.Property(e => e.Absent)
                    .HasColumnType("decimal(18, 1)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.D1)
                    .HasMaxLength(2)
                    .HasColumnName("d1")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D10)
                    .HasMaxLength(2)
                    .HasColumnName("d10")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D11)
                    .HasMaxLength(2)
                    .HasColumnName("d11")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D12)
                    .HasMaxLength(2)
                    .HasColumnName("d12")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D13)
                    .HasMaxLength(2)
                    .HasColumnName("d13")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D14)
                    .HasMaxLength(2)
                    .HasColumnName("d14")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D15)
                    .HasMaxLength(2)
                    .HasColumnName("d15")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D16)
                    .HasMaxLength(2)
                    .HasColumnName("d16")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D17)
                    .HasMaxLength(2)
                    .HasColumnName("d17")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D18)
                    .HasMaxLength(2)
                    .HasColumnName("d18")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D19)
                    .HasMaxLength(2)
                    .HasColumnName("d19")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D2)
                    .HasMaxLength(2)
                    .HasColumnName("d2")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D20)
                    .HasMaxLength(2)
                    .HasColumnName("d20")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D21)
                    .HasMaxLength(2)
                    .HasColumnName("d21")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D22)
                    .HasMaxLength(2)
                    .HasColumnName("d22")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D23)
                    .HasMaxLength(2)
                    .HasColumnName("d23")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D24)
                    .HasMaxLength(2)
                    .HasColumnName("d24")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D25)
                    .HasMaxLength(2)
                    .HasColumnName("d25")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D26)
                    .HasMaxLength(2)
                    .HasColumnName("d26")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D27)
                    .HasMaxLength(2)
                    .HasColumnName("d27")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D28)
                    .HasMaxLength(2)
                    .HasColumnName("d28")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D29)
                    .HasMaxLength(2)
                    .HasColumnName("d29")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D3)
                    .HasMaxLength(2)
                    .HasColumnName("d3")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D30)
                    .HasMaxLength(2)
                    .HasColumnName("d30")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D31)
                    .HasMaxLength(2)
                    .HasColumnName("d31")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D4)
                    .HasMaxLength(2)
                    .HasColumnName("d4")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D5)
                    .HasMaxLength(2)
                    .HasColumnName("d5")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D6)
                    .HasMaxLength(2)
                    .HasColumnName("d6")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D7)
                    .HasMaxLength(2)
                    .HasColumnName("d7")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D8)
                    .HasMaxLength(2)
                    .HasColumnName("d8")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.D9)
                    .HasMaxLength(2)
                    .HasColumnName("d9")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Late)
                    .HasColumnType("decimal(18, 1)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Leave)
                    .HasColumnType("decimal(18, 1)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.MEmpserial)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("m_empserial");

                entity.Property(e => e.MMonth)
                    .HasColumnType("date")
                    .HasColumnName("m_month");

                entity.Property(e => e.Present)
                    .HasColumnType("decimal(18, 1)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Spholidays)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("SPHolidays")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.TotWorkingDays)
                    .HasColumnType("decimal(18, 1)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Wholidays)
                    .HasColumnType("decimal(18, 1)")
                    .HasColumnName("WHolidays")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DgPayProcess>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_pay_Process");

                entity.Property(e => e.PrCompid).HasColumnName("pr_compid");

                entity.Property(e => e.PrConfUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("pr_conf_udate");

                entity.Property(e => e.PrConfUser)
                    .HasMaxLength(15)
                    .HasColumnName("pr_conf_user");

                entity.Property(e => e.PrConfirm)
                    .HasColumnName("pr_confirm")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PrDate)
                    .HasColumnType("date")
                    .HasColumnName("pr_date");

                entity.Property(e => e.PrGroupid).HasColumnName("pr_groupid");

                entity.Property(e => e.PrUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("pr_udate");

                entity.Property(e => e.PrUser)
                    .HasMaxLength(15)
                    .HasColumnName("pr_user");
            });

            modelBuilder.Entity<DgPayReportformat>(entity =>
            {
                entity.HasKey(e => e.RepId)
                    .HasName("PK_Pay_ReportFormats");

                entity.ToTable("dg_pay_reportformats");

                entity.Property(e => e.RepId)
                    .HasMaxLength(50)
                    .HasColumnName("rep_id");

                entity.Property(e => e.RepFilename)
                    .HasMaxLength(50)
                    .HasColumnName("rep_filename");

                entity.Property(e => e.RepGroupid).HasColumnName("rep_groupid");
            });

            modelBuilder.Entity<DgPayReportname>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_pay_reportnames");

                entity.Property(e => e.Compliance)
                    .HasMaxLength(2)
                    .HasColumnName("compliance");

                entity.Property(e => e.Rcat)
                    .HasMaxLength(3)
                    .HasColumnName("rcat");

                entity.Property(e => e.Rid).HasColumnName("rid");

                entity.Property(e => e.Rname)
                    .HasMaxLength(50)
                    .HasColumnName("rname");
            });

            modelBuilder.Entity<DgPaySalaryAdvance>(entity =>
            {
                entity.HasKey(e => new { e.SsDate, e.SsEmpSerial })
                    .HasName("PK_Pay_Salary_Advance");

                entity.ToTable("dg_pay_salary_advance");

                entity.Property(e => e.SsDate)
                    .HasColumnType("date")
                    .HasColumnName("ss_date");

                entity.Property(e => e.SsEmpSerial)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_emp_serial");

                entity.Property(e => e.SsAbsence)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_absence");

                entity.Property(e => e.SsAbsentdays).HasColumnName("ss_absentdays");

                entity.Property(e => e.SsAdvance)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_advance");

                entity.Property(e => e.SsAnualleave).HasColumnName("ss_anualleave");

                entity.Property(e => e.SsAttbonus)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_attbonus");

                entity.Property(e => e.SsBasicsalary)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_basicsalary")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsCasualleave).HasColumnName("ss_casualleave");

                entity.Property(e => e.SsCompid).HasColumnName("ss_compid");

                entity.Property(e => e.SsConfirmed)
                    .HasColumnName("ss_confirmed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsEdays).HasColumnName("ss_edays");

                entity.Property(e => e.SsFood)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_food")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsGrossalary)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_grossalary")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsGrossalaryPay)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_grossalaryPay");

                entity.Property(e => e.SsGroupid).HasColumnName("ss_groupid");

                entity.Property(e => e.SsHouserent)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_houserent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsMeal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_meal");

                entity.Property(e => e.SsMedical)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_medical")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsMedicalleave).HasColumnName("ss_medicalleave");

                entity.Property(e => e.SsNetsalary)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_netsalary");

                entity.Property(e => e.SsNetsalaryEx)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_netsalaryEX");

                entity.Property(e => e.SsOtherallowances)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_otherallowances");

                entity.Property(e => e.SsOtherdeduction)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_otherdeduction");

                entity.Property(e => e.SsOvertimehrs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ss_overtimehrs");

                entity.Property(e => e.SsOvertimehrsEx)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ss_overtimehrsEX");

                entity.Property(e => e.SsOvertimerate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ss_overtimerate");

                entity.Property(e => e.SsOvertimerateEx)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ss_overtimerateEX");

                entity.Property(e => e.SsOvertimevalue)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_overtimevalue");

                entity.Property(e => e.SsOvertimevalueEx)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_overtimevalueEX");

                entity.Property(e => e.SsPayablesal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_payablesal");

                entity.Property(e => e.SsPf)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_pf");

                entity.Property(e => e.SsPresentdays).HasColumnName("ss_presentdays");

                entity.Property(e => e.SsSpacola)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_spacola")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsSpecialholidays).HasColumnName("ss_specialholidays");

                entity.Property(e => e.SsStamp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_stamp");

                entity.Property(e => e.SsTax)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_tax");

                entity.Property(e => e.SsTraveling)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_traveling")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsWeeklyholidays).HasColumnName("ss_weeklyholidays");

                entity.Property(e => e.SsWorkabledays).HasColumnName("ss_workabledays");
            });

            modelBuilder.Entity<DgPaySalaryAdvanceLog>(entity =>
            {
                entity.HasKey(e => e.Serial);

                entity.ToTable("dg_Pay_Salary_Advance_Log");

                entity.Property(e => e.Serial).HasColumnName("serial");

                entity.Property(e => e.SaplCompid).HasColumnName("sapl_compid");

                entity.Property(e => e.SaplDate)
                    .HasColumnType("date")
                    .HasColumnName("sapl_date");

                entity.Property(e => e.SaplDays).HasColumnName("sapl_days");

                entity.Property(e => e.SaplUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("sapl_udate");

                entity.Property(e => e.SaplUser)
                    .HasMaxLength(15)
                    .HasColumnName("sapl_user");
            });

            modelBuilder.Entity<DgPaySalarycategory>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PK_Pay_SalaryCategory");

                entity.ToTable("dg_pay_salarycategory");

                entity.Property(e => e.CatId).HasColumnName("cat_id");

                entity.Property(e => e.CatName)
                    .HasMaxLength(30)
                    .HasColumnName("cat_name");

                entity.Property(e => e.CatOt)
                    .HasColumnName("cat_ot")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CtGroupid).HasColumnName("ct_groupid");
            });

            modelBuilder.Entity<DgPaySalaryconfirmation>(entity =>
            {
                entity.HasKey(e => e.PrSerial);

                entity.ToTable("dg_pay_salaryconfirmation");

                entity.Property(e => e.PrSerial).HasColumnName("pr_serial");

                entity.Property(e => e.PrCode)
                    .HasMaxLength(3)
                    .HasColumnName("pr_code");

                entity.Property(e => e.PrCompid).HasColumnName("pr_compid");

                entity.Property(e => e.PrConfUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("pr_conf_udate");

                entity.Property(e => e.PrConfUser)
                    .HasMaxLength(15)
                    .HasColumnName("pr_conf_user");

                entity.Property(e => e.PrConfirm).HasColumnName("pr_confirm");

                entity.Property(e => e.PrDate)
                    .HasColumnType("date")
                    .HasColumnName("pr_date");

                entity.Property(e => e.PrGroupid).HasColumnName("pr_groupid");

                entity.Property(e => e.PrUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("pr_udate");

                entity.Property(e => e.PrUser)
                    .HasMaxLength(15)
                    .HasColumnName("pr_user");
            });

            modelBuilder.Entity<DgPaySalarysheet>(entity =>
            {
                entity.HasKey(e => new { e.SsDate, e.SsEmpSerial })
                    .HasName("PK_Pay_SalarySheet")
                    .IsClustered(false);

                entity.ToTable("dg_pay_salarysheet");

                entity.Property(e => e.SsDate)
                    .HasColumnType("date")
                    .HasColumnName("ss_date");

                entity.Property(e => e.SsEmpSerial)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_emp_serial");

                entity.Property(e => e.SsAbsence)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_absence")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsAbsentdays)
                    .HasColumnName("ss_absentdays")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsActivestatus)
                    .HasMaxLength(10)
                    .HasColumnName("ss_activestatus");

                entity.Property(e => e.SsAdvance)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_advance")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsAnualleave)
                    .HasColumnName("ss_anualleave")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsArrears)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_arrears")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsAttbonus)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_attbonus")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsBasicsalary)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_basicsalary")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsCasualleave)
                    .HasColumnName("ss_casualleave")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsCompid).HasColumnName("ss_compid");

                entity.Property(e => e.SsConfirmed)
                    .HasColumnName("ss_confirmed")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsEdays)
                    .HasColumnName("ss_edays")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsFood)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_food")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsGrossalary)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_grossalary")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsGrossalaryPay)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_grossalaryPay")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsGroupid).HasColumnName("ss_groupid");

                entity.Property(e => e.SsHouserent)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_houserent")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsMeal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_meal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsMedical)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_medical")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsMedicalleave)
                    .HasColumnName("ss_medicalleave")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsNetsalary)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_netsalary")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsNetsalaryEx)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_netsalaryEX")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsOtherallowances)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_otherallowances")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsOtherdeduction)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_otherdeduction")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsOvertimehrs)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ss_overtimehrs")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsOvertimehrsEx)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ss_overtimehrsEX")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsOvertimehrsExCom2)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ss_overtimehrsEX_com2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsOvertimerate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ss_overtimerate")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsOvertimerateEx)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ss_overtimerateEX")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsOvertimevalue)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_overtimevalue")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsOvertimevalueEx)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_overtimevalueEX")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsOvertimevalueExCom2)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ss_overtimevalueEX_com2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsPayablesal)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_payablesal")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsPf)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_pf")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsPresentdays)
                    .HasColumnName("ss_presentdays")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsSpacola)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_spacola")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsSpecialholidays)
                    .HasColumnName("ss_specialholidays")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsStamp)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_stamp")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsTax)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_tax")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsTraveling)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("ss_traveling")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsWeeklyholidays)
                    .HasColumnName("ss_weeklyholidays")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.SsWorkabledays)
                    .HasColumnName("ss_workabledays")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<DgPaySection>(entity =>
            {
                entity.HasKey(e => e.NSectionId);

                entity.ToTable("dg_pay_Section");

                entity.Property(e => e.NSectionId).HasColumnName("nSectionID");

                entity.Property(e => e.CEntUser)
                    .HasMaxLength(15)
                    .HasColumnName("cEntUser");

                entity.Property(e => e.CSectionBdname)
                    .HasMaxLength(50)
                    .HasColumnName("cSectionBDname");

                entity.Property(e => e.CSectionDescription)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("cSection_Description");

                entity.Property(e => e.CSupervisor)
                    .HasMaxLength(50)
                    .HasColumnName("cSupervisor");

                entity.Property(e => e.DEntdt)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("dEntdt");

                entity.Property(e => e.NCarder).HasColumnName("nCarder");

                entity.Property(e => e.NCompanyId).HasColumnName("nCompanyID");

                entity.Property(e => e.NCompanyName)
                    .HasMaxLength(50)
                    .HasColumnName("nCompanyName");

                entity.Property(e => e.NFloor).HasColumnName("nFloor");

                entity.Property(e => e.NHelper).HasColumnName("nHelper");

                entity.Property(e => e.NMachineOperator).HasColumnName("nMachine_Operator");

                entity.Property(e => e.NUserDept).HasColumnName("nUserDept");

                entity.Property(e => e.NUserDeptName)
                    .HasMaxLength(50)
                    .HasColumnName("nUserDeptName");

                entity.Property(e => e.Secnamebangla)
                    .HasMaxLength(50)
                    .HasColumnName("secnamebangla");
            });

            modelBuilder.Entity<DgPaySetup>(entity =>
            {
                entity.HasKey(e => new { e.SetupDescription, e.SetupCompGroup })
                    .HasName("PK_Pay_Setup");

                entity.ToTable("dg_pay_setup");

                entity.Property(e => e.SetupDescription)
                    .HasMaxLength(10)
                    .HasColumnName("Setup_description");

                entity.Property(e => e.SetupCompGroup).HasColumnName("Setup_CompGroup");

                entity.Property(e => e.SetupCode).HasColumnName("Setup_code");

                entity.Property(e => e.SetupStatus)
                    .HasMaxLength(10)
                    .HasColumnName("Setup_Status");

                entity.Property(e => e.SetupTitle)
                    .HasMaxLength(30)
                    .HasColumnName("Setup_Title");

                entity.Property(e => e.SetupValue)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("Setup_value");
            });

            modelBuilder.Entity<DgPayShift>(entity =>
            {
                entity.HasKey(e => e.ShCode)
                    .HasName("PK_Pay_Shift");

                entity.ToTable("dg_pay_shift");

                entity.Property(e => e.ShCode).HasColumnName("sh_code");

                entity.Property(e => e.IntimeStart)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("intime_start");

                entity.Property(e => e.IntimeStop)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("intime_stop");

                entity.Property(e => e.LunchHours).HasColumnName("lunch_hours");

                entity.Property(e => e.OuttimeStart)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("outtime_start");

                entity.Property(e => e.OuttimeStop)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("outtime_stop");

                entity.Property(e => e.ShComp).HasColumnName("sh_comp");

                entity.Property(e => e.ShCompName)
                    .HasMaxLength(50)
                    .HasColumnName("sh_compName");

                entity.Property(e => e.ShComplianceOut)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sh_ComplianceOut");

                entity.Property(e => e.ShGroupid).HasColumnName("sh_groupid");

                entity.Property(e => e.ShInTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sh_InTime");

                entity.Property(e => e.ShLateafter)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sh_Lateafter");

                entity.Property(e => e.ShName)
                    .HasMaxLength(20)
                    .HasColumnName("sh_name");

                entity.Property(e => e.ShOtcountTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sh_OTCountTime");

                entity.Property(e => e.ShOutTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("sh_OutTime");

                entity.Property(e => e.ShSameDayOut)
                    .HasColumnName("sh_SameDayOut")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("sh_udate");

                entity.Property(e => e.ShUser)
                    .HasMaxLength(15)
                    .HasColumnName("sh_user");
            });

            modelBuilder.Entity<DgPayShiftChange>(entity =>
            {
                entity.HasKey(e => e.ScSerial);

                entity.ToTable("dg_pay_shift_change");

                entity.Property(e => e.ScSerial).HasColumnName("sc_serial");

                entity.Property(e => e.ScEffectDate)
                    .HasColumnType("date")
                    .HasColumnName("sc_effect_date");

                entity.Property(e => e.ScEmpserial)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("sc_empserial");

                entity.Property(e => e.ScEndDate)
                    .HasColumnType("date")
                    .HasColumnName("sc_end_date");

                entity.Property(e => e.ScNewShift).HasColumnName("sc_new_shift");

                entity.Property(e => e.ScOldShift).HasColumnName("sc_old_shift");

                entity.Property(e => e.ScUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("sc_udate");

                entity.Property(e => e.ScUser)
                    .HasMaxLength(15)
                    .HasColumnName("sc_user");
            });

            modelBuilder.Entity<DgPaySpecialholiday>(entity =>
            {
                entity.HasKey(e => e.Serial);

                entity.ToTable("dg_pay_specialholidays");

                entity.Property(e => e.Serial).HasColumnName("serial");

                entity.Property(e => e.ShCompName)
                    .HasMaxLength(50)
                    .HasColumnName("sh_compName");

                entity.Property(e => e.ShCompid).HasColumnName("sh_compid");

                entity.Property(e => e.ShDate)
                    .HasColumnType("date")
                    .HasColumnName("sh_date");

                entity.Property(e => e.ShDescription)
                    .HasMaxLength(30)
                    .HasColumnName("sh_description");

                entity.Property(e => e.ShGroupid).HasColumnName("sh_groupid");

                entity.Property(e => e.ShUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("sh_udate");

                entity.Property(e => e.ShUser)
                    .HasMaxLength(15)
                    .HasColumnName("sh_user");
            });

            modelBuilder.Entity<DgPayStampduty>(entity =>
            {
                entity.HasKey(e => new { e.SdSalcat, e.SdCompid, e.SdGroupid })
                    .HasName("PK_Pay_StampDuty");

                entity.ToTable("dg_pay_stampduty");

                entity.Property(e => e.SdSalcat).HasColumnName("sd_salcat");

                entity.Property(e => e.SdCompid).HasColumnName("sd_compid");

                entity.Property(e => e.SdGroupid).HasColumnName("sd_groupid");

                entity.Property(e => e.SdStapduty)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("sd_stapduty");

                entity.Property(e => e.SdUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("sd_udate");

                entity.Property(e => e.SdUser)
                    .HasMaxLength(15)
                    .HasColumnName("sd_user");
            });

            modelBuilder.Entity<DgPayThana>(entity =>
            {
                entity.HasKey(e => e.ThId);

                entity.ToTable("dg_pay_thana");

                entity.Property(e => e.ThId).HasColumnName("th_id");

                entity.Property(e => e.ThDisname)
                    .HasMaxLength(30)
                    .HasColumnName("th_disname");

                entity.Property(e => e.ThDistrict).HasColumnName("th_district");

                entity.Property(e => e.ThDivision).HasColumnName("th_division");

                entity.Property(e => e.ThDivname)
                    .HasMaxLength(30)
                    .HasColumnName("th_divname");

                entity.Property(e => e.ThGroupid).HasColumnName("th_groupid");

                entity.Property(e => e.ThName)
                    .HasMaxLength(30)
                    .HasColumnName("th_name");

                entity.Property(e => e.ThNameBangla)
                    .HasMaxLength(30)
                    .HasColumnName("th_nameBangla");

                entity.Property(e => e.ThUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("th_udate");

                entity.Property(e => e.ThUser)
                    .HasMaxLength(15)
                    .HasColumnName("th_user");
            });

            modelBuilder.Entity<DgPayTiffinBillRulesdesignationwise>(entity =>
            {
                entity.HasKey(e => e.Serial);

                entity.ToTable("dg_Pay_TiffinBillRulesdesignationwise");

                entity.Property(e => e.Serial).HasColumnName("serial");

                entity.Property(e => e.Addtime)
                    .HasColumnType("datetime")
                    .HasColumnName("addtime");

                entity.Property(e => e.AmountPerDay).HasColumnName("amount_perDay");

                entity.Property(e => e.ComCode).HasColumnName("com_code");

                entity.Property(e => e.Designation).HasColumnName("designation");

                entity.Property(e => e.Entedby)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("entedby");

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("updatedby");

                entity.Property(e => e.Updatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatetime");

                entity.Property(e => e.UptoTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("upto_time");
            });

            modelBuilder.Entity<DgPayTiffinbillrule>(entity =>
            {
                entity.HasKey(e => e.Serial);

                entity.ToTable("dg_pay_tiffinbillrules");

                entity.Property(e => e.Serial).HasColumnName("serial");

                entity.Property(e => e.Addtime)
                    .HasColumnType("datetime")
                    .HasColumnName("addtime");

                entity.Property(e => e.AmountPerDay).HasColumnName("amount_perDay");

                entity.Property(e => e.Category).HasColumnName("category");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(20)
                    .HasColumnName("categoryName");

                entity.Property(e => e.ComCode).HasColumnName("com_code");

                entity.Property(e => e.ComName)
                    .HasMaxLength(50)
                    .HasColumnName("com_Name");

                entity.Property(e => e.Entedby)
                    .HasMaxLength(30)
                    .HasColumnName("entedby");

                entity.Property(e => e.GroupId).HasColumnName("groupID");

                entity.Property(e => e.Updatedby)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("updatedby");

                entity.Property(e => e.Updatetime)
                    .HasColumnType("datetime")
                    .HasColumnName("updatetime");

                entity.Property(e => e.UptoTime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("upto_time");
            });

            modelBuilder.Entity<DgPayUser>(entity =>
            {
                entity.HasKey(e => e.NUserId)
                    .HasName("PK_Users_1");

                entity.ToTable("dg_pay_Users");

                entity.Property(e => e.NUserId).HasColumnName("nUserID");

                entity.Property(e => e.ActivityStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Activity_status");

                entity.Property(e => e.CEntDate)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("cEntDate")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.CPassWord)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cPassWord");

                entity.Property(e => e.CUserFullname)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("cUserFullname");

                entity.Property(e => e.CUserName)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("cUserName");

                entity.Property(e => e.Compliance)
                    .HasColumnName("compliance")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Compliance2)
                    .HasColumnName("compliance2")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NCompanyId).HasColumnName("nCompanyID");

                entity.Property(e => e.NSectionId).HasColumnName("nSectionID");

                entity.Property(e => e.NUgroup).HasColumnName("nUgroup");

                entity.Property(e => e.NUlevelId).HasColumnName("nULevelID");

                entity.Property(e => e.NUserDept).HasColumnName("nUserDept");

                entity.Property(e => e.PermissionStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Permission_status");

                entity.Property(e => e.Signtr)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("signtr");

                entity.Property(e => e.ThemeImg)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("theme_img");

                entity.Property(e => e.ThemeName)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("theme_Name");

                entity.Property(e => e.UserType)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("user_type")
                    .IsFixedLength();
            });

            modelBuilder.Entity<DgPemp1>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_pemp1");

                entity.Property(e => e.AtDate)
                    .HasColumnType("date")
                    .HasColumnName("at_date");

                entity.Property(e => e.AtEmpSerial)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("at_emp_serial");

                entity.Property(e => e.AtProxid)
                    .HasMaxLength(10)
                    .HasColumnName("at_proxid");

                entity.Property(e => e.AtStatus)
                    .HasMaxLength(30)
                    .HasColumnName("at_status");

                entity.Property(e => e.AtStatusCode)
                    .HasMaxLength(3)
                    .HasColumnName("at_status_code");

                entity.Property(e => e.EmpNo).HasColumnName("emp_no");

                entity.Property(e => e.OiDesignation).HasColumnName("oi_designation");

                entity.Property(e => e.PiFullname)
                    .HasMaxLength(45)
                    .HasColumnName("pi_fullname");
            });

            modelBuilder.Entity<DgPrintEmployeelist>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_print_employeelist");

                entity.Property(e => e.PlCompid).HasColumnName("pl_compid");

                entity.Property(e => e.PlEmpserial).HasColumnName("pl_empserial");

                entity.Property(e => e.PlEnddate)
                    .HasColumnType("date")
                    .HasColumnName("pl_Enddate");

                entity.Property(e => e.PlStartdate)
                    .HasColumnType("date")
                    .HasColumnName("pl_Startdate");

                entity.Property(e => e.PlUser)
                    .HasMaxLength(15)
                    .HasColumnName("pl_user");
            });

            modelBuilder.Entity<DgPrintEmployeelistAtttendance>(entity =>
            {
                entity.HasKey(e => e.Sl);

                entity.ToTable("dg_print_employeelist_atttendance");

                entity.Property(e => e.Sl).HasColumnName("SL");

                entity.Property(e => e.PlCompid).HasColumnName("pl_compid");

                entity.Property(e => e.PlEmpserial).HasColumnName("pl_empserial");

                entity.Property(e => e.PlEnddate)
                    .HasColumnType("date")
                    .HasColumnName("pl_Enddate");

                entity.Property(e => e.PlStartdate)
                    .HasColumnType("date")
                    .HasColumnName("pl_Startdate");

                entity.Property(e => e.PlUser)
                    .HasMaxLength(15)
                    .HasColumnName("pl_user");
            });

            modelBuilder.Entity<DgPrintEmployeelistLeave>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_print_employeelist_leave");

                entity.Property(e => e.PlCompid).HasColumnName("pl_compid");

                entity.Property(e => e.PlEmpserial).HasColumnName("pl_empserial");

                entity.Property(e => e.PlEnddate)
                    .HasColumnType("date")
                    .HasColumnName("pl_Enddate");

                entity.Property(e => e.PlStartdate)
                    .HasColumnType("date")
                    .HasColumnName("pl_Startdate");

                entity.Property(e => e.PlUser)
                    .HasMaxLength(15)
                    .HasColumnName("pl_user");
            });

            modelBuilder.Entity<DgPrintEmployeelistSalary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_print_employeelist_salary");

                entity.Property(e => e.PlBuilding).HasColumnName("pl_building");

                entity.Property(e => e.PlCompid).HasColumnName("pl_compid");

                entity.Property(e => e.PlDepartment).HasColumnName("pl_department");

                entity.Property(e => e.PlEmpserial).HasColumnName("pl_empserial");

                entity.Property(e => e.PlEnddate)
                    .HasColumnType("date")
                    .HasColumnName("pl_Enddate");

                entity.Property(e => e.PlFloor).HasColumnName("pl_floor");

                entity.Property(e => e.PlLine).HasColumnName("pl_line");

                entity.Property(e => e.PlSalcat).HasColumnName("pl_salcat");

                entity.Property(e => e.PlSection).HasColumnName("pl_section");

                entity.Property(e => e.PlStartdate)
                    .HasColumnType("date")
                    .HasColumnName("pl_Startdate");

                entity.Property(e => e.PlUser)
                    .HasMaxLength(15)
                    .HasColumnName("pl_user");
            });

            modelBuilder.Entity<DgPrintShiftchange>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("dg_print_shiftchange");

                entity.Property(e => e.PlCompid).HasColumnName("pl_compid");

                entity.Property(e => e.PlEmpserial).HasColumnName("pl_empserial");

                entity.Property(e => e.PlEnddate)
                    .HasColumnType("date")
                    .HasColumnName("pl_Enddate");

                entity.Property(e => e.PlStartdate)
                    .HasColumnType("date")
                    .HasColumnName("pl_Startdate");

                entity.Property(e => e.PlUser)
                    .HasMaxLength(15)
                    .HasColumnName("pl_user");
            });

            modelBuilder.Entity<DgStampcharge>(entity =>
            {
                entity.ToTable("dg_stampcharge");

                entity.Property(e => e.ComId).HasColumnName("comID");

                entity.Property(e => e.ComName)
                    .HasMaxLength(50)
                    .HasColumnName("comName");

                entity.Property(e => e.Stamp).HasColumnName("stamp");
            });

            modelBuilder.Entity<ECard>(entity =>
            {
                entity.ToTable("E_card");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(10);
            });

            modelBuilder.Entity<SalaryConfarmation>(entity =>
            {
                entity.HasKey(e => e.Serial);

                entity.ToTable("Salary_confarmation");

                entity.Property(e => e.CMonth)
                    .HasColumnType("date")
                    .HasColumnName("C_month");

                entity.Property(e => e.CStatus).HasColumnName("C_status");

                entity.Property(e => e.CYear)
                    .HasColumnType("date")
                    .HasColumnName("C_year");
            });

            modelBuilder.Entity<Serial>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("serial");

                entity.Property(e => e.EmpSerial)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("emp_serial");
            });

            modelBuilder.Entity<Table1>(entity =>
            {
                entity.ToTable("Table_1");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Extansion)
                    .HasMaxLength(100)
                    .HasColumnName("extansion");

                entity.Property(e => e.Name)
                    .HasMaxLength(10)
                    .HasColumnName("name");
            });

            modelBuilder.Entity<TblUser>(entity =>
            {
                entity.ToTable("Tbl_User");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActiveStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Active_status");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasMaxLength(10)
                    .HasColumnName("Emp_ID")
                    .IsFixedLength();

                entity.Property(e => e.EmpSerial).HasColumnName("Emp_serial");

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(50);
            });

            modelBuilder.Entity<UploadAttendance>(entity =>
            {
                entity.HasKey(e => e.Sl);

                entity.ToTable("upload attendance");

                entity.Property(e => e.Sl).HasColumnName("sl");

                entity.Property(e => e.Filename)
                    .HasMaxLength(50)
                    .HasColumnName("filename");

                entity.Property(e => e.Udate)
                    .HasColumnType("datetime")
                    .HasColumnName("udate");

                entity.Property(e => e.Uname)
                    .HasMaxLength(50)
                    .HasColumnName("uname");
            });

            modelBuilder.Entity<UploadNewgazeeteSalary>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("upload_newgazeete_salary");

                entity.Property(e => e.CurrentGross)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("current_gross");

                entity.Property(e => e.EmpId).HasColumnName("emp_id");

                entity.Property(e => e.IncAmount)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("inc_amount");

                entity.Property(e => e.PrvGross).HasColumnName("prv_gross");

                entity.Property(e => e.Slno)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("slno");
            });

            modelBuilder.Entity<ViewEcard>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_ECard");

                entity.Property(e => e.AtCompid).HasColumnName("at_compid");

                entity.Property(e => e.AtCoverday).HasColumnName("at_coverday");

                entity.Property(e => e.AtDate)
                    .HasColumnType("date")
                    .HasColumnName("at_date");

                entity.Property(e => e.AtEmpSerial).HasColumnName("at_emp_serial");

                entity.Property(e => e.AtHoliday)
                    .HasMaxLength(2)
                    .HasColumnName("at_holiday");

                entity.Property(e => e.AtIntime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_intime");

                entity.Property(e => e.AtLate)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_late");

                entity.Property(e => e.AtManual).HasColumnName("at_manual");

                entity.Property(e => e.AtOuttime)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("at_outtime");

                entity.Property(e => e.AtStatus)
                    .HasMaxLength(30)
                    .HasColumnName("at_status");

                entity.Property(e => e.AtStatusCode)
                    .HasMaxLength(3)
                    .HasColumnName("at_status_code");

                entity.Property(e => e.AtUdate)
                    .HasColumnType("datetime")
                    .HasColumnName("at_udate");

                entity.Property(e => e.AtUser)
                    .HasMaxLength(15)
                    .HasColumnName("at_user");

                entity.Property(e => e.EmpNo).HasColumnName("emp_no");

                entity.Property(e => e.EmpSerial).HasColumnName("emp_serial");

                entity.Property(e => e.Exot)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("EXOT");

                entity.Property(e => e.Exotcomp)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("EXOTComp");

                entity.Property(e => e.ExotcompHr).HasColumnName("EXOTComp_Hr");

                entity.Property(e => e.ExotcompMin)
                    .HasColumnType("decimal(17, 2)")
                    .HasColumnName("EXOTComp_Min");

                entity.Property(e => e.Exothd)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("EXOTHD");

                entity.Property(e => e.Ot)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OT");

                entity.Property(e => e.Otcomp)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTComp");

                entity.Property(e => e.Othd)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("OTHD");

                entity.Property(e => e.ShCode).HasColumnName("sh_code");

                entity.Property(e => e.ShName)
                    .HasMaxLength(20)
                    .HasColumnName("sh_name");

                entity.Property(e => e.Whot)
                    .HasColumnType("decimal(12, 2)")
                    .HasColumnName("WHOT");

                entity.Property(e => e.Wkhrs)
                    .HasColumnType("decimal(10, 2)")
                    .HasColumnName("WKHRS");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
