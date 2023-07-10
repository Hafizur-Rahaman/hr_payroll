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
    public class LunchInoutSetupsController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public LunchInoutSetupsController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/LunchInoutSetups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgLunchInoutSetup>>> GetDgLunchInoutSetups()
        {
            return await _context.DgLunchInoutSetups.ToListAsync();
        }

        // GET: api/LunchInoutSetups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgLunchInoutSetup>> GetDgLunchInoutSetup(int id)
        {
            var dgLunchInoutSetup = await _context.DgLunchInoutSetups.FindAsync(id);

            if (dgLunchInoutSetup == null)
            {
                return NotFound();
            }

            return dgLunchInoutSetup;
        }

        // PUT: api/LunchInoutSetups/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgLunchInoutSetup(int id, DgLunchInoutSetup dgLunchInoutSetup)
        {
            //if (id != dgLunchInoutSetup.LSerial)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgLunchInoutSetup).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgLunchInoutSetupExists(id))
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

        // POST: api/LunchInoutSetups
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgLunchInoutSetup>> PostDgLunchInoutSetup(DgLunchInoutSetup dgLunchInoutSetup)
        {
            _context.DgLunchInoutSetups.Add(dgLunchInoutSetup);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgLunchInoutSetup", new { id = dgLunchInoutSetup.LSerial }, dgLunchInoutSetup);
        }

        // DELETE: api/LunchInoutSetups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgLunchInoutSetup(int id)
        {
            var dgLunchInoutSetup = await _context.DgLunchInoutSetups.FindAsync(id);
            if (dgLunchInoutSetup == null)
            {
                return NotFound();
            }

            _context.DgLunchInoutSetups.Remove(dgLunchInoutSetup);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgLunchInoutSetupExists(int id)
        {
            return _context.DgLunchInoutSetups.Any(e => e.LSerial == id);
        }
    }
}
