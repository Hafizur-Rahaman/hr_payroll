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
    public class LoancategoriesController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public LoancategoriesController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/Loancategories
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayLoancategory>>> GetDgPayLoancategories()
        {
            return await _context.DgPayLoancategories.ToListAsync();
        }

        // GET: api/Loancategories/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayLoancategory>> GetDgPayLoancategory(int id)
        {
            var dgPayLoancategory = await _context.DgPayLoancategories.FindAsync(id);

            if (dgPayLoancategory == null)
            {
                return NotFound();
            }

            return dgPayLoancategory;
        }

        // PUT: api/Loancategories/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayLoancategory(int id, DgPayLoancategory dgPayLoancategory)
        {
            //if (id != dgPayLoancategory.LcId)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayLoancategory).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayLoancategoryExists(id))
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

        // POST: api/Loancategories
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayLoancategory>> PostDgPayLoancategory(DgPayLoancategory dgPayLoancategory)
        {
            _context.DgPayLoancategories.Add(dgPayLoancategory);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayLoancategory", new { id = dgPayLoancategory.LcId }, dgPayLoancategory);
        }

        // DELETE: api/Loancategories/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayLoancategory(int id)
        {
            var dgPayLoancategory = await _context.DgPayLoancategories.FindAsync(id);
            if (dgPayLoancategory == null)
            {
                return NotFound();
            }

            _context.DgPayLoancategories.Remove(dgPayLoancategory);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayLoancategoryExists(int id)
        {
            return _context.DgPayLoancategories.Any(e => e.LcId == id);
        }
    }
}
