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
    public class DesignationsController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public DesignationsController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/Designations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayDesignation>>> GetDgPayDesignations()
        {
            return await _context.DgPayDesignations.ToListAsync();
        }

        // GET: api/Designations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayDesignation>> GetDgPayDesignation(int id)
        {
            var dgPayDesignation = await _context.DgPayDesignations.FindAsync(id);

            if (dgPayDesignation == null)
            {
                return NotFound();
            }

            return dgPayDesignation;
        }

        // PUT: api/Designations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayDesignation(int id, DgPayDesignation dgPayDesignation)
        {
            //if (id != dgPayDesignation.DecId)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayDesignation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayDesignationExists(id))
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

        // POST: api/Designations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayDesignation>> PostDgPayDesignation(DgPayDesignation dgPayDesignation)
        {
            _context.DgPayDesignations.Add(dgPayDesignation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayDesignation", new { id = dgPayDesignation.DecId }, dgPayDesignation);
        }

        // DELETE: api/Designations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayDesignation(int id)
        {
            var dgPayDesignation = await _context.DgPayDesignations.FindAsync(id);
            if (dgPayDesignation == null)
            {
                return NotFound();
            }

            _context.DgPayDesignations.Remove(dgPayDesignation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayDesignationExists(int id)
        {
            return _context.DgPayDesignations.Any(e => e.DecId == id);
        }
    }
}
