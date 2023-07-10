using Dg_payroll.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dg_payroll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReportController : ControllerBase
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IServiceReport _serviceReport;
        public ReportController(IServiceReport serviceReport, IWebHostEnvironment webHostEnvironment)
        {
            _serviceReport = serviceReport;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        [Route("Export_Data")]
        public IActionResult Export_Data()
        {
            var byteRes = new byte[] { };
            string path = $"{_webHostEnvironment.WebRootPath}\\Report\\TestReport.rdlc";
            byteRes = _serviceReport.CreateReportFile(path);
            return File(byteRes, System.Net.Mime.MediaTypeNames.Application.Octet, "ReportName.pdf");
        }

        [HttpGet]
        [Route("empinfo_Details")]
        public IActionResult empinfoDetails()
        {
            var byteRes = new byte[] { };
            string path = $"{_webHostEnvironment.WebRootPath}\\Report\\dg_employee_details.rdlc";
            byteRes = _serviceReport.CreateReportFile1(path);
            return File(byteRes, System.Net.Mime.MediaTypeNames.Application.Octet, "ReportName.pdf");
        }

        [HttpGet]
        [Route("Active List")]
        public IActionResult EmpActiveList()
        {
            var byteRes = new byte[] { };
            string path = $"{_webHostEnvironment.WebRootPath}\\Report\\dg_emp_details.rdlc";
            byteRes = _serviceReport.CreateReportFile2(path);
            return File(byteRes, System.Net.Mime.MediaTypeNames.Application.Octet, "ReportName.pdf");
        }

        [HttpGet]
        [Route("INActive List")]
        public IActionResult EmpINActiveList()
        {
            var byteRes = new byte[] { };
            string path = $"{_webHostEnvironment.WebRootPath}\\Report\\dg_Inactiveemp_details.rdlc";
            byteRes = _serviceReport.CreateReportFile_inactive(path);
            return File(byteRes, System.Net.Mime.MediaTypeNames.Application.Octet, "ReportName.pdf");
        }

        [HttpGet]
        [Route("IDCard")]
        public IActionResult IDCard(string categoryName)
        {
            //var byteRes = new byte[] { };
            //string path = $"{_webHostEnvironment.WebRootPath}\\Report\\IDCard.rdlc";
            //byteRes = _serviceReport.CreateReportFile3(path);
            //return File(byteRes, System.Net.Mime.MediaTypeNames.Application.Octet, "ReportName.pdf");

            
                var byteRes = new byte[] { };
                string path = $"{_webHostEnvironment.WebRootPath}\\Report\\dg_emp_details1.rdlc";
                byteRes = _serviceReport.CreateReportFile3(path, categoryName);
                return File(byteRes, System.Net.Mime.MediaTypeNames.Application.Octet, "ProductReport.pdf");
        }

        [HttpGet]
        [Route("IDCardDG")]
        public IActionResult IDCardDG()
        {
            var byteRes = new byte[] { };
            string path = $"{_webHostEnvironment.WebRootPath}\\Report\\idcard.rdlc";
            byteRes = _serviceReport.CreateReportFile4(path);
            return File(byteRes, System.Net.Mime.MediaTypeNames.Application.Octet, "ReportName.pdf");
        }

        [HttpGet]
        [Route("SalaryShert")]
        public IActionResult SalaryShert()
        {
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        var byteRes = new byte[] { };
            string path = $"{_webHostEnvironment.WebRootPath}\\Report\\Sal_Salarysheet.rdlc";
            byteRes = _serviceReport.CreateReportFile_salarysheet_D(path);
            return File(byteRes, System.Net.Mime.MediaTypeNames.Application.Octet, "ReportName.pdf");
        }

        //[HttpGet]
        //[Route("ID")]
        //public IActionResult ID()
        //{
        //    var byteRes = new byte[] { };
        //    string path = $"{_webHostEnvironment.WebRootPath}\\Report\\IDCard.rdlc";
        //    byteRes = _serviceReport.CreateReportFile_Abc(path);
        //    return File(byteRes, System.Net.Mime.MediaTypeNames.Application.Octet, "ReportName.pdf");
        //}
        [HttpGet]
        [Route("Ecard")]
        public IActionResult Ecard()
        {
            var byteRes = new byte[] { };
            string path = $"{_webHostEnvironment.WebRootPath}\\Report\\Ecard.rdlc";
            byteRes = _serviceReport.CreateReportFile_Ecard(path);
            return File(byteRes, System.Net.Mime.MediaTypeNames.Application.Octet, "ReportName.pdf");
        }
        [HttpGet]
        [Route("Payslip")]
        public IActionResult Payslip()
        {
            var byteRes = new byte[] { };
            string path = $"{_webHostEnvironment.WebRootPath}\\Report\\Sal_PaySlip_Debonir.rdlc";
            byteRes = _serviceReport.CreateReportFile_Payslip(path);
            return File(byteRes, System.Net.Mime.MediaTypeNames.Application.Octet, "ReportName.pdf");
        }

        [HttpGet]
        [Route("Present")]
        public IActionResult Present()
        {
            var byteRes = new byte[] { };
            string path = $"{_webHostEnvironment.WebRootPath}\\Report\\Att_inout.rdlc";
            byteRes = _serviceReport.CreateReportFile_Attendance_Present(path);
            return File(byteRes, System.Net.Mime.MediaTypeNames.Application.Octet, "ReportName.pdf");
        }

        [HttpGet]
        [Route("Absent")]
        public IActionResult Absent()
        {
            var byteRes = new byte[] { };
            string path = $"{_webHostEnvironment.WebRootPath}\\Report\\Attendance_Absent.rdlc";
            byteRes = _serviceReport.CreateReportFile_Attendance_Absent(path);
            return File(byteRes, System.Net.Mime.MediaTypeNames.Application.Octet, "ReportName.pdf");
        }

        [HttpGet]
        [Route("Late")]
        public IActionResult Late()
        {
            var byteRes = new byte[] { };
            string path = $"{_webHostEnvironment.WebRootPath}\\Report\\Attendance_Late.rdlc";
            byteRes = _serviceReport.CreateReportFile_Attendance_Late(path);
            return File(byteRes, System.Net.Mime.MediaTypeNames.Application.Octet, "ReportName.pdf");
        }

        [HttpGet]
        [Route("Innotpunch")]
        public IActionResult Innotpunch()
        {
            var byteRes = new byte[] { };
            string path = $"{_webHostEnvironment.WebRootPath}\\Report\\Attendance_In_Notpunch.rdlc";
            byteRes = _serviceReport.CreateReportFile_Attendance_Innotpunch(path);
            return File(byteRes, System.Net.Mime.MediaTypeNames.Application.Octet, "ReportName.pdf");
        }

        [HttpGet]
        [Route("Outnotpunch")]
        public IActionResult Outnotpunch()
        {
            var byteRes = new byte[] { };
            string path = $"{_webHostEnvironment.WebRootPath}\\Report\\Attendance_Out_Notpunch.rdlc";
            byteRes = _serviceReport.CreateReportFile_Attendance_Outnotpunch(path);
            return File(byteRes, System.Net.Mime.MediaTypeNames.Application.Octet, "ReportName.pdf");
        }

        [HttpGet]
        [Route("InOutnotpunch")]
        public IActionResult InOutnotpunch()
        {
            var byteRes = new byte[] { };
            string path = $"{_webHostEnvironment.WebRootPath}\\Report\\Attendance_InOut_Notpunch.rdlc";
            byteRes = _serviceReport.CreateReportFile_Attendance_InOutnotpunch(path);
            return File(byteRes, System.Net.Mime.MediaTypeNames.Application.Octet, "ReportName.pdf");
        }

    }


}
