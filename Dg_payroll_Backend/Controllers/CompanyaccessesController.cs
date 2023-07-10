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
using Microsoft.Extensions.Hosting;
using System.Data;
using System.Security.Cryptography;

namespace Dg_payroll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyaccessesController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;
        SqlConnection con = new SqlConnection("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");

        public CompanyaccessesController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        [HttpGet("get-Payroll_User_List")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> User_List()
        {
            SqlCommand com = new SqlCommand("User_List", con);
            com.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        [HttpGet("get-Payroll_User_Listfrom_ACCESS")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> User_Listfrom_ACCESS(string @user)
        {
            SqlCommand com = new SqlCommand("User_List_from_access_table", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@user", user);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }
        // GET: api/Companyaccesses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayCompanyaccess>>> GetDgPayCompanyaccesses()
        {
          if (_context.DgPayCompanyaccesses == null)
          {
              return NotFound();
          }
            return await _context.DgPayCompanyaccesses.ToListAsync();
        }

        // GET: api/Companyaccesses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayCompanyaccess>> GetDgPayCompanyaccess(int id)
        {
          if (_context.DgPayCompanyaccesses == null)
          {
              return NotFound();
          }
            var dgPayCompanyaccess = await _context.DgPayCompanyaccesses.FindAsync(id);

            if (dgPayCompanyaccess == null)
            {
                return NotFound();
            }

            return dgPayCompanyaccess;
        }

        // PUT: api/Companyaccesses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayCompanyaccess(int id, DgPayCompanyaccess dgPayCompanyaccess)
        {
            if (id != dgPayCompanyaccess.CaSerial)
            {
                return BadRequest();
            }

            _context.Entry(dgPayCompanyaccess).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayCompanyaccessExists(id))
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

        /// POST: api/Companyaccesses
        /// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754

        [HttpPost]
        public async Task<ActionResult<DgPayCompanyaccess>> PostDgPayCompanyaccess(DgPayCompanyaccess dgPayCompanyaccess)
        {
          if (_context.DgPayCompanyaccesses == null)
          {
              return Problem("Entity set 'dg_hrpayrollContext.DgPayCompanyaccesses'  is null.");
          }
            _context.DgPayCompanyaccesses.Add(dgPayCompanyaccess);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayCompanyaccess", new { id = dgPayCompanyaccess.CaSerial }, dgPayCompanyaccess);
        }

        // DELETE: api/Companyaccesses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayCompanyaccess(int id)
        {
            if (_context.DgPayCompanyaccesses == null)
            {
                return NotFound();
            }
            var dgPayCompanyaccess = await _context.DgPayCompanyaccesses.FindAsync(id);
            if (dgPayCompanyaccess == null)
            {
                return NotFound();
            }

            _context.DgPayCompanyaccesses.Remove(dgPayCompanyaccess);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayCompanyaccessExists(int id)
        {
            return (_context.DgPayCompanyaccesses?.Any(e => e.CaSerial == id)).GetValueOrDefault();
        }
    }
}
