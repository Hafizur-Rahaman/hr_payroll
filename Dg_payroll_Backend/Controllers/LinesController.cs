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
    public class LinesController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public LinesController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/Lines
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayLine>>> GetDgPayLines()
        {
            return await _context.DgPayLines.ToListAsync();
        }

        // GET: api/Lines/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayLine>> GetDgPayLine(int id)
        {
            var dgPayLine = await _context.DgPayLines.FindAsync(id);

            if (dgPayLine == null)
            {
                return NotFound();
            }

            return dgPayLine;
        }

        // PUT: api/Lines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayLine(int id, DgPayLine dgPayLine)
        {
            //if (id != dgPayLine.LineCode)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayLine).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayLineExists(id))
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

        // POST: api/Lines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayLine>> PostDgPayLine(DgPayLine dgPayLine)
        {
            _context.DgPayLines.Add(dgPayLine);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayLine", new { id = dgPayLine.LineCode }, dgPayLine);
        }

        // DELETE: api/Lines/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayLine(int id)
        {
            var dgPayLine = await _context.DgPayLines.FindAsync(id);
            if (dgPayLine == null)
            {
                return NotFound();
            }

            _context.DgPayLines.Remove(dgPayLine);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayLineExists(int id)
        {
            return _context.DgPayLines.Any(e => e.LineCode == id);
        }
    }
}
