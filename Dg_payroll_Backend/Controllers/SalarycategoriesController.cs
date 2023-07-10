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
    public class SalarycategoriesController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public SalarycategoriesController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/Salarycategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPaySalarycategory>>> GetDgPaySalarycategories()
        {
            return await _context.DgPaySalarycategories.ToListAsync();
        }

        // GET: api/Salarycategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPaySalarycategory>> GetDgPaySalarycategory(int id)
        {
            var dgPaySalarycategory = await _context.DgPaySalarycategories.FindAsync(id);

            if (dgPaySalarycategory == null)
            {
                return NotFound();
            }

            return dgPaySalarycategory;
        }

        // PUT: api/Salarycategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPaySalarycategory(int id, DgPaySalarycategory dgPaySalarycategory)
        {
            //if (id != dgPaySalarycategory.CatId)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPaySalarycategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPaySalarycategoryExists(id))
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

        // POST: api/Salarycategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPaySalarycategory>> PostDgPaySalarycategory(DgPaySalarycategory dgPaySalarycategory)
        {
            _context.DgPaySalarycategories.Add(dgPaySalarycategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPaySalarycategory", new { id = dgPaySalarycategory.CatId }, dgPaySalarycategory);
        }

        // DELETE: api/Salarycategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPaySalarycategory(int id)
        {
            var dgPaySalarycategory = await _context.DgPaySalarycategories.FindAsync(id);
            if (dgPaySalarycategory == null)
            {
                return NotFound();
            }

            _context.DgPaySalarycategories.Remove(dgPaySalarycategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPaySalarycategoryExists(int id)
        {
            return _context.DgPaySalarycategories.Any(e => e.CatId == id);
        }
    }
}
