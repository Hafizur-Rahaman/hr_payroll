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
    public class ThanasController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public ThanasController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/Thanas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayThana>>> GetDgPayThanas()
        {
            return await _context.DgPayThanas.ToListAsync();
        }

        // GET: api/Thanas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayThana>> GetDgPayThana(int id)
        {
            var dgPayThana = await _context.DgPayThanas.FindAsync(id);

            if (dgPayThana == null)
            {
                return NotFound();
            }

            return dgPayThana;
        }

        // PUT: api/Thanas/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayThana(int id, DgPayThana dgPayThana)
        {
            //if (id != dgPayThana.ThId)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayThana).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayThanaExists(id))
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

        // POST: api/Thanas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayThana>> PostDgPayThana(DgPayThana dgPayThana)
        {
            _context.DgPayThanas.Add(dgPayThana);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayThana", new { id = dgPayThana.ThId }, dgPayThana);
        }

        // DELETE: api/Thanas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayThana(int id)
        {
            var dgPayThana = await _context.DgPayThanas.FindAsync(id);
            if (dgPayThana == null)
            {
                return NotFound();
            }

            _context.DgPayThanas.Remove(dgPayThana);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayThanaExists(int id)
        {
            return _context.DgPayThanas.Any(e => e.ThId == id);
        }
    }
}
