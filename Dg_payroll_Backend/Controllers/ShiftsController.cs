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
    public class ShiftsController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public ShiftsController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/Shifts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayShift>>> GetDgPayShifts()
        {
            return await _context.DgPayShifts.ToListAsync();
        }

        // GET: api/Shifts/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayShift>> GetDgPayShift(int id)
        {
            var dgPayShift = await _context.DgPayShifts.FindAsync(id);

            if (dgPayShift == null)
            {
                return NotFound();
            }

            return dgPayShift;
        }

        // PUT: api/Shifts/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayShift(int id, DgPayShift dgPayShift)
        {
            //if (id != dgPayShift.ShCode)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayShift).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayShiftExists(id))
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

        // POST: api/Shifts
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayShift>> PostDgPayShift(DgPayShift dgPayShift)
        {
            _context.DgPayShifts.Add(dgPayShift);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayShift", new { id = dgPayShift.ShCode }, dgPayShift);
        }

        // DELETE: api/Shifts/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayShift(int id)
        {
            var dgPayShift = await _context.DgPayShifts.FindAsync(id);
            if (dgPayShift == null)
            {
                return NotFound();
            }

            _context.DgPayShifts.Remove(dgPayShift);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayShiftExists(int id)
        {
            return _context.DgPayShifts.Any(e => e.ShCode == id);
        }
    }
}
