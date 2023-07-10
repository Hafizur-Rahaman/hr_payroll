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
    public class TiffinbillrulesController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public TiffinbillrulesController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/Tiffinbillrules
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayTiffinbillrule>>> GetDgPayTiffinbillrules()
        {
            return await _context.DgPayTiffinbillrules.ToListAsync();
        }

        // GET: api/Tiffinbillrules/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayTiffinbillrule>> GetDgPayTiffinbillrule(int id)
        {
            var dgPayTiffinbillrule = await _context.DgPayTiffinbillrules.FindAsync(id);

            if (dgPayTiffinbillrule == null)
            {
                return NotFound();
            }

            return dgPayTiffinbillrule;
        }

        // PUT: api/Tiffinbillrules/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayTiffinbillrule(int id, DgPayTiffinbillrule dgPayTiffinbillrule)
        {
            //if (id != dgPayTiffinbillrule.Serial)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayTiffinbillrule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayTiffinbillruleExists(id))
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

        // POST: api/Tiffinbillrules
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayTiffinbillrule>> PostDgPayTiffinbillrule(DgPayTiffinbillrule dgPayTiffinbillrule)
        {
            _context.DgPayTiffinbillrules.Add(dgPayTiffinbillrule);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayTiffinbillrule", new { id = dgPayTiffinbillrule.Serial }, dgPayTiffinbillrule);
        }

        // DELETE: api/Tiffinbillrules/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayTiffinbillrule(int id)
        {
            var dgPayTiffinbillrule = await _context.DgPayTiffinbillrules.FindAsync(id);
            if (dgPayTiffinbillrule == null)
            {
                return NotFound();
            }

            _context.DgPayTiffinbillrules.Remove(dgPayTiffinbillrule);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayTiffinbillruleExists(int id)
        {
            return _context.DgPayTiffinbillrules.Any(e => e.Serial == id);
        }
    }
}
