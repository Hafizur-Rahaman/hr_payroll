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
    public class AttcoveringDaysController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public AttcoveringDaysController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/AttcoveringDays
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayAttcoveringDay>>> GetDgPayAttcoveringDays()
        {
            return await _context.DgPayAttcoveringDays.ToListAsync();
        }

        // GET: api/AttcoveringDays/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayAttcoveringDay>> GetDgPayAttcoveringDay(int id)
        {
            var dgPayAttcoveringDay = await _context.DgPayAttcoveringDays.FindAsync(id);

            if (dgPayAttcoveringDay == null)
            {
                return NotFound();
            }

            return dgPayAttcoveringDay;
        }

        // PUT: api/AttcoveringDays/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayAttcoveringDay(int id, DgPayAttcoveringDay dgPayAttcoveringDay)
        {
            //if (id != dgPayAttcoveringDay.CdSerial)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayAttcoveringDay).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayAttcoveringDayExists(id))
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

        // POST: api/AttcoveringDays
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayAttcoveringDay>> PostDgPayAttcoveringDay(DgPayAttcoveringDay dgPayAttcoveringDay)
        {
            _context.DgPayAttcoveringDays.Add(dgPayAttcoveringDay);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayAttcoveringDay", new { id = dgPayAttcoveringDay.CdSerial }, dgPayAttcoveringDay);
        }

        // DELETE: api/AttcoveringDays/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayAttcoveringDay(int id)
        {
            var dgPayAttcoveringDay = await _context.DgPayAttcoveringDays.FindAsync(id);
            if (dgPayAttcoveringDay == null)
            {
                return NotFound();
            }

            _context.DgPayAttcoveringDays.Remove(dgPayAttcoveringDay);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayAttcoveringDayExists(int id)
        {
            return _context.DgPayAttcoveringDays.Any(e => e.CdSerial == id);
        }
    }
}
