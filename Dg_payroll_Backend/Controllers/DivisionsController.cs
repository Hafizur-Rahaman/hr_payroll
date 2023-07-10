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
    public class DivisionsController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public DivisionsController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/Divisions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayDivision>>> GetDgPayDivisions()
        {
            return await _context.DgPayDivisions.ToListAsync();
        }

        // GET: api/Divisions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayDivision>> GetDgPayDivision(int id)
        {
            var dgPayDivision = await _context.DgPayDivisions.FindAsync(id);

            if (dgPayDivision == null)
            {
                return NotFound();
            }

            return dgPayDivision;
        }

        // PUT: api/Divisions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayDivision(int id, DgPayDivision dgPayDivision)
        {
            //if (id != dgPayDivision.DivId)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayDivision).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayDivisionExists(id))
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

        // POST: api/Divisions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayDivision>> PostDgPayDivision(DgPayDivision dgPayDivision)
        {
            _context.DgPayDivisions.Add(dgPayDivision);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayDivision", new { id = dgPayDivision.DivId }, dgPayDivision);
        }

        // DELETE: api/Divisions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayDivision(int id)
        {
            var dgPayDivision = await _context.DgPayDivisions.FindAsync(id);
            if (dgPayDivision == null)
            {
                return NotFound();
            }

            _context.DgPayDivisions.Remove(dgPayDivision);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayDivisionExists(int id)
        {
            return _context.DgPayDivisions.Any(e => e.DivId == id);
        }
    }
}
