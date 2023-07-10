using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dg_payroll.Data;
using Dg_payroll.Models;

namespace Dg_payroll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public CompaniesController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/Companies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayCompany>>> GetDgPayCompanies()
        {
            return await _context.DgPayCompanies.ToListAsync();
        }

        // GET: api/Companies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayCompany>> GetDgPayCompany(int id)
        {
            var dgPayCompany = await _context.DgPayCompanies.FindAsync(id);

            if (dgPayCompany == null)
            {
                return NotFound();
            }

            return dgPayCompany;
        }

        // PUT: api/Companies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayCompany(int id, DgPayCompany dgPayCompany)
        {
            if (id != dgPayCompany.ComId)
            {
                return BadRequest();
            }

            _context.Entry(dgPayCompany).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayCompanyExists(id))
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

        // POST: api/Companies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayCompany>> PostDgPayCompany(DgPayCompany dgPayCompany)
        {
            _context.DgPayCompanies.Add(dgPayCompany);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayCompany", new { id = dgPayCompany.ComId }, dgPayCompany);
        }

        // DELETE: api/Companies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayCompany(int id)
        {
            var dgPayCompany = await _context.DgPayCompanies.FindAsync(id);
            if (dgPayCompany == null)
            {
                return NotFound();
            }

            _context.DgPayCompanies.Remove(dgPayCompany);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayCompanyExists(int id)
        {
            return _context.DgPayCompanies.Any(e => e.ComId == id);
        }
    }
}
