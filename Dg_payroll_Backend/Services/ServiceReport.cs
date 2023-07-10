using AspNetCore.Reporting;
using AspNetCore.Reporting.ReportExecutionService;
using Dg_payroll.Services;
using ReportApi.Utility;
using System.Data;
using System.Text;

namespace ReportApi.Service
{
    public class ServiceReport : IServiceReport
    {
        BLL _myBll = new BLL();
        public byte[] CreateReportFile(string pathRdlc)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            LocalReport report = new LocalReport(pathRdlc);
            DataTable dt = _myBll.get_AspCoreInformationdataTable("select * from tbl_employee");
            report.AddDataSource("DataSet1", dt);
            var result = report.Execute(RenderType.Pdf, 1);
            return result.MainStream;
        }
        public byte[] CreateReportFile1(string pathRdlc)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            LocalReport report = new LocalReport(pathRdlc);
            DataTable dt = _myBll.get_dgDataTable("UserDto");
            report.AddDataSource("DataSet1", dt);
            var result = report.Execute(RenderType.Pdf, 1);
            return result.MainStream;
        }
        public byte[] CreateReportFile2(string pathRdlc)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            LocalReport report = new LocalReport(pathRdlc);
            DataTable dt = _myBll.get_dgDataTable("Dg_Pay_Rep_EmployeeDetails");
            report.AddDataSource("DataSet1", dt);
            //ReportParameter pTitle = new ReportParameter ("pTitle","C# UI ACADEMY");
            var result = report.Execute(RenderType.Pdf, 1);
            return result.MainStream;
        }

        public byte[] CreateReportFile_inactive (string pathRdlc)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            LocalReport report = new LocalReport(pathRdlc);
            DataTable dt = _myBll.get_dgDataTable("Dg_Pay_Rep_EmployeeDetails_inactive");
            report.AddDataSource("DataSet1", dt);
            //ReportParameter pTitle = new ReportParameter ("pTitle","C# UI ACADEMY");
            var result = report.Execute(RenderType.Pdf, 1);
            return result.MainStream;
        }

        public byte[] CreateReportFile3(string pathRdlc, string categoryName)
        {
            //Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            //LocalReport report = new LocalReport(pathRdlc);
            //DataTable dt = _myBll.get_dgDataTable("Dg_Pay_Rep_EmployeeDetails");
            //report.AddDataSource("DataSet1", dt);
            ////ReportParameter pTitle = new ReportParameter ("pTitle","C# UI ACADEMY");
            //var result = report.Execute(RenderType.Pdf, 1);
            //return result.MainStream;

            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            LocalReport report = new LocalReport(pathRdlc);
            DataTable dt = _myBll.get_dgDataTable("Dg_Pay_Rep_EmployeeDetails ");
            report.AddDataSource("DataSet1", dt);
            var result = report.Execute(RenderType.Pdf, 1);
            return result.MainStream;
            //'" + categoryName + "'
        }

        public byte[] CreateReportFile4(string pathRdlc)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            LocalReport report = new LocalReport(pathRdlc);
            DataTable dt = _myBll.get_dgDataTable("Dg_Pay_Rep_EmployeeDetails");
            report.AddDataSource("ID", dt);
            //ReportParameter pTitle = new ReportParameter ("pTitle","C# UI ACADEMY");
            var result = report.Execute(RenderType.Pdf, 1);
            return result.MainStream;
        }

        public byte[] CreateReportFile_salarysheet_D(string pathRdlc)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            LocalReport report = new LocalReport(pathRdlc);
            DataTable dt = _myBll.get_dgDataTable("dg_Pay_Rep_Sal_SalarySheet_D");
            //DataTable dt = _myBll.get_dgDataTable("Dg_Pay_Rep_EmployeeDetails");
            report.AddDataSource("DataSet1", dt);
            //ReportParameter pTitle = new ReportParameter ("pTitle","C# UI ACADEMY");
            var result = report.Execute(RenderType.Pdf, 1);
            return result.MainStream;
        }

        public byte[] CreateReportFile_Abc(string pathRdlc)
        {
            string ImageUrl = string.Empty;
            //var byteRes = new byte[] { };
            string HostUrl = "https://localhost:7211/";
            ImageUrl = HostUrl + "uploads/Product/" + 1709 + ".jpg";
            //var imageData = System.IO.File.ReadAllBytes("uploads/Product/\" + 1709 + \".jpg");
            //peramett
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            LocalReport report = new LocalReport(pathRdlc);
            DataTable dt = _myBll.get_dgDataTable("Dg_Pay_Rep_EmployeeDetails");
            report.AddDataSource("ID", dt);
            var result = report.Execute(RenderType.Pdf, 1);
            return result.MainStream;
        }
        public byte[] CreateReportFile_Ecard(string pathRdlc)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            LocalReport report = new LocalReport(pathRdlc);
            DataTable dt = _myBll.get_dgDataTable("dg_Ecard_Report");
            report.AddDataSource("Ecard", dt);
            var result = report.Execute(RenderType.Pdf, 1);
            return result.MainStream;
        }
        public byte[] CreateReportFile_Payslip(string pathRdlc)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            LocalReport report = new LocalReport(pathRdlc);
            DataTable dt = _myBll.get_dgDataTable("dg_Rep_Sal_PaySlip");
            report.AddDataSource("PaySlip", dt);
            var result = report.Execute(RenderType.Pdf, 1);
            return result.MainStream;
        }

        public byte[] CreateReportFile_Attendance_Present(string pathRdlc)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            LocalReport report = new LocalReport(pathRdlc);
            DataTable dt = _myBll.get_dgDataTable("Dg_Pay_Rep_Att_InOut");
            report.AddDataSource("DataSet1", dt);
            var result = report.Execute(RenderType.Pdf, 1);
            return result.MainStream;
        }

        public byte[] CreateReportFile_Attendance_Absent(string pathRdlc)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            LocalReport report = new LocalReport(pathRdlc);
            DataTable dt = _myBll.get_dgDataTable("Dg_Pay_Rep_Att_Absent");
            report.AddDataSource("DataSet1", dt);
            var result = report.Execute(RenderType.Pdf, 1);
            return result.MainStream;
        }
        public byte[] CreateReportFile_Attendance_Late(string pathRdlc)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            LocalReport report = new LocalReport(pathRdlc);
            DataTable dt = _myBll.get_dgDataTable("Dg_Pay_Rep_Att_Late");
            report.AddDataSource("DataSet1", dt);
            var result = report.Execute(RenderType.Pdf, 1);
            return result.MainStream;
        }
        public byte[] CreateReportFile_Attendance_Innotpunch(string pathRdlc)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            LocalReport report = new LocalReport(pathRdlc);
            DataTable dt = _myBll.get_dgDataTable("Dg_Pay_Rep_Att_NoInPunch");
            report.AddDataSource("DataSet1", dt);
            var result = report.Execute(RenderType.Pdf, 1);
            return result.MainStream;
        }
        public byte[] CreateReportFile_Attendance_Outnotpunch(string pathRdlc)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            LocalReport report = new LocalReport(pathRdlc);
            DataTable dt = _myBll.get_dgDataTable("Dg_Pay_Rep_Att_NoOutPunch");
            report.AddDataSource("DataSet1", dt);
            var result = report.Execute(RenderType.Pdf, 1);
            return result.MainStream;
        }
        public byte[] CreateReportFile_Attendance_InOutnotpunch(string pathRdlc)
        {
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
            LocalReport report = new LocalReport(pathRdlc);
            DataTable dt = _myBll.get_dgDataTable("Dg_Pay_Rep_Att_InOutNotPunch");
            report.AddDataSource("DataSet1", dt);
            var result = report.Execute(RenderType.Pdf, 1);
            return result.MainStream;
        }
    }
}
