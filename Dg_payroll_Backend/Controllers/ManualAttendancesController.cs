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
using Microsoft.DotNet.Scaffolding.Shared.Messaging;
using System.Security.Cryptography.X509Certificates;
using NuGet.Protocol.Plugins;
using Microsoft.AspNetCore.Authorization;

namespace Dg_payroll.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ManualAttendancesController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;
        SqlConnection con = new SqlConnection("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");
        public ManualAttendancesController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        //[HttpGet("get-ManualAttendance/{Emp_serial}/{date}/{intime}/{outtime}")]
        [HttpGet("get-ManualAttendance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<DgPayAttendance>>> ManualAttendance(int Emp_serial, DateTime date, decimal intime, DateTime outdate, decimal outtime)
        {
                SqlCommand com = new SqlCommand("D_Manual_Attendance", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Emp_serial", Emp_serial);
                com.Parameters.AddWithValue("@date", date);
                com.Parameters.AddWithValue("@intime", intime);
                com.Parameters.AddWithValue("@outdate", outdate);
                com.Parameters.AddWithValue("@outtime", outtime);
                SqlDataAdapter da = new SqlDataAdapter(com);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return Ok(ds);
        }

        //ManualAttendancesController attendance select date wise
        [HttpGet("get-ManualAttendance_select")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<DgPayAttendance>>> ManualAttendance_select(int Emp_serial, DateTime date)
        {
            SqlCommand com = new SqlCommand("Manual_Attendance_select_DATE_AND_IDWISE", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Emp_serial", Emp_serial);
            com.Parameters.AddWithValue("@date", date);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
        }
        //[HttpGet("get-ManualAttendance/{Emp_serial}/{date}/{intime}/{outtime}")]
        [HttpGet("get-ManualAttendance_viw")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status202Accepted)]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<DgPayAttendance>>> ManualAttendance_viw(int comp, DateTime Sdate, DateTime Edate, int IND)
        {
            SqlCommand com = new SqlCommand("D_Manual_Attendance_VIW", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@comp", comp);
            com.Parameters.AddWithValue("@Sdate", Sdate);
            com.Parameters.AddWithValue("@Edate", Edate);
            com.Parameters.AddWithValue("@IND", IND);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
        }
        //return StatusCode(202, "Successfully Updated!");
        // GET: api/ManualAttendances
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayAttendance>>> GetDgPayAttendances()
        {
            return await _context.DgPayAttendances.ToListAsync();
        }

        // GET: api/ManualAttendances/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayAttendance>> GetDgPayAttendance(int id)
        {
            var dgPayAttendance = await _context.DgPayAttendances.FindAsync(id);

            if (dgPayAttendance == null)
            {
                return NotFound();
            }

            return dgPayAttendance;
        }

        // PUT: api/ManualAttendances/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayAttendance(int id, DgPayAttendance dgPayAttendance)
        {
            //if (id != dgPayAttendance.AtEmpSerial)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayAttendance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayAttendanceExists(id))
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

        // POST: api/ManualAttendances
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayAttendance>> PostDgPayAttendance(DgPayAttendance dgPayAttendance)
        {
            _context.DgPayAttendances.Add(dgPayAttendance);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DgPayAttendanceExists(dgPayAttendance.AtEmpSerial))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDgPayAttendance", new { id = dgPayAttendance.AtEmpSerial }, dgPayAttendance);
        }

        // DELETE: api/ManualAttendances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayAttendance(int id)
        {
            var dgPayAttendance = await _context.DgPayAttendances.FindAsync(id);
            if (dgPayAttendance == null)
            {
                return NotFound();
            }

            _context.DgPayAttendances.Remove(dgPayAttendance);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayAttendanceExists(int id)
        {
            return _context.DgPayAttendances.Any(e => e.AtEmpSerial == id);
        }
    }
}
