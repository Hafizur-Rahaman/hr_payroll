using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dg_payroll.Data;
using Dg_payroll.Models;
using Microsoft.AspNetCore.Authorization;

namespace Dg_payroll.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DistrictsController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public DistrictsController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/Districts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayDistrict>>> GetDgPayDistricts()
        {
            return await _context.DgPayDistricts.ToListAsync();
        }

        // GET: api/Districts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayDistrict>> GetDgPayDistrict(int id)
        {
            var dgPayDistrict = await _context.DgPayDistricts.FindAsync(id);

            if (dgPayDistrict == null)
            {
                return NotFound();
            }

            return dgPayDistrict;
        }

        // PUT: api/Districts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayDistrict(int id, DgPayDistrict dgPayDistrict)
        {
            //if (id != dgPayDistrict.DiId)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayDistrict).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayDistrictExists(id))
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

        // POST: api/Districts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayDistrict>> PostDgPayDistrict(DgPayDistrict dgPayDistrict)
        {
            _context.DgPayDistricts.Add(dgPayDistrict);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayDistrict", new { id = dgPayDistrict.DiId }, dgPayDistrict);
        }

        // DELETE: api/Districts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayDistrict(int id)
        {
            var dgPayDistrict = await _context.DgPayDistricts.FindAsync(id);
            if (dgPayDistrict == null)
            {
                return NotFound();
            }

            _context.DgPayDistricts.Remove(dgPayDistrict);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayDistrictExists(int id)
        {
            return _context.DgPayDistricts.Any(e => e.DiId == id);
        }
    }
}
