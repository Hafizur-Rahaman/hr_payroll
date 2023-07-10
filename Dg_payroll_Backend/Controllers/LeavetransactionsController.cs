using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dg_payroll.Data;
using Dg_payroll.Models;
using System.Data.SqlClient;
using System.Data;

namespace Dg_payroll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeavetransactionsController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;
        SqlConnection con = new SqlConnection("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");
        public LeavetransactionsController(dg_hrpayrollContext context)
        {
            _context = context;
        }
        [HttpGet("get_leave_info_comdatewise")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayLeavetransaction>>> Getleave_info_comdatewise(int CompID, DateTime Sdate,DateTime Edate)
        {
            SqlCommand com = new SqlCommand("D_leave_info_comdatewise", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CompID", CompID);
            com.Parameters.AddWithValue("@Sdate", Sdate);
            com.Parameters.AddWithValue("@Edate", Edate);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        // GET: api/Leavetransactions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayLeavetransaction>>> GetDgPayLeavetransactions()
        {
          if (_context.DgPayLeavetransactions == null)
          {
              return NotFound();
          }
            return await _context.DgPayLeavetransactions.ToListAsync();
        }

        // GET: api/Leavetransactions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayLeavetransaction>> GetDgPayLeavetransaction(DateTime id)
        {
          if (_context.DgPayLeavetransactions == null)
          {
              return NotFound();
          }
            var dgPayLeavetransaction = await _context.DgPayLeavetransactions.FindAsync(id);

            if (dgPayLeavetransaction == null)
            {
                return NotFound();
            }

            return dgPayLeavetransaction;
        }

        // PUT: api/Leavetransactions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayLeavetransaction(DateTime id, DgPayLeavetransaction dgPayLeavetransaction)
        {
            if (id != dgPayLeavetransaction.LtrDate)
            {
                return BadRequest();
            }

            _context.Entry(dgPayLeavetransaction).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayLeavetransactionExists(id))
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

        // POST: api/Leavetransactions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayLeavetransaction>> PostDgPayLeavetransaction(DgPayLeavetransaction dgPayLeavetransaction)
        {
          if (_context.DgPayLeavetransactions == null)
          {
              return Problem("Entity set 'dg_hrpayrollContext.DgPayLeavetransactions'  is null.");
          }
            _context.DgPayLeavetransactions.Add(dgPayLeavetransaction);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayLeavetransaction", new { id = dgPayLeavetransaction.LtrDate }, dgPayLeavetransaction);
        }

        // DELETE: api/Leavetransactions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayLeavetransaction(DateTime id)
        {
            if (_context.DgPayLeavetransactions == null)
            {
                return NotFound();
            }
            var dgPayLeavetransaction = await _context.DgPayLeavetransactions.FindAsync(id);
            if (dgPayLeavetransaction == null)
            {
                return NotFound();
            }

            _context.DgPayLeavetransactions.Remove(dgPayLeavetransaction);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayLeavetransactionExists(DateTime id)
        {
            return (_context.DgPayLeavetransactions?.Any(e => e.LtrDate == id)).GetValueOrDefault();
        }
    }
}
