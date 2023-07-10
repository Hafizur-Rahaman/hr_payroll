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
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AllowancesdesController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public AllowancesdesController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        

        // GET: api/Allowancesdes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayAllowancesde>>> GetDgPayAllowancesdes()
        {
            return await _context.DgPayAllowancesdes.ToListAsync();
        }

        // GET: api/Allowancesdes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayAllowancesde>> GetDgPayAllowancesde(int id)
        {
            var dgPayAllowancesde = await _context.DgPayAllowancesdes.FindAsync(id);

            if (dgPayAllowancesde == null)
            {
                return NotFound();
            }

            return dgPayAllowancesde;
        }

        // PUT: api/Allowancesdes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayAllowancesde(int id, DgPayAllowancesde dgPayAllowancesde)
        {
            //if (id != dgPayAllowancesde.AlCode)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayAllowancesde).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayAllowancesdeExists(id))
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

        // POST: api/Allowancesdes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayAllowancesde>> PostDgPayAllowancesde(DgPayAllowancesde dgPayAllowancesde)
        {
            _context.DgPayAllowancesdes.Add(dgPayAllowancesde);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayAllowancesde", new { id = dgPayAllowancesde.AlCode }, dgPayAllowancesde);
        }

        // DELETE: api/Allowancesdes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayAllowancesde(int id)
        {
            var dgPayAllowancesde = await _context.DgPayAllowancesdes.FindAsync(id);
            if (dgPayAllowancesde == null)
            {
                return NotFound();
            }

            _context.DgPayAllowancesdes.Remove(dgPayAllowancesde);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayAllowancesdeExists(int id)
        {
            return _context.DgPayAllowancesdes.Any(e => e.AlCode == id);
        }

        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<DgPayAllowancesde>>> GetAllAllowance()
        //{
        //    List <DgPayAllowancesde> object = _context.DgPayAllowances.GetAsyncEnumerator();

        //    return await _context.DgPayAllowancesdes.ToListAsync();
        //}

        //public IActionResult GetAllAllowance()
        //{
        //    IEnumerable < DgPayAllowancesde > object = _context.DgPayAllowancesdes.GetAsyncEnumerator();
        //}

        //public  Task<IActionResult> GetAllAllowance()
        //{
        //    var dgPayAllowancesde =  _context.DgPayAllowancesdes.GetAsyncEnumerator();
        //    var myObject = dgPayAllowancesde.where

        //}
    }
}
