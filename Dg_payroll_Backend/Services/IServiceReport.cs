namespace Dg_payroll.Services
{
    public interface IServiceReport
    {
        byte[] CreateReportFile(string pathRdlc);
        byte[] CreateReportFile1(string pathRdlc);
        byte[] CreateReportFile2(string pathRdlc);
        byte[] CreateReportFile3(string path, string categoryName);
        byte[] CreateReportFile4(string pathRdlc);
        byte[] CreateReportFile_salarysheet_D(string pathRdlc);
        byte[] CreateReportFile_Abc(string pathRdlc);
        byte[] CreateReportFile_Ecard(string pathRdlc);
        byte[] CreateReportFile_Payslip(string pathRdlc);
        byte[] CreateReportFile_inactive(string pathRdlc);
        byte[] CreateReportFile_Attendance_Present(string pathRdlc);
        byte[] CreateReportFile_Attendance_Absent (string pathRdlc);
        byte[] CreateReportFile_Attendance_Late (string pathRdlc);
        byte[] CreateReportFile_Attendance_Innotpunch (string pathRdlc);
        byte[] CreateReportFile_Attendance_Outnotpunch (string pathRdlc);
        byte[] CreateReportFile_Attendance_InOutnotpunch(string pathRdlc);
    }
}


