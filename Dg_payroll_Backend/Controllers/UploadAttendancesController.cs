using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dg_payroll.Data;
using Dg_payroll.Models;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Data;
using System.IO;
using System.Xml;
using ReportApi.Utility;
using System.Drawing;
using System.Data.SqlClient;

namespace Dg_payroll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UploadAttendancesController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;
        SqlConnection con = new SqlConnection("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");
        public UploadAttendancesController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("UploadFileNEW")]
        public IActionResult ReadFile()
        {
            BLL _myBll = new BLL();
            var entities = new List<MyEntity>();

            using (var streamReader = new StreamReader("text_mukarom.txt"))
            {
                string line;
                while ((line = streamReader.ReadLine()) != null)
                {
                    // Split the line into segments based on position and length
                    //string segment1 = line.Substring(0, 4);
                    //string segment2 = line.Substring(21, 2);
                    //string segment3 = line.Substring(23, 2);
                    //string segment4 = line.Substring(25, 4);
                    //string segment5 = line.Substring(29, 2);
                    //string segment6 = line.Substring(31, 2);

                    //string Emp_ID = line.Substring(0,2);
                    //string Day = line.Substring(21,2);
                    //string Month = line.Substring(23,2);
                    //string Year = line.Substring(25,4);
                    //string Hour = line.Substring(29,2);
                    //string Minute = line.Substring(31,2);

                    if (line.Length >= 24) // Check if line has at least 35 characters
                    {
                        //string Emp_ID = line.Substring(0, 3);
                        //string Day = line.Substring(23, 2);
                        //string Month = line.Substring(21, 2);
                        //string Year = line.Substring(25, 4);
                        //string Hour = line.Substring(29, 2);
                        //string Minute = line.Substring(31, 2);


                        string Emp_ID = line.Substring(5, 3);
                        string Day = line.Substring(11, 2);
                        string Month = line.Substring(9, 2);
                        string Year = line.Substring(13, 4);
                        string Hour = line.Substring(18, 2);
                        string Minute = line.Substring(20, 2);

                        string nDate;
                        nDate = Convert.ToDateTime(Year + "/" + Month + "/" + Day).ToString("yyyy/MM/dd");

                        string ntime;
                        ntime = (Hour + "." + Minute);

                        string ngroupid;
                        ngroupid = "11";

                        string ncompid;
                        ncompid = "52";

                        string nempSerial;
                        nempSerial = "3";

                        var dbContext = new dg_hrpayrollContext();
                        var employees = dbContext.DgPayEmployees
                        .Where(u => u.EmpNo.ToString() == Emp_ID.ToString())
                        .Select(u => u.EmpSerial.ToString())
                        .SingleOrDefault();
                        //using (var context = new dg_hrpayrollContext())
                        //{
                        //    var proxId = Emp_ID;
                        //    var compId = 52;
                        //    var empSerial = context.DgPayEmployees
                        //        .FromSqlInterpolated($"SELECT emp_serial FROM DgPayEmployees WHERE emp_proxid = {proxId} AND oi_active = 1 AND compid = {compId}");
                        //}

                        var entity = new MyEntity
                        {
                            Emp_proxid = Emp_ID,
                            Day = Day,
                            Month = Month,
                            Year = Year,
                            Hour = Hour,
                            Minute = Minute,
                            tdate = nDate,
                            ttime = ntime,
                            tgroupid= ngroupid,
                            tcompid= ncompid,
                            tempSerial= employees
                        };

                        //private async Task<ActionResult<IEnumerable<DgPayEmployee>>> textfile(int nempSerial, int Emp_ID, int ngroupid, int ncompid, DateTime nDate, string ntime);


                        //List<TEntity> result = dg_hrpayrollContext.DgPayEmployee.FromSqlRaw("EXECUTE dbo.dg_pay_Att_Insert_Textfile @at_emp_serial, @at_proxid, @at_groupid,@at_compid, @at_date, @at_intime", nempSerial, Emp_ID, ngroupid, ncompid, nDate, ntime).ToList();

                        //var result = dbContext.MyEntities.FromSqlRaw("EXECUTE dbo.YourStoredProcedure @param1={0}, @param2={1}", param1Value, param2Value).ToList();
                        //dr.Dispose();
                        //sql.Dispose();
                        //CloseConnection();
                        //return promotion;

                        //SqlDataAdapter da = new SqlDataAdapter(com);
                        //DataSet ds = new DataSet();
                        //da.Fill(ds);
                        //async Task<ActionResult<IEnumerable<DgPayEmployee>>> textfile(int at_emp_serial = @nempSerial, int at_proxid = Emp_ID, int at_groupid = 11, int ncompid = 52, int at_date = nDate, int at_intime = ntime);
                        //con.Open();
                        //SqlCommand com = new SqlCommand("dg_pay_Att_Insert_Textfile", con);
                        //com.CommandType = CommandType.StoredProcedure;
                        //com.Parameters.AddWithValue("@at_emp_serial", nempSerial);
                        //com.Parameters.AddWithValue("@at_proxid", Emp_ID);
                        //com.Parameters.AddWithValue("@at_groupid", ngroupid);
                        //com.Parameters.AddWithValue("@at_compid", ncompid);
                        //com.Parameters.AddWithValue("@at_date", nDate);
                        //com.Parameters.AddWithValue("@at_intime", ntime);
                        //com.CommandType = CommandType.StoredProcedure;
                        //com.CommandTimeout = 9000000;
                        ////SqlDataAdapter da = new SqlDataAdapter();
                        ////da.SelectCommand = com;
                        //com.ExecuteNonQuery();
                        ////com.ExecuteReader();
                        //SqlDataAdapter da = new SqlDataAdapter(com);
                        //DataSet ds = new DataSet();
                        //da.Fill(ds);
                        //con.Close();

                        string connectionString = "Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022";
                        SqlConnection con = new SqlConnection(connectionString);

                        //var dbContext = new dg_hrpayrollContext();
                        var EMPserial = dbContext.DgPayEmployees
                        .Where(u => u.EmpNo.ToString() == Emp_ID.ToString())
                        .Select(u => u.EmpSerial.ToString())
                        .SingleOrDefault();

                        if (EMPserial != null)
                        {
                            using (SqlConnection connection = con)
                            {
                                con.Open();

                                using (SqlCommand command = new SqlCommand("dg_pay_Att_Insert_Textfile", con))
                                {
                                    command.CommandType = CommandType.StoredProcedure;

                                    command.Parameters.AddWithValue("@at_emp_serial", employees);
                                    command.Parameters.AddWithValue("@at_proxid", Emp_ID);
                                    command.Parameters.AddWithValue("@at_groupid", ngroupid);
                                    command.Parameters.AddWithValue("@at_compid", ncompid);
                                    command.Parameters.AddWithValue("@at_date", nDate);
                                    command.Parameters.AddWithValue("@at_intime", ntime);

                                    command.ExecuteNonQuery();

                                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                    {
                                        DataSet dataset = new DataSet();
                                        adapter.Fill(dataset);
                                    }
                                }

                                con.Close();
                            }
                        }
                      

                        entities.Add(entity);
                    }

                    //string nDate;
                    //nDate = Convert.ToDateTime(Month + "/" + Day + "/" + Year).ToString("dd/MM/yyyy");

                    //string ntime;
                    //ntime = (Hour + "." + Minute);


                    //using (var context = new dg_hrpayrollContext())
                    //{
                    //    var proxId = Emp_ID;
                    //    var compId = 52;
                    //    var empSerial = context.DgPayEmployees
                    //        .FromSqlInterpolated($"SELECT emp_serial FROM DgPayEmployee WHERE emp_proxid = {proxId} AND oi_active = 1 AND compid = {compId}");
                    //}

                    //var serial = con.DgPayEmployees.FromSqlRaw("select emp_serial from dg_pay_Employee where emp_no=540");

                    //using (var context = new dg_hrpayrollContext())
                    //{
                    //    var serial = context.DgPayEmployees.FromSqlRaw("select emp_serial from dg_pay_Employee where emp_no=540", "myTag").ToList();
                    //}


                    //DataTable empserial = _myBll.get_AspCoreInformationdataTable("select emp_serial from dg_pay_Employee where emp_proxid="+Emp_ID+"");

                    // Use the segments to create a new entity
                    //var entity = new MyEntity
                    //{
                    //    Property1 = Emp_ID,
                    //    Property2 = Day,
                    //    Property3 = Month,
                    //    Property4 = Year,
                    //    Property5 = Hour,
                    //    Property6 = Minute,
                    //    tdate = nDate,
                    //    ttime = ntime
                    //};

                    //-------------------------------------------------------

                   //async Task<ActionResult<IEnumerable<DgPayEmployee>>> empid()
                   // {
                   //     SqlCommand com = new SqlCommand("select emp_serial from dg_pay_Employee where emp_proxid=" + Emp_ID + "", con);
                   //     com.CommandType = CommandType.StoredProcedure;
                   //     //com.Parameters.AddWithValue("@DivId", di_id);
                   //     SqlDataAdapter da = new SqlDataAdapter(com);
                   //     DataSet ds = new DataSet();
                   //     da.Fill(ds);

                   //     return Ok(ds);
                   // }

                   //-----------------------------------------------

                    //using (var context = new MyDbContext())
                    //{
                    //    var result = context.MyEntities.Where(e => e.SomeProperty == "someValue").ToList();
                    //}


                    //entities.Add(entity);


                }

            }


            return Ok(entities);
        }




        //// GET: api/UploadAttendances
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<UploadAttendance>>> GetUploadAttendances()
        //{
        //    return await _context.UploadAttendances.ToListAsync();
        //}

        //// GET: api/UploadAttendances/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<UploadAttendance>> GetUploadAttendance(int id)
        //{
        //    var uploadAttendance = await _context.UploadAttendances.FindAsync(id);

        //    if (uploadAttendance == null)
        //    {
        //        return NotFound();
        //    }

        //    return uploadAttendance;
        //}

        //// PUT: api/UploadAttendances/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutUploadAttendance(int id, UploadAttendance uploadAttendance)
        //{
        //    if (id != uploadAttendance.Sl)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(uploadAttendance).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!UploadAttendanceExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/UploadAttendances
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<UploadAttendance>> PostUploadAttendance(UploadAttendance uploadAttendance)
        //{
        //    _context.UploadAttendances.Add(uploadAttendance);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetUploadAttendance", new { id = uploadAttendance.Sl }, uploadAttendance);
        //}

        //// DELETE: api/UploadAttendances/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteUploadAttendance(int id)
        //{
        //    var uploadAttendance = await _context.UploadAttendances.FindAsync(id);
        //    if (uploadAttendance == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.UploadAttendances.Remove(uploadAttendance);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool UploadAttendanceExists(int id)
        //{
        //    return _context.UploadAttendances.Any(e => e.Sl == id);
        //}

        /// <summary>
        /// ///////////////////////////////

        [HttpPost]
        [Route("UploadFile")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> UploadFile(IFormFile file, CancellationToken cancellationtoken)
        {
            var result = await WriteFile(file);
            return Ok(result);
        }

        private async Task<string> WriteFile(IFormFile file)
        {

           
           


                    //int Clock_st = 1;
                    //int Clock_po = 1;

                    //int Day_st = 22;
                    //int Day_op = 2;

                    //int Month_st = 24;
                    //int Month_po = 2;

                    //int Year_st = 26;
                    //int Year_po = 4;

                    //int Hrs_st = 30;
                    //int Hrs_po = 2;

                    //int Min_st = 32;
                    //int Min_po = 2;

                    //int Empid_st = 1;
                    //int Empid_po = 8;


                    string filename = "";

            try
            {
                var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
                filename = file.FileName;
                //filename = DateTime.Now.Ticks.ToString() + extension;

                var filepath = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\Files");

                if (!Directory.Exists(filepath))
                {
                    Directory.CreateDirectory(filepath);
                }

                //////string nDate = ( Month_st, Month_po) + "/" + ( Day_st, Day_op) + "/" + ( Year_st, Year_po);
                //foreach (string line in System.IO.File.ReadLines(@"c:\filename")) ;
                //Reading
                //using (StreamReader sr = new StreamReader(@"\\t.txt"))
                //{
                //    char[] c = new char[4];  // Invoice number string 
                //    sr.BaseStream.Position = 1;
                //    sr.Read(c, 0, c.Length);
                //}
                //Readings

                var exactpath = Path.Combine(Directory.GetCurrentDirectory(), filename);
                //var exactpath = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\Files", filename);
                using (var stream = new FileStream(exactpath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                BLL _myBll = new BLL();
                    var entities = new List<MyEntity>();

                    using (var streamReader = new StreamReader(filename))
                    {
                        string line;
                        while ((line = streamReader.ReadLine()) != null)
                        {
                            // Split the line into segments based on position and length
                            //string segment1 = line.Substring(0, 4);
                            //string segment2 = line.Substring(21, 2);
                            //string segment3 = line.Substring(23, 2);
                            //string segment4 = line.Substring(25, 4);
                            //string segment5 = line.Substring(29, 2);
                            //string segment6 = line.Substring(31, 2);

                            //string Emp_ID = line.Substring(0,2);
                            //string Day = line.Substring(21,2);
                            //string Month = line.Substring(23,2);
                            //string Year = line.Substring(25,4);
                            //string Hour = line.Substring(29,2);
                            //string Minute = line.Substring(31,2);

                            if (line.Length >= 24) // Check if line has at least 35 characters
                            {
                                //string Emp_ID = line.Substring(0, 3);
                                //string Day = line.Substring(23, 2);
                                //string Month = line.Substring(21, 2);
                                //string Year = line.Substring(25, 4);
                                //string Hour = line.Substring(29, 2);
                                //string Minute = line.Substring(31, 2);


                                string Emp_ID = line.Substring(5, 3);
                                string Day = line.Substring(11, 2);
                                string Month = line.Substring(9, 2);
                                string Year = line.Substring(13, 4);
                                string Hour = line.Substring(18, 2);
                                string Minute = line.Substring(20, 2);

                                string nDate;
                                nDate = Convert.ToDateTime(Year + "/" + Month + "/" + Day).ToString("yyyy/MM/dd");

                                string ntime;
                                ntime = (Hour + "." + Minute);

                                string ngroupid;
                                ngroupid = "11";

                                string ncompid;
                                ncompid = "52";

                                string nempSerial;
                                nempSerial = "3";

                                var dbContext = new dg_hrpayrollContext();
                                var employees = dbContext.DgPayEmployees
                                .Where(u => u.EmpNo.ToString() == Emp_ID.ToString())
                                .Select(u => u.EmpSerial.ToString())
                                .SingleOrDefault();
                                //using (var context = new dg_hrpayrollContext())
                                //{
                                //    var proxId = Emp_ID;
                                //    var compId = 52;
                                //    var empSerial = context.DgPayEmployees
                                //        .FromSqlInterpolated($"SELECT emp_serial FROM DgPayEmployees WHERE emp_proxid = {proxId} AND oi_active = 1 AND compid = {compId}");
                                //}

                                var entity = new MyEntity
                                {
                                    Emp_proxid = Emp_ID,
                                    Day = Day,
                                    Month = Month,
                                    Year = Year,
                                    Hour = Hour,
                                    Minute = Minute,
                                    tdate = nDate,
                                    ttime = ntime,
                                    tgroupid = ngroupid,
                                    tcompid = ncompid,
                                    tempSerial = employees
                                };

                                //private async Task<ActionResult<IEnumerable<DgPayEmployee>>> textfile(int nempSerial, int Emp_ID, int ngroupid, int ncompid, DateTime nDate, string ntime);


                                //List<TEntity> result = dg_hrpayrollContext.DgPayEmployee.FromSqlRaw("EXECUTE dbo.dg_pay_Att_Insert_Textfile @at_emp_serial, @at_proxid, @at_groupid,@at_compid, @at_date, @at_intime", nempSerial, Emp_ID, ngroupid, ncompid, nDate, ntime).ToList();

                                //var result = dbContext.MyEntities.FromSqlRaw("EXECUTE dbo.YourStoredProcedure @param1={0}, @param2={1}", param1Value, param2Value).ToList();
                                //dr.Dispose();
                                //sql.Dispose();
                                //CloseConnection();
                                //return promotion;

                                //SqlDataAdapter da = new SqlDataAdapter(com);
                                //DataSet ds = new DataSet();
                                //da.Fill(ds);
                                //async Task<ActionResult<IEnumerable<DgPayEmployee>>> textfile(int at_emp_serial = @nempSerial, int at_proxid = Emp_ID, int at_groupid = 11, int ncompid = 52, int at_date = nDate, int at_intime = ntime);
                                //con.Open();
                                //SqlCommand com = new SqlCommand("dg_pay_Att_Insert_Textfile", con);
                                //com.CommandType = CommandType.StoredProcedure;
                                //com.Parameters.AddWithValue("@at_emp_serial", nempSerial);
                                //com.Parameters.AddWithValue("@at_proxid", Emp_ID);
                                //com.Parameters.AddWithValue("@at_groupid", ngroupid);
                                //com.Parameters.AddWithValue("@at_compid", ncompid);
                                //com.Parameters.AddWithValue("@at_date", nDate);
                                //com.Parameters.AddWithValue("@at_intime", ntime);
                                //com.CommandType = CommandType.StoredProcedure;
                                //com.CommandTimeout = 9000000;
                                ////SqlDataAdapter da = new SqlDataAdapter();
                                ////da.SelectCommand = com;
                                //com.ExecuteNonQuery();
                                ////com.ExecuteReader();
                                //SqlDataAdapter da = new SqlDataAdapter(com);
                                //DataSet ds = new DataSet();
                                //da.Fill(ds);
                                //con.Close();

                                string connectionString = "Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022";
                                SqlConnection con = new SqlConnection(connectionString);

                                //var dbContext = new dg_hrpayrollContext();
                                var EMPserial = dbContext.DgPayEmployees
                                .Where(u => u.EmpNo.ToString() == Emp_ID.ToString())
                                .Select(u => u.EmpSerial.ToString())
                                .SingleOrDefault();

                                if (EMPserial != null)
                                {
                                    using (SqlConnection connection = con)
                                    {
                                        con.Open();

                                        using (SqlCommand command = new SqlCommand("dg_pay_Att_Insert_Textfile", con))
                                        {
                                            command.CommandType = CommandType.StoredProcedure;

                                            command.Parameters.AddWithValue("@at_emp_serial", employees);
                                            command.Parameters.AddWithValue("@at_proxid", Emp_ID);
                                            command.Parameters.AddWithValue("@at_groupid", ngroupid);
                                            command.Parameters.AddWithValue("@at_compid", ncompid);
                                            command.Parameters.AddWithValue("@at_date", nDate);
                                            command.Parameters.AddWithValue("@at_intime", ntime);

                                            command.ExecuteNonQuery();

                                            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                                            {
                                                DataSet dataset = new DataSet();
                                                adapter.Fill(dataset);
                                            }
                                        }

                                        con.Close();
                                    }
                                }




                                entities.Add(entity);
                            }

                            //string nDate;
                            //nDate = Convert.ToDateTime(Month + "/" + Day + "/" + Year).ToString("dd/MM/yyyy");

                            //string ntime;
                            //ntime = (Hour + "." + Minute);


                            //using (var context = new dg_hrpayrollContext())
                            //{
                            //    var proxId = Emp_ID;
                            //    var compId = 52;
                            //    var empSerial = context.DgPayEmployees
                            //        .FromSqlInterpolated($"SELECT emp_serial FROM DgPayEmployee WHERE emp_proxid = {proxId} AND oi_active = 1 AND compid = {compId}");
                            //}

                            //var serial = con.DgPayEmployees.FromSqlRaw("select emp_serial from dg_pay_Employee where emp_no=540");

                            //using (var context = new dg_hrpayrollContext())
                            //{
                            //    var serial = context.DgPayEmployees.FromSqlRaw("select emp_serial from dg_pay_Employee where emp_no=540", "myTag").ToList();
                            //}


                            //DataTable empserial = _myBll.get_AspCoreInformationdataTable("select emp_serial from dg_pay_Employee where emp_proxid="+Emp_ID+"");

                            // Use the segments to create a new entity
                            //var entity = new MyEntity
                            //{
                            //    Property1 = Emp_ID,
                            //    Property2 = Day,
                            //    Property3 = Month,
                            //    Property4 = Year,
                            //    Property5 = Hour,
                            //    Property6 = Minute,
                            //    tdate = nDate,
                            //    ttime = ntime
                            //};

                            //-------------------------------------------------------

                            //async Task<ActionResult<IEnumerable<DgPayEmployee>>> empid()
                            // {
                            //     SqlCommand com = new SqlCommand("select emp_serial from dg_pay_Employee where emp_proxid=" + Emp_ID + "", con);
                            //     com.CommandType = CommandType.StoredProcedure;
                            //     //com.Parameters.AddWithValue("@DivId", di_id);
                            //     SqlDataAdapter da = new SqlDataAdapter(com);
                            //     DataSet ds = new DataSet();
                            //     da.Fill(ds);

                            //     return Ok(ds);
                            // }

                            //-----------------------------------------------

                            //using (var context = new MyDbContext())
                            //{
                            //    var result = context.MyEntities.Where(e => e.SomeProperty == "someValue").ToList();
                            //}


                            //entities.Add(entity);


                        }

                    }


                    //return Ok(entities);
                //}
                //mm
               
            }
            catch (Exception ex)
            {
            }
            return filename;
        }



        //[HttpGet]
        //[Route("DownloadFile")]
        //public async Task<IActionResult> DownloadFile(string filename)
        //{
        //    var filepath = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\Files", filename);

        //    var provider = new FileExtensionContentTypeProvider();
        //    if (!provider.TryGetContentType(filepath, out var contenttype))
        //    {
        //        contenttype = "application/octet-stream";
        //    }

        //    var bytes = await System.IO.File.ReadAllBytesAsync(filepath);
        //    return File(bytes, contenttype, Path.GetFileName(filepath));
        //}
    }
}
