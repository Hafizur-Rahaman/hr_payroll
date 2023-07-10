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
    public class AttbonusRulesController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public AttbonusRulesController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/AttbonusRules
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayAttbonusRule>>> GetDgPayAttbonusRules()
        {
            return await _context.DgPayAttbonusRules.ToListAsync();
        }

        // GET: api/AttbonusRules/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayAttbonusRule>> GetDgPayAttbonusRule(int id)
        {
            var dgPayAttbonusRule = await _context.DgPayAttbonusRules.FindAsync(id);

            if (dgPayAttbonusRule == null)
            {
                return NotFound();
            }

            return dgPayAttbonusRule;
        }

        // PUT: api/AttbonusRules/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayAttbonusRule(int id, DgPayAttbonusRule dgPayAttbonusRule)
        {
            //if (id != dgPayAttbonusRule.AtbrSerial)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayAttbonusRule).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayAttbonusRuleExists(id))
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

        // POST: api/AttbonusRules
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayAttbonusRule>> PostDgPayAttbonusRule(DgPayAttbonusRule dgPayAttbonusRule)
        {
            _context.DgPayAttbonusRules.Add(dgPayAttbonusRule);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayAttbonusRule", new { id = dgPayAttbonusRule.AtbrSerial }, dgPayAttbonusRule);
        }

        // DELETE: api/AttbonusRules/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayAttbonusRule(int id)
        {
            var dgPayAttbonusRule = await _context.DgPayAttbonusRules.FindAsync(id);
            if (dgPayAttbonusRule == null)
            {
                return NotFound();
            }

            _context.DgPayAttbonusRules.Remove(dgPayAttbonusRule);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayAttbonusRuleExists(int id)
        {
            return _context.DgPayAttbonusRules.Any(e => e.AtbrSerial == id);
        }
    }
}
