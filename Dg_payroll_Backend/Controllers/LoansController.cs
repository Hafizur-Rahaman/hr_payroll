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
    public class LoansController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public LoansController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/Loans
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayLoan>>> GetDgPayLoans()
        {
            return await _context.DgPayLoans.ToListAsync();
        }

        // GET: api/Loans/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayLoan>> GetDgPayLoan(int id)
        {
            var dgPayLoan = await _context.DgPayLoans.FindAsync(id);

            if (dgPayLoan == null)
            {
                return NotFound();
            }

            return dgPayLoan;
        }

        // PUT: api/Loans/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayLoan(int id, DgPayLoan dgPayLoan)
        {
            //if (id != dgPayLoan.LLoanserial)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayLoan).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayLoanExists(id))
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

        // POST: api/Loans
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayLoan>> PostDgPayLoan(DgPayLoan dgPayLoan)
        {
            _context.DgPayLoans.Add(dgPayLoan);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayLoan", new { id = dgPayLoan.LLoanserial }, dgPayLoan);
        }

        // DELETE: api/Loans/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayLoan(int id)
        {
            var dgPayLoan = await _context.DgPayLoans.FindAsync(id);
            if (dgPayLoan == null)
            {
                return NotFound();
            }

            _context.DgPayLoans.Remove(dgPayLoan);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayLoanExists(int id)
        {
            return _context.DgPayLoans.Any(e => e.LLoanserial == id);
        }
    }
}
