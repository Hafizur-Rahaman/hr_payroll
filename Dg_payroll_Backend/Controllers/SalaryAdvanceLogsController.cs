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

namespace Dg_payroll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SalaryAdvanceLogsController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;
        SqlConnection con = new SqlConnection("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");
        public SalaryAdvanceLogsController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/SalaryAdvanceLogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPaySalaryAdvanceLog>>> GetDgPaySalaryAdvanceLogs()
        {
            return await _context.DgPaySalaryAdvanceLogs.ToListAsync();
        }

        [HttpGet("get-AdvanceProcess")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPaySalaryAdvanceLog>>> AdvanceProcess(int SAMonth, int SAYear, int sp_groupid, int sp_compid, int days)
        {
            SqlCommand com = new SqlCommand("dg_Pay_Sal_ProcessSalaryAdvance", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@SAMonth", SAMonth);
            com.Parameters.AddWithValue("@SAYear", SAYear);
            com.Parameters.AddWithValue("@sp_groupid", sp_groupid);
            com.Parameters.AddWithValue("@sp_compid", sp_compid);
            com.Parameters.AddWithValue("@days", days);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        [HttpGet("get-AdvanceScearch")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPaySalaryAdvanceLog>>> AdvanceProcess(int CompId, int month, int year)
        {
            SqlCommand com = new SqlCommand("dg_SalaryAdvance_Search", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CompId", CompId);
            com.Parameters.AddWithValue("@month", month);
            com.Parameters.AddWithValue("@year", year);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        [HttpGet("get-AdvanceProcessSum")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPaySalaryAdvanceLog>>> AdvanceProcessSum(int CompId, int month, int year)
        {
            SqlCommand com = new SqlCommand("dg_SalaryAdvanceSum_Search", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CompId", CompId);
            com.Parameters.AddWithValue("@month", month);
            com.Parameters.AddWithValue("@year", year);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }
        // GET: api/SalaryAdvanceLogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPaySalaryAdvanceLog>> GetDgPaySalaryAdvanceLog(int id)
        {
            var dgPaySalaryAdvanceLog = await _context.DgPaySalaryAdvanceLogs.FindAsync(id);

            if (dgPaySalaryAdvanceLog == null)
            {
                return NotFound();
            }

            return dgPaySalaryAdvanceLog;
        }

        // PUT: api/SalaryAdvanceLogs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPaySalaryAdvanceLog(int id, DgPaySalaryAdvanceLog dgPaySalaryAdvanceLog)
        {
            if (id != dgPaySalaryAdvanceLog.Serial)
            {
                return BadRequest();
            }

            _context.Entry(dgPaySalaryAdvanceLog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPaySalaryAdvanceLogExists(id))
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

        // POST: api/SalaryAdvanceLogs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPaySalaryAdvanceLog>> PostDgPaySalaryAdvanceLog(DgPaySalaryAdvanceLog dgPaySalaryAdvanceLog)
        {
            _context.DgPaySalaryAdvanceLogs.Add(dgPaySalaryAdvanceLog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPaySalaryAdvanceLog", new { id = dgPaySalaryAdvanceLog.Serial }, dgPaySalaryAdvanceLog);
        }

        // DELETE: api/SalaryAdvanceLogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPaySalaryAdvanceLog(int id)
        {
            var dgPaySalaryAdvanceLog = await _context.DgPaySalaryAdvanceLogs.FindAsync(id);
            if (dgPaySalaryAdvanceLog == null)
            {
                return NotFound();
            }

            _context.DgPaySalaryAdvanceLogs.Remove(dgPaySalaryAdvanceLog);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPaySalaryAdvanceLogExists(int id)
        {
            return _context.DgPaySalaryAdvanceLogs.Any(e => e.Serial == id);
        }
    }
}
