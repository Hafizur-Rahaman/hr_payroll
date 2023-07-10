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
    public class StampchargesController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public StampchargesController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/Stampcharges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgStampcharge>>> GetDgStampcharges()
        {
            return await _context.DgStampcharges.ToListAsync();
        }

        // GET: api/Stampcharges/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgStampcharge>> GetDgStampcharge(int id)
        {
            var dgStampcharge = await _context.DgStampcharges.FindAsync(id);

            if (dgStampcharge == null)
            {
                return NotFound();
            }

            return dgStampcharge;
        }

        // PUT: api/Stampcharges/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgStampcharge(int id, DgStampcharge dgStampcharge)
        {
            //if (id != dgStampcharge.Id)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgStampcharge).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgStampchargeExists(id))
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

        // POST: api/Stampcharges
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgStampcharge>> PostDgStampcharge(DgStampcharge dgStampcharge)
        {
            _context.DgStampcharges.Add(dgStampcharge);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgStampcharge", new { id = dgStampcharge.Id }, dgStampcharge);
        }

        // DELETE: api/Stampcharges/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgStampcharge(int id)
        {
            var dgStampcharge = await _context.DgStampcharges.FindAsync(id);
            if (dgStampcharge == null)
            {
                return NotFound();
            }

            _context.DgStampcharges.Remove(dgStampcharge);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgStampchargeExists(int id)
        {
            return _context.DgStampcharges.Any(e => e.Id == id);
        }
    }
}
