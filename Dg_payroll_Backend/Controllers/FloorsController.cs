using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dg_payroll.Data;
using Dg_payroll.Models;

namespace Dg_payroll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FloorsController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public FloorsController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/Floors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayFloor>>> GetDgPayFloors()
        {
            return await _context.DgPayFloors.ToListAsync();
        }

        // GET: api/Floors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayFloor>> GetDgPayFloor(int id)
        {
            var dgPayFloor = await _context.DgPayFloors.FindAsync(id);

            if (dgPayFloor == null)
            {
                return NotFound();
            }

            return dgPayFloor;
        }

        // PUT: api/Floors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayFloor(int id, DgPayFloor dgPayFloor)
        {
            //if (id != dgPayFloor.NFloor)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayFloor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayFloorExists(id))
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

        // POST: api/Floors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayFloor>> PostDgPayFloor(DgPayFloor dgPayFloor)
        {
            _context.DgPayFloors.Add(dgPayFloor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayFloor", new { id = dgPayFloor.NFloor }, dgPayFloor);
        }

        // DELETE: api/Floors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayFloor(int id)
        {
            var dgPayFloor = await _context.DgPayFloors.FindAsync(id);
            if (dgPayFloor == null)
            {
                return NotFound();
            }

            _context.DgPayFloors.Remove(dgPayFloor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayFloorExists(int id)
        {
            return _context.DgPayFloors.Any(e => e.NFloor == id);
        }
    }
}
