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

namespace Dg_payroll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DgPayDeducationsController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;
        SqlConnection con = new SqlConnection("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");

        public DgPayDeducationsController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        [HttpGet("get-DeductionType")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayDeducation>>> GetDeductionType(string DeductionType)
        {
            SqlCommand com = new SqlCommand("D_Deduction", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@DeductionType", DeductionType);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
        }
        [HttpGet("get-EmpwiseDeduction")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayDeducation>>> GetEmpwiseDeduction(string al_emp_serial)
        {
            SqlCommand com = new SqlCommand("D_Deduction_empwise", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@al_emp_serial", al_emp_serial);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
        }
        [HttpGet("get-DeductionDatewise")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayDeducation>>> GetDeductionDatewise(int CompID, string DeductionType, DateTime StartDate, DateTime EndDate)
        {
            SqlCommand com = new SqlCommand("D_Deduction_Search", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CompID", CompID);
            com.Parameters.AddWithValue("@DeductionType", DeductionType);
            com.Parameters.AddWithValue("@StartDate", StartDate);
            com.Parameters.AddWithValue("@EndDate", EndDate);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
        }
        // GET: api/DgPayDeducations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayDeducation>>> GetDgPayDeducations()
        {
            return await _context.DgPayDeducations.ToListAsync();
        }

        // GET: api/DgPayDeducations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayDeducation>> GetDgPayDeducation(int id)
        {
            var dgPayDeducation = await _context.DgPayDeducations.FindAsync(id);

            if (dgPayDeducation == null)
            {
                return NotFound();
            }

            return dgPayDeducation;
        }

        // PUT: api/DgPayDeducations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayDeducation(int id, DgPayDeducation dgPayDeducation)
        {
            if (id != dgPayDeducation.DSerial)
            {
                return BadRequest();
            }

            _context.Entry(dgPayDeducation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayDeducationExists(id))
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

        // POST: api/DgPayDeducations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayDeducation>> PostDgPayDeducation(DgPayDeducation dgPayDeducation)
        {
            _context.DgPayDeducations.Add(dgPayDeducation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayDeducation", new { id = dgPayDeducation.DSerial }, dgPayDeducation);
        }

        // DELETE: api/DgPayDeducations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayDeducation(int id)
        {
            var dgPayDeducation = await _context.DgPayDeducations.FindAsync(id);
            if (dgPayDeducation == null)
            {
                return NotFound();
            }

            _context.DgPayDeducations.Remove(dgPayDeducation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayDeducationExists(int id)
        {
            return _context.DgPayDeducations.Any(e => e.DSerial == id);
        }
    }
}
