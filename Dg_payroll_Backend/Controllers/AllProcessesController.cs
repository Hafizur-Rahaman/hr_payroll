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
using Microsoft.AspNetCore.Authorization;

namespace Dg_payroll.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AllProcessesController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;
        SqlConnection con = new SqlConnection("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");

        public AllProcessesController(dg_hrpayrollContext context)
        {
            _context = context;
        }
        //DESH BORD START
        [HttpGet("Deshboard")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<AllProcess>>> GetDeshboard( int compid)
        {
            SqlCommand com = new SqlCommand("Deshboard_employee", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@compid", compid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        //DESH BORD END

        [HttpGet("Attendance_Process")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<AllProcess>>> GetAttendance_Process(DateTime SDate, int CompID)
        {
            SqlCommand com = new SqlCommand("Attandance_Process", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@SDate", SDate);
            com.Parameters.AddWithValue("@CompID", CompID);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        [HttpGet("Salary_Process")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<AllProcess>>> GetSalary_Process(int groupid, int compid, DateTime pDate)
        {
            SqlCommand com = new SqlCommand("Dg_Pay_Sal_SalaryProcess_Full", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@groupid", groupid);
            com.Parameters.AddWithValue("@compid", compid);
            com.Parameters.AddWithValue("@pDate", pDate);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        [HttpGet("Salary_Confarmations")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<AllProcess>>> GetSalary_Confarmations(int com_id, int month, int year)
        {
            SqlCommand com = new SqlCommand("dg_Pay_Salary_Confirmation_process", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@com_id", com_id);
            com.Parameters.AddWithValue("@month", month);
            com.Parameters.AddWithValue("@year", year);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        [HttpGet("Create_User")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<AllProcess>>> GetCreate_User(string @name, string @EmailId, string @Password, int @Designation,
            DateTime @Getdate,int @CompId ,int Emp_ID ,string Active_status,int @Emp_serial,int @Compliance)
        {
            SqlCommand com = new SqlCommand("D_Create_User", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@name", name);
            com.Parameters.AddWithValue("@EmailId", EmailId);
            com.Parameters.AddWithValue("@Password", Password);
            com.Parameters.AddWithValue("@Designation", Designation);
            com.Parameters.AddWithValue("@Getdate", Getdate);
            com.Parameters.AddWithValue("@CompId", CompId);
            com.Parameters.AddWithValue("@Emp_ID", Emp_ID);
            com.Parameters.AddWithValue("@Active_status", Active_status);
            com.Parameters.AddWithValue("@Emp_serial", Emp_serial);
            com.Parameters.AddWithValue("@Compliance", Compliance);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        [HttpGet("SearchUserlist")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<AllProcess>>> GetSearchUserlist()
        {
            SqlCommand com = new SqlCommand("UserList", con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }
        // GET: api/AllProcesses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AllProcess>>> GetAllProcesses()
        {
            return await _context.AllProcesses.ToListAsync();
        }

        // GET: api/AllProcesses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AllProcess>> GetAllProcess(int id)
        {
            var allProcess = await _context.AllProcesses.FindAsync(id);

            if (allProcess == null)
            {
                return NotFound();
            }

            return allProcess;
        }

        // PUT: api/AllProcesses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAllProcess(int id, AllProcess allProcess)
        {
            if (id != allProcess.Id)
            {
                return BadRequest();
            }

            _context.Entry(allProcess).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AllProcessExists(id))
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

        // POST: api/AllProcesses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<AllProcess>> PostAllProcess(AllProcess allProcess)
        {
            _context.AllProcesses.Add(allProcess);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAllProcess", new { id = allProcess.Id }, allProcess);
        }

        // DELETE: api/AllProcesses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAllProcess(int id)
        {
            var allProcess = await _context.AllProcesses.FindAsync(id);
            if (allProcess == null)
            {
                return NotFound();
            }

            _context.AllProcesses.Remove(allProcess);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AllProcessExists(int id)
        {
            return _context.AllProcesses.Any(e => e.Id == id);
        }
    }
}
