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
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;

namespace Dg_payroll.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class DeductionController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public DeductionController(dg_hrpayrollContext context)
        {
            _context = context;
        }
        

        // GET: api/Deduction
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayDeductionsde>>> GetDgPayDeductionsdes()
        {
            return await _context.DgPayDeductionsdes.ToListAsync();
        }

    
        // GET: api/Deduction/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayDeductionsde>> GetDgPayDeductionsde(int id)
        {
            var dgPayDeductionsde = await _context.DgPayDeductionsdes.FindAsync(id);

            if (dgPayDeductionsde == null)
            {
                return NotFound();
            }

            return dgPayDeductionsde;
        }

        // PUT: api/Deduction/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayDeductionsde(int id, DgPayDeductionsde dgPayDeductionsde)
        {
            //if (id != dgPayDeductionsde.DCode)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayDeductionsde).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayDeductionsdeExists(id))
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

        // POST: api/Deduction
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayDeductionsde>> PostDgPayDeductionsde(DgPayDeductionsde dgPayDeductionsde)
        {
            _context.DgPayDeductionsdes.Add(dgPayDeductionsde);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayDeductionsde", new { id = dgPayDeductionsde.DCode }, dgPayDeductionsde);
        }

        // DELETE: api/Deduction/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayDeductionsde(int id)
        {
            var dgPayDeductionsde = await _context.DgPayDeductionsdes.FindAsync(id);
            if (dgPayDeductionsde == null)
            {
                return NotFound();
            }

            _context.DgPayDeductionsdes.Remove(dgPayDeductionsde);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayDeductionsdeExists(int id)
        {
            return _context.DgPayDeductionsdes.Any(e => e.DCode == id);
        }
    }
}
