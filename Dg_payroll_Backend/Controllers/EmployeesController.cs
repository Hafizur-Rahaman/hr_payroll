using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dg_payroll.Data;
using Dg_payroll.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Reporting.NETCore;

namespace Dg_payroll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;
        SqlConnection con = new SqlConnection("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");
        private readonly IWebHostEnvironment _environment;
        public EmployeesController(dg_hrpayrollContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }

        [HttpPost("Employee_active_status")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> Employee_active_status(int Emp_serial,int Active_status, DateTime Inactive_Date, string in_active_Resion)
        {
            SqlCommand com = new SqlCommand("Active_status", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Emp_serial", Emp_serial);
            com.Parameters.AddWithValue("@Active_status", Active_status);
            com.Parameters.AddWithValue("@Inactive_Date", Inactive_Date);
            com.Parameters.AddWithValue("@in_active_Resion", in_active_Resion);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);

        }
        [HttpGet("textfile")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> textfile(int nempSerial, int Emp_ID, int ngroupid, int ncompid, DateTime nDate, string ntime)
        {
            SqlCommand com = new SqlCommand("dg_pay_Att_Insert_Textfile", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@at_emp_serial", nempSerial);
            com.Parameters.AddWithValue("@at_proxid", Emp_ID);
            com.Parameters.AddWithValue("@at_groupid", ngroupid);
            com.Parameters.AddWithValue("@at_compid", ncompid);
            com.Parameters.AddWithValue("@at_date", nDate);
            com.Parameters.AddWithValue("@at_intime", ntime);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        //  Employee Fulter

        [HttpGet("get-FilterBase_employee")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> employee_Info(int? Compid = null, int? Department = null, int? section = null, int? Building = null, int? Floor = null, int? Line = null, int? Shift = null, int? Grade = null, int? salcat = null,DateTime? Start_date=null, DateTime? End_date = null)
        {
            SqlCommand com = new SqlCommand("Emp_filtering", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Compid", Compid);
            com.Parameters.AddWithValue("@Department", Department);
            com.Parameters.AddWithValue("@section", section);
            com.Parameters.AddWithValue("@Building", Building);
            com.Parameters.AddWithValue("@Floor", Floor);
            com.Parameters.AddWithValue("@Line", Line);
            com.Parameters.AddWithValue("@Shift", Shift);
            com.Parameters.AddWithValue("@Grade", Grade);
            com.Parameters.AddWithValue("@salcat", salcat);
            com.Parameters.AddWithValue("@Start_date", Start_date);
            com.Parameters.AddWithValue("@End_date", End_date);
            //com.Parameters.AddWithValue("@Newshift", Newshift);
            //com.Parameters.AddWithValue("@EffectDate", EffectDate);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
            //const.Database.ExecuteSqlCommand("Insert into Emp_filtering Values({0},{1},{2})", param1, param2, param3)
        }

        // Attendance Fulter
        //DataSet dsGetCompany = _myBll.get_SpecFoDtaset("select cCmpName,cAdd1 from Smt_Company where cCmpName='" + HttpContext.Session.GetString("uCompanyName") + "'");
        //DataTable dt = _myBll.get_GatePassInformationdataTable("Mr_Gate_Pass_Daily_Rpt2 " + para.nCompanyID + "," + HttpContext.Session.GetString("UserName") + ",'" + para.fDate + "'");
        //string ComName = dsGetCompany.Tables[0].Rows[0]["cCmpName"].ToString();
        //string cAdd1 = dsGetCompany.Tables[0].Rows[0]["cAdd1"].ToString();
        //var userName = HttpContext.Session.GetString("UserName");

        //var path = $"{_webHostEnvironment.WebRootPath}\\Reports\\GatePassReport\\Smt_GatePassDaily.rdlc";
        //LocalReport localReport = new LocalReport();
        //ReportDataSource reportDataSource = new ReportDataSource("GpDailyDataSet", dt);
        //ReportParameterCollection reportParameterCollection = new ReportParameterCollection()
        //        {
        //            new ReportParameter("Company", ComName),
        //            new ReportParameter("Add1", cAdd1),
        //            new ReportParameter("PrintUser", userName),
        //            new ReportParameter("Title","Daily Gate Pass : " + Convert.ToDateTime(para.fDate).ToString("dd-MMM-yyyy"))
        //        };

        //localReport.ReportPath = path;
        //        localReport.DataSources.Clear();
        //        localReport.SetParameters(reportParameterCollection);
        //        localReport.DataSources.Add(reportDataSource);
        //        localReport.Refresh();
        //        byte[] pdf = localReport.Render("PDF");
        //        return File(pdf, "application/pdf");


        [HttpGet("get-FilterBase_Attendance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> employee_Attendance(int? Compid = null, int? Department = null, int? section = null, int? Building = null, int? Floor = null, int? Line = null, int? Shift = null, int? Grade = null, int? salcat = null, DateTime? Start_date = null, DateTime? End_date = null)
        {
            SqlCommand com = new SqlCommand("Emp_filtering_Attendance", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Compid", Compid);
            com.Parameters.AddWithValue("@Department", Department);
            com.Parameters.AddWithValue("@section", section);
            com.Parameters.AddWithValue("@Building", Building);
            com.Parameters.AddWithValue("@Floor", Floor);
            com.Parameters.AddWithValue("@Line", Line);
            com.Parameters.AddWithValue("@Shift", Shift);
            com.Parameters.AddWithValue("@Grade", Grade);
            com.Parameters.AddWithValue("@salcat", salcat);
            com.Parameters.AddWithValue("@Start_date", Start_date);
            com.Parameters.AddWithValue("@End_date", End_date);
            //com.Parameters.AddWithValue("@Newshift", Newshift);
            //com.Parameters.AddWithValue("@EffectDate", EffectDate);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
            //const.Database.ExecuteSqlCommand("Insert into Emp_filtering Values({0},{1},{2})", param1, param2, param3)
        }

        [HttpGet("get-FilterBase_ShiftChange")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> employee_ShiftChange(int? Compid = null, int? Department = null, int? section = null, int? Building = null, int? Floor = null, int? Line = null, int? Shift = null, int? Grade = null, int? salcat = null, int? Newshift = null, DateTime? EffectDate = null,string? user = null)
        {
            SqlCommand com = new SqlCommand("Emp_filtering_shiftchange", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Compid", Compid);
            com.Parameters.AddWithValue("@Department", Department);
            com.Parameters.AddWithValue("@section", section);
            com.Parameters.AddWithValue("@Building", Building);
            com.Parameters.AddWithValue("@Floor", Floor);
            com.Parameters.AddWithValue("@Line", Line);
            com.Parameters.AddWithValue("@Shift", Shift);
            com.Parameters.AddWithValue("@Grade", Grade);
            com.Parameters.AddWithValue("@salcat", salcat);
            com.Parameters.AddWithValue("@Newshift", Newshift);
            com.Parameters.AddWithValue("@EffectDate", EffectDate);
            com.Parameters.AddWithValue("@user", user);
            //com.Parameters.AddWithValue("@Newshift", Newshift);
            //com.Parameters.AddWithValue("@EffectDate", EffectDate);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
            //const.Database.ExecuteSqlCommand("Insert into Emp_filtering Values({0},{1},{2})", param1, param2, param3)
        }
        //Leave
        [HttpGet("get-FilterBase_Leave")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> employee_Leave(int? Compid = null, int? Department = null, int? section = null, int? Building = null, int? Floor = null, int? Line = null, int? Shift = null, int? Grade = null, int? salcat = null, DateTime? Start_date = null, DateTime? End_date = null)
        {
            SqlCommand com = new SqlCommand("Emp_filtering_Leave", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Compid", Compid);
            com.Parameters.AddWithValue("@Department", Department);
            com.Parameters.AddWithValue("@section", section);
            com.Parameters.AddWithValue("@Building", Building);
            com.Parameters.AddWithValue("@Floor", Floor);
            com.Parameters.AddWithValue("@Line", Line);
            com.Parameters.AddWithValue("@Shift", Shift);
            com.Parameters.AddWithValue("@Grade", Grade);
            com.Parameters.AddWithValue("@salcat", salcat);
            com.Parameters.AddWithValue("@Start_date", Start_date);
            com.Parameters.AddWithValue("@End_date", End_date);
            //com.Parameters.AddWithValue("@Newshift", Newshift);
            //com.Parameters.AddWithValue("@EffectDate", EffectDate);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
            //const.Database.ExecuteSqlCommand("Insert into Emp_filtering Values({0},{1},{2})", param1, param2, param3)
        }

        ////Salary
        [HttpGet("get-FilterBase_Salary")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> employee_Salary(int? Compid = null, int? Department = null, int? section = null, int? Building = null, int? Floor = null, int? Line = null, int? Shift = null, int? Grade = null, int? salcat = null, DateTime? Start_date = null, DateTime? End_date = null)
        {
            SqlCommand com = new SqlCommand("Emp_filtering_salary", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Compid", Compid);
            com.Parameters.AddWithValue("@Department", Department);
            com.Parameters.AddWithValue("@section", section);
            com.Parameters.AddWithValue("@Building", Building);
            com.Parameters.AddWithValue("@Floor", Floor);
            com.Parameters.AddWithValue("@Line", Line);
            com.Parameters.AddWithValue("@Shift", Shift);
            com.Parameters.AddWithValue("@Grade", Grade);
            com.Parameters.AddWithValue("@salcat", salcat);
            com.Parameters.AddWithValue("@Start_date", Start_date);
            com.Parameters.AddWithValue("@End_date", End_date);
            //com.Parameters.AddWithValue("@Newshift", Newshift);
            //com.Parameters.AddWithValue("@EffectDate", EffectDate);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
            //const.Database.ExecuteSqlCommand("Insert into Emp_filtering Values({0},{1},{2})", param1, param2, param3)
        }

        [HttpGet("get")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<UploadAttendance>>> get()
        {
            SqlCommand com = new SqlCommand("textfile_datetime_position", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);

        }

        [HttpGet("get-FilterBase_individual")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> employee_Info(int emp_serial)
        {
            SqlCommand com = new SqlCommand("Emp_filtering_individual", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@emp_serial", emp_serial);
            //com.Parameters.AddWithValue("@Newshift", Newshift);
            //com.Parameters.AddWithValue("@EffectDate", EffectDate);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
            //const.Database.ExecuteSqlCommand("Insert into Emp_filtering Values({0},{1},{2})", param1, param2, param3)
        }

        [HttpGet("get-idcard-bangla")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> employee_Info()
        {
            SqlCommand com = new SqlCommand("Id_card_bangla", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
            //const.Database.ExecuteSqlCommand("Insert into Emp_filtering Values({0},{1},{2})", param1, param2, param3)
        }
        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> GetDgPayEmployees()
        {
            return await _context.DgPayEmployees.ToListAsync();
        }
        [HttpGet("get-CompanyName-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> GetCompanyName()
        {
            SqlCommand com = new SqlCommand("D_company", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        //Divission
        [HttpGet("get-divisionName-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> GetdivisionName()
        {
            SqlCommand com = new SqlCommand("D_Division", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        [HttpGet("get-Distict-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> GetDistict(int di_id)
        {
            SqlCommand com = new SqlCommand("D_district", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@DivId", di_id);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        [HttpGet("get-Thana-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> GetThana(int th_id)
        {
            SqlCommand com = new SqlCommand("D_Thana", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Disticid", th_id);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        [HttpGet("get-Companywiseemployee-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> Companywiseemployee(int compid)
        {
            SqlCommand com = new SqlCommand("D_employee_companywise", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@comId", compid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }
        [HttpGet("get-Employee_ID-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> Employee_ID(int compid)
        {
            SqlCommand com = new SqlCommand("D_employee_id_companywise", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@comId", compid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        [HttpGet("get-singleEmployee")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> singleEmployee(int comId, int EmpId)
        {
            SqlCommand com = new SqlCommand("D_employee_companywise_and_Idwise", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@comId", comId);
            com.Parameters.AddWithValue("@EmpId", EmpId);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }


        [HttpGet("get-Proxmity_ID-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> Proxmity_ID(int compid)
        {
            SqlCommand com = new SqlCommand("D_employee_proxid_companywise", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@comId", compid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        //Designation
        [HttpGet("get-Designation-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> GetDesignation()
        {
            SqlCommand com = new SqlCommand("D_Designation", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }
        //Department
        [HttpGet("get-Department-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> Department(int compid)
        {
            SqlCommand com = new SqlCommand("D_Departmennt", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CompId", compid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        //Section
        [HttpGet("get-Section-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> GetSection(int Department)
        {
            SqlCommand com = new SqlCommand("D_Section", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Department", Department);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        //Building
        [HttpGet("get-Building-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> Getbuilding(int compid)
        {
            SqlCommand com = new SqlCommand("D_Building", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CompID", compid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////
        // Floor
        [HttpGet("get-Floor-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> GetFloor(int compid, int Building)
        {
            SqlCommand com = new SqlCommand("D_Floor", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CompID", compid);
            com.Parameters.AddWithValue("@Building", Building);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }
        // Line

        [HttpGet("get-Line-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> GetLine(int compid, int Building, int Floor)
        {
            SqlCommand com = new SqlCommand("D_Line", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CompID", compid);
            com.Parameters.AddWithValue("@Building", Building);
            com.Parameters.AddWithValue("@Floor", Floor);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        // Shift
        [HttpGet("get-Shift-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> GetShift(int compid)
        {
            SqlCommand com = new SqlCommand("D_Shift", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CompID", compid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }
        // Grade
        [HttpGet("get-Grade-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> GetGrade()
        {
            SqlCommand com = new SqlCommand("D_Grade", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }
        // Grade
        [HttpGet("get-Bank-list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> GetBank()
        {
            SqlCommand com = new SqlCommand("D_Bank", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
        }
        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayEmployee>> GetDgPayEmployee(int id)
        {
            var dgPayEmployee = await _context.DgPayEmployees.FindAsync(id);

            if (dgPayEmployee == null)
            {
                return NotFound();
            }

            return dgPayEmployee;
        }

        // PUT: api/Employees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayEmployee(int id, DgPayEmployee dgPayEmployee)
        {
            //if (id != dgPayEmployee.EmpSerial)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayEmployee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayEmployeeExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Employees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayEmployee>> PostDgPayEmployee(DgPayEmployee dgPayEmployee)
        {
            _context.DgPayEmployees.Add(dgPayEmployee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayEmployee", new { id = dgPayEmployee.EmpSerial }, dgPayEmployee);
        }

        // DELETE: api/Employees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayEmployee(int id)
        {
            var dgPayEmployee = await _context.DgPayEmployees.FindAsync(id);
            if (dgPayEmployee == null)
            {
                return NotFound();
            }

            _context.DgPayEmployees.Remove(dgPayEmployee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayEmployeeExists(int id)
        {
            return _context.DgPayEmployees.Any(e => e.EmpSerial == id);
        }
        ///////////////////////////////////////////////////////////////////////////////////////////////
        [HttpPost("UploadImage")]

        public async Task<ActionResult> UploadImage(string compid, int empid)
        {
            bool Results = false;
            try
            {
                var _uploadedfiles = Request.Form.Files;
                foreach (IFormFile source in _uploadedfiles)
                {
                    //var dgPayEmployee = await _context.DgPayEmployees.FindAsync("empno");
                    string Filename = source.FileName;
                    Filename = empid + ".jpg";
                    string Filepath = GetFilePath("");

                    if (!System.IO.Directory.Exists(Filepath))
                    {
                        System.IO.Directory.CreateDirectory(Filepath);
                    }

                    string imagepath = Filepath + Filename;

                    if (System.IO.File.Exists(imagepath))
                    {
                        System.IO.File.Delete(imagepath);
                    }
                    //string query = "SELECT adi_stposition,adi_noofposition FROM dg_pay_attdataImportsetup WHERE adi_code ='CLOCK     '";


                    using (FileStream stream = System.IO.File.Create(imagepath))
                    {
                        await source.CopyToAsync(stream);
                        Results = true;
                    }


                }
            }
            catch (Exception ex)
            {

            }
            return Ok(Results);
        }

        [HttpGet("RemoveImage/{code}")]

        public ResponseType RemoveImage(string code)
        {
            string Filepath = GetFilePath(code);
            string Imagepath = Filepath + "\\image.png";
            try
            {
                if (System.IO.File.Exists(Imagepath))
                {
                    System.IO.File.Delete(Imagepath);
                }
                return new ResponseType { Result = "pass", KyValue = code };
            }
            catch (Exception ext)
            {
                throw ext;
            }
        }
        private string GetFilePath(string ProductCode)
        {
            return this._environment.WebRootPath + "\\Uploads\\Product\\" + ProductCode;
        }
        //[NonAction]
        [HttpGet("GetImagebyProduct")]
        public string GetImagebyProduct(string productcode, int empid)
        {
            string ImageUrl = string.Empty;
            string HostUrl = "https://localhost:7211/";
            string Filepath = GetFilePath(productcode);
            string Imagepath = Filepath + "\\image.png";
            if (!System.IO.File.Exists(Imagepath))
            {
                //ImageUrl = HostUrl + "/uploads/common/noimage.png";
                ImageUrl = HostUrl + "uploads/Product/" + empid + ".jpg";
            }
            else
            {
                //ImageUrl = HostUrl + "/uploads/Product/" + productcode + "/image.png";
                ImageUrl = HostUrl + "uploads/Product/" + empid;
            }
            return ImageUrl;
        }
    }
}
