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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AnnualLeaveAllucations : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;
        SqlConnection con = new SqlConnection("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");

        public AnnualLeaveAllucations(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/AnnualLeaveAllucations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgAnnualLeaveAllucation>>> GetDgAnnualLeaveAllucations()
        {
            return await _context.DgAnnualLeaveAllucations.ToListAsync();
        }

        // GET: api/AnnualLeaveAllucations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgAnnualLeaveAllucation>> GetDgAnnualLeaveAllucation(int id)
        {
            var dgAnnualLeaveAllucation = await _context.DgAnnualLeaveAllucations.FindAsync(id);

            if (dgAnnualLeaveAllucation == null)
            {
                return NotFound();
            }

            return dgAnnualLeaveAllucation;
        }

        // PUT: api/AnnualLeaveAllucations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgAnnualLeaveAllucation(int id, DgAnnualLeaveAllucation dgAnnualLeaveAllucation)
        {
            //if (id != dgAnnualLeaveAllucation.Serial)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgAnnualLeaveAllucation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgAnnualLeaveAllucationExists(id))
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

        // POST: api/AnnualLeaveAllucations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgAnnualLeaveAllucation>> PostDgAnnualLeaveAllucation(DgAnnualLeaveAllucation dgAnnualLeaveAllucation)
        {
            _context.DgAnnualLeaveAllucations.Add(dgAnnualLeaveAllucation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgAnnualLeaveAllucation", new { id = dgAnnualLeaveAllucation.Serial }, dgAnnualLeaveAllucation);
        }

        [HttpGet("get-AnnualLeave_process")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgAnnualLeaveAllucation>>> GetAnnualLeave_process(int year, int casual, int medical, int annul, int comID)
        {
            SqlCommand com = new SqlCommand("Dg_Pay_Annual_Leave_generate", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@year", year);
            com.Parameters.AddWithValue("@casual", casual);
            com.Parameters.AddWithValue("@medical", medical);
            com.Parameters.AddWithValue("@annul", annul);
            com.Parameters.AddWithValue("@comID", comID);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        // DELETE: api/AnnualLeaveAllucations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgAnnualLeaveAllucation(int id)
        {
            var dgAnnualLeaveAllucation = await _context.DgAnnualLeaveAllucations.FindAsync(id);
            if (dgAnnualLeaveAllucation == null)
            {
                return NotFound();
            }

            _context.DgAnnualLeaveAllucations.Remove(dgAnnualLeaveAllucation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgAnnualLeaveAllucationExists(int id)
        {
            return _context.DgAnnualLeaveAllucations.Any(e => e.Serial == id);
        }
    }
}
