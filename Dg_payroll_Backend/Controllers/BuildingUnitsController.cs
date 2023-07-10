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
    public class BuildingUnitsController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public BuildingUnitsController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/BuildingUnits
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayBuildingUnit>>> GetDgPayBuildingUnits()
        {
            return await _context.DgPayBuildingUnits.ToListAsync();
        }

        // GET: api/BuildingUnits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayBuildingUnit>> GetDgPayBuildingUnit(int id)
        {
            var dgPayBuildingUnit = await _context.DgPayBuildingUnits.FindAsync(id);

            if (dgPayBuildingUnit == null)
            {
                return NotFound();
            }

            return dgPayBuildingUnit;
        }

        // PUT: api/BuildingUnits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayBuildingUnit(int id, DgPayBuildingUnit dgPayBuildingUnit)
        {
            //if (id != dgPayBuildingUnit.UnitCode)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayBuildingUnit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayBuildingUnitExists(id))
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

        // POST: api/BuildingUnits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayBuildingUnit>> PostDgPayBuildingUnit(DgPayBuildingUnit dgPayBuildingUnit)
        {
            _context.DgPayBuildingUnits.Add(dgPayBuildingUnit);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayBuildingUnit", new { id = dgPayBuildingUnit.UnitCode }, dgPayBuildingUnit);
        }

        // DELETE: api/BuildingUnits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayBuildingUnit(int id)
        {
            var dgPayBuildingUnit = await _context.DgPayBuildingUnits.FindAsync(id);
            if (dgPayBuildingUnit == null)
            {
                return NotFound();
            }

            _context.DgPayBuildingUnits.Remove(dgPayBuildingUnit);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayBuildingUnitExists(int id)
        {
            return _context.DgPayBuildingUnits.Any(e => e.UnitCode == id);
        }
    }
}
