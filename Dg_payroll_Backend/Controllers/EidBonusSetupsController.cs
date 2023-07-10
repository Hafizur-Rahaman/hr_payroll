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
    public class EidBonusSetupsController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public EidBonusSetupsController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/EidBonusSetups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayEidBonusSetup>>> GetDgPayEidBonusSetups()
        {
            return await _context.DgPayEidBonusSetups.ToListAsync();
        }

        // GET: api/EidBonusSetups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayEidBonusSetup>> GetDgPayEidBonusSetup(int id)
        {
            var dgPayEidBonusSetup = await _context.DgPayEidBonusSetups.FindAsync(id);

            if (dgPayEidBonusSetup == null)
            {
                return NotFound();
            }

            return dgPayEidBonusSetup;
        }

        // PUT: api/EidBonusSetups/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayEidBonusSetup(int id, DgPayEidBonusSetup dgPayEidBonusSetup)
        {
            //if (id != dgPayEidBonusSetup.EbSerial)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayEidBonusSetup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayEidBonusSetupExists(id))
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

        // POST: api/EidBonusSetups
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayEidBonusSetup>> PostDgPayEidBonusSetup(DgPayEidBonusSetup dgPayEidBonusSetup)
        {
            _context.DgPayEidBonusSetups.Add(dgPayEidBonusSetup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayEidBonusSetup", new { id = dgPayEidBonusSetup.EbSerial }, dgPayEidBonusSetup);
        }

        // DELETE: api/EidBonusSetups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayEidBonusSetup(int id)
        {
            var dgPayEidBonusSetup = await _context.DgPayEidBonusSetups.FindAsync(id);
            if (dgPayEidBonusSetup == null)
            {
                return NotFound();
            }

            _context.DgPayEidBonusSetups.Remove(dgPayEidBonusSetup);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayEidBonusSetupExists(int id)
        {
            return _context.DgPayEidBonusSetups.Any(e => e.EbSerial == id);
        }
    }
}
