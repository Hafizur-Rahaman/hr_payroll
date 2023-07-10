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
    public class BankInfosController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public BankInfosController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/BankInfos
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayBankInfo>>> GetDgPayBankInfos()
        {
            return await _context.DgPayBankInfos.ToListAsync();
        }

        // GET: api/BankInfos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayBankInfo>> GetDgPayBankInfo(int id)
        {
            var dgPayBankInfo = await _context.DgPayBankInfos.FindAsync(id);

            if (dgPayBankInfo == null)
            {
                return NotFound();
            }

            return dgPayBankInfo;
        }

        // PUT: api/BankInfos/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayBankInfo(int id, DgPayBankInfo dgPayBankInfo)
        {
            //if (id != dgPayBankInfo.BankCode)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayBankInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayBankInfoExists(id))
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

        // POST: api/BankInfos
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayBankInfo>> PostDgPayBankInfo(DgPayBankInfo dgPayBankInfo)
        {
            _context.DgPayBankInfos.Add(dgPayBankInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayBankInfo", new { id = dgPayBankInfo.BankCode }, dgPayBankInfo);
        }

        // DELETE: api/BankInfos/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayBankInfo(int id)
        {
            var dgPayBankInfo = await _context.DgPayBankInfos.FindAsync(id);
            if (dgPayBankInfo == null)
            {
                return NotFound();
            }

            _context.DgPayBankInfos.Remove(dgPayBankInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayBankInfoExists(int id)
        {
            return _context.DgPayBankInfos.Any(e => e.BankCode == id);
        }
    }
}
