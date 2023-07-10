using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;
using Dg_payroll.Data;
using Dg_payroll.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace Dg_payroll.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class AllowancesController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;
        SqlConnection con = new SqlConnection("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");


        public AllowancesController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        [HttpGet("get-AllowanceType")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayAllowance>>> GetAllowanceType(string AllowanceType)
        {
            SqlCommand com = new SqlCommand("D_Allowance", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@AllowanceType", AllowanceType);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
        }
        [HttpGet("get-EmpwiseAllowance")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayAllowance>>> GetEmpwiseAllowance(string al_emp_serial)
        {
            SqlCommand com = new SqlCommand("D_Allowance_empwise", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@al_emp_serial", al_emp_serial);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
        }
        [HttpGet("get-AllowanceDatewise")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayAllowance>>> GetAllowanceDatewise(int CompID,string AllowanceType,DateTime StartDate,DateTime EndDate)
        {
            SqlCommand com = new SqlCommand("D_Allowance_Search", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CompID", CompID);
            com.Parameters.AddWithValue("@AllowanceType", AllowanceType);
            com.Parameters.AddWithValue("@StartDate", StartDate);
            com.Parameters.AddWithValue("@EndDate", EndDate);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
        }

        // GET: api/Allowances
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayAllowance>>> GetDgPayAllowances()
        {
            return await _context.DgPayAllowances.ToListAsync();
        }

        // GET: api/Allowances/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayAllowance>> GetDgPayAllowance(int id)
        {
            var dgPayAllowance = await _context.DgPayAllowances.FindAsync(id);

            if (dgPayAllowance == null)
            {
                return NotFound();
            }

            return dgPayAllowance;
        }

        // PUT: api/Allowances/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayAllowance(int id, DgPayAllowance dgPayAllowance)
        {
            //if (id != dgPayAllowance.AlSerial)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayAllowance).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayAllowanceExists(id))
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

        // POST: api/Allowances
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayAllowance>> PostDgPayAllowance(DgPayAllowance dgPayAllowance)
        {
            _context.DgPayAllowances.Add(dgPayAllowance);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayAllowance", new { id = dgPayAllowance.AlSerial }, dgPayAllowance);
        }

        // DELETE: api/Allowances/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayAllowance(int id)
        {
            var dgPayAllowance = await _context.DgPayAllowances.FindAsync(id);
            if (dgPayAllowance == null)
            {
                return NotFound();
            }

            _context.DgPayAllowances.Remove(dgPayAllowance);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayAllowanceExists(int id)
        {
            return _context.DgPayAllowances.Any(e => e.AlSerial == id);
        }
    }
}
