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
    public class AttbonusController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public AttbonusController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/Attbonus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayAttbonu>>> GetDgPayAttbonus()
        {
            return await _context.DgPayAttbonus.ToListAsync();
        }

        // GET: api/Attbonus/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayAttbonu>> GetDgPayAttbonu(int id)
        {
            var dgPayAttbonu = await _context.DgPayAttbonus.FindAsync(id);

            if (dgPayAttbonu == null)
            {
                return NotFound();
            }

            return dgPayAttbonu;
        }

        // PUT: api/Attbonus/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayAttbonu(int id, DgPayAttbonu dgPayAttbonu)
        {
            //if (id != dgPayAttbonu.AttbSerial)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayAttbonu).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayAttbonuExists(id))
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

        // POST: api/Attbonus
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayAttbonu>> PostDgPayAttbonu(DgPayAttbonu dgPayAttbonu)
        {
            _context.DgPayAttbonus.Add(dgPayAttbonu);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayAttbonu", new { id = dgPayAttbonu.AttbSerial }, dgPayAttbonu);
        }

        // DELETE: api/Attbonus/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayAttbonu(int id)
        {
            var dgPayAttbonu = await _context.DgPayAttbonus.FindAsync(id);
            if (dgPayAttbonu == null)
            {
                return NotFound();
            }

            _context.DgPayAttbonus.Remove(dgPayAttbonu);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayAttbonuExists(int id)
        {
            return _context.DgPayAttbonus.Any(e => e.AttbSerial == id);
        }
    }
}
