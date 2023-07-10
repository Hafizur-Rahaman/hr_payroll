using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using Microsoft.Reporting.NETCore;
using System.Data;
using System.Data.SqlClient;

namespace Dg_payroll.Controllers
{
    public class ForhadController : Controller
    {
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ForhadController(IWebHostEnvironment webHostEnvironment)
        {
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowReport()
        {
            SqlConnection con = new SqlConnection("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");
            //[HttpGet("get-singleEmployee")]
            //async Task<ActionResult<IEnumerable<DgPayEmployee>>> singleEmployee()
            //{
            SqlDataAdapter com = new SqlDataAdapter("UserDto", con);
            com.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataSet ds = new DataSet();
            com.Fill(ds, "UserDto");
            var path = $"{_webHostEnvironment.WebRootPath}\\Report\\Report_test.rdlc";
            LocalReport localReport = new LocalReport();
            ReportDataSource reportDataSource = new ReportDataSource("DataSet1", ds.Tables[0]);
            

            localReport.ReportPath = path;
            localReport.DataSources.Clear();
            localReport.DataSources.Add(reportDataSource);
            localReport.Refresh();
            byte[] pdf = localReport.Render("PDF");
            return File(pdf, "application/pdf");
        }
    }
}
