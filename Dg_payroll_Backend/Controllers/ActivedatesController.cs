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
    public class ActivedatesController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public ActivedatesController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/Activedates
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayActivedate>>> GetDgPayActivedates()
        {
          if (_context.DgPayActivedates == null)
          {
              return NotFound();
          }
            return await _context.DgPayActivedates.ToListAsync();
        }

        // GET: api/Activedates/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayActivedate>> GetDgPayActivedate(int id)
        {
          if (_context.DgPayActivedates == null)
          {
              return NotFound();
          }
            var dgPayActivedate = await _context.DgPayActivedates.FindAsync(id);

            if (dgPayActivedate == null)
            {
                return NotFound();
            }

            return dgPayActivedate;
        }

        // PUT: api/Activedates/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayActivedate(int id, DgPayActivedate dgPayActivedate)
        {
            if (id != dgPayActivedate.Sl)
            {
                return BadRequest();
            }

            _context.Entry(dgPayActivedate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayActivedateExists(id))
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

        // POST: api/Activedates
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayActivedate>> PostDgPayActivedate(DgPayActivedate dgPayActivedate)
        {
          if (_context.DgPayActivedates == null)
          {
              return Problem("Entity set 'dg_hrpayrollContext.DgPayActivedates'  is null.");
          }
            _context.DgPayActivedates.Add(dgPayActivedate);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayActivedate", new { id = dgPayActivedate.Sl }, dgPayActivedate);
        }

        // DELETE: api/Activedates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayActivedate(int id)
        {
            if (_context.DgPayActivedates == null)
            {
                return NotFound();
            }
            var dgPayActivedate = await _context.DgPayActivedates.FindAsync(id);
            if (dgPayActivedate == null)
            {
                return NotFound();
            }

            _context.DgPayActivedates.Remove(dgPayActivedate);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayActivedateExists(int id)
        {
            return (_context.DgPayActivedates?.Any(e => e.Sl == id)).GetValueOrDefault();
        }
    }
}
