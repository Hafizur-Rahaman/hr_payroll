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
    public class SpecialholidaysController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public SpecialholidaysController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/Specialholidays
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPaySpecialholiday>>> GetDgPaySpecialholidays()
        {
            return await _context.DgPaySpecialholidays.ToListAsync();
        }

        // GET: api/Specialholidays/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPaySpecialholiday>> GetDgPaySpecialholiday(int id)
        {
            var dgPaySpecialholiday = await _context.DgPaySpecialholidays.FindAsync(id);

            if (dgPaySpecialholiday == null)
            {
                return NotFound();
            }

            return dgPaySpecialholiday;
        }

        // PUT: api/Specialholidays/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPaySpecialholiday(int id, DgPaySpecialholiday dgPaySpecialholiday)
        {
            //if (id != dgPaySpecialholiday.Serial)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPaySpecialholiday).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPaySpecialholidayExists(id))
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

        // POST: api/Specialholidays
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPaySpecialholiday>> PostDgPaySpecialholiday(DgPaySpecialholiday dgPaySpecialholiday)
        {
            _context.DgPaySpecialholidays.Add(dgPaySpecialholiday);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPaySpecialholiday", new { id = dgPaySpecialholiday.Serial }, dgPaySpecialholiday);
        }

        // DELETE: api/Specialholidays/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPaySpecialholiday(int id)
        {
            var dgPaySpecialholiday = await _context.DgPaySpecialholidays.FindAsync(id);
            if (dgPaySpecialholiday == null)
            {
                return NotFound();
            }

            _context.DgPaySpecialholidays.Remove(dgPaySpecialholiday);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPaySpecialholidayExists(int id)
        {
            return _context.DgPaySpecialholidays.Any(e => e.Serial == id);
        }
    }
}

