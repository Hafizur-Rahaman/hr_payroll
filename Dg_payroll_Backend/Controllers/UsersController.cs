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
    public class UsersController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;

        public UsersController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblUser>>> GetTblUsers()
        {
          if (_context.TblUsers == null)
          {
              return NotFound();
          }
            return await _context.TblUsers.ToListAsync();
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblUser>> GetTblUser(int id)
        {
          if (_context.TblUsers == null)
          {
              return NotFound();
          }
            var tblUser = await _context.TblUsers.FindAsync(id);

            if (tblUser == null)
            {
                return NotFound();
            }

            return tblUser;
        }

        // PUT: api/Users/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblUser(int id, TblUser tblUser)
        {
            if (id != tblUser.Id)
            {
                return BadRequest();
            }

            _context.Entry(tblUser).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblUserExists(id))
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

        // POST: api/Users
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TblUser>> PostTblUser(TblUser tblUser)
        {
          if (_context.TblUsers == null)
          {
              return Problem("Entity set 'dg_hrpayrollContext.TblUsers'  is null.");
          }
            _context.TblUsers.Add(tblUser);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblUser", new { id = tblUser.Id }, tblUser);
        }

        // DELETE: api/Users/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblUser(int id)
        {
            if (_context.TblUsers == null)
            {
                return NotFound();
            }
            var tblUser = await _context.TblUsers.FindAsync(id);
            if (tblUser == null)
            {
                return NotFound();
            }

            _context.TblUsers.Remove(tblUser);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblUserExists(int id)
        {
            return (_context.TblUsers?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
