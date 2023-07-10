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
    public class GradesController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public GradesController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/Grades
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayGrade>>> GetDgPayGrades()
        {
            return await _context.DgPayGrades.ToListAsync();
        }

        // GET: api/Grades/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayGrade>> GetDgPayGrade(int id)
        {
            var dgPayGrade = await _context.DgPayGrades.FindAsync(id);

            if (dgPayGrade == null)
            {
                return NotFound();
            }

            return dgPayGrade;
        }

        // PUT: api/Grades/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayGrade(int id, DgPayGrade dgPayGrade)
        {
            if (id != dgPayGrade.GrdId)
            {
                return BadRequest();
            }

            _context.Entry(dgPayGrade).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayGradeExists(id))
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

        // POST: api/Grades
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayGrade>> PostDgPayGrade(DgPayGrade dgPayGrade)
        {
            _context.DgPayGrades.Add(dgPayGrade);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayGrade", new { id = dgPayGrade.GrdId }, dgPayGrade);
        }

        // DELETE: api/Grades/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayGrade(int id)
        {
            var dgPayGrade = await _context.DgPayGrades.FindAsync(id);
            if (dgPayGrade == null)
            {
                return NotFound();
            }

            _context.DgPayGrades.Remove(dgPayGrade);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayGradeExists(int id)
        {
            return _context.DgPayGrades.Any(e => e.GrdId == id);
        }
    }
}
