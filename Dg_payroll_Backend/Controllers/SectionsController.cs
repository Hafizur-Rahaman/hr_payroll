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
    public class SectionsController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public SectionsController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/Sections
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPaySection>>> GetDgPaySections()
        {
            return await _context.DgPaySections.ToListAsync();
        }

        // GET: api/Sections/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPaySection>> GetDgPaySection(int id)
        {
            var dgPaySection = await _context.DgPaySections.FindAsync(id);

            if (dgPaySection == null)
            {
                return NotFound();
            }

            return dgPaySection;
        }

        // PUT: api/Sections/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPaySection(int id, DgPaySection dgPaySection)
        {
            //if (id != dgPaySection.NSectionId)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPaySection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPaySectionExists(id))
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

        // POST: api/Sections
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPaySection>> PostDgPaySection(DgPaySection dgPaySection)
        {
            _context.DgPaySections.Add(dgPaySection);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPaySection", new { id = dgPaySection.NSectionId }, dgPaySection);
        }

        // DELETE: api/Sections/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPaySection(int id)
        {
            var dgPaySection = await _context.DgPaySections.FindAsync(id);
            if (dgPaySection == null)
            {
                return NotFound();
            }

            _context.DgPaySections.Remove(dgPaySection);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPaySectionExists(int id)
        {
            return _context.DgPaySections.Any(e => e.NSectionId == id);
        }
    }
}
