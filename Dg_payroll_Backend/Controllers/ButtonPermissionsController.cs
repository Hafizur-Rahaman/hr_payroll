using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dg_payroll.Data;
using Dg_payroll.Models;
using System.Data.SqlClient;
using System.Data;

namespace Dg_payroll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ButtonPermissionsController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;
        SqlConnection con = new SqlConnection("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");
        public ButtonPermissionsController(dg_hrpayrollContext context)
        {
            _context = context;
        }
        [HttpGet("userwise_Buttonlist")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgButtonPermission>>> Getuserwisebuttonlist(string b_user)
        {
            SqlCommand com = new SqlCommand("user_wise_buttonlist", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@b_user", b_user);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }
        // GET: api/ButtonPermissions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgButtonPermission>>> GetDgButtonPermissions()
        {
          if (_context.DgButtonPermissions == null)
          {
              return NotFound();
          }
            return await _context.DgButtonPermissions.ToListAsync();
        }

        // GET: api/ButtonPermissions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgButtonPermission>> GetDgButtonPermission(int id)
        {
          if (_context.DgButtonPermissions == null)
          {
              return NotFound();
          }
            var dgButtonPermission = await _context.DgButtonPermissions.FindAsync(id);

            if (dgButtonPermission == null)
            {
                return NotFound();
            }

            return dgButtonPermission;
        }

        // PUT: api/ButtonPermissions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgButtonPermission(int id, DgButtonPermission dgButtonPermission)
        {
            if (id != dgButtonPermission.BSl)
            {
                return BadRequest();
            }

            _context.Entry(dgButtonPermission).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgButtonPermissionExists(id))
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

        // POST: api/ButtonPermissions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgButtonPermission>> PostDgButtonPermission(DgButtonPermission dgButtonPermission)
        {
          if (_context.DgButtonPermissions == null)
          {
              return Problem("Entity set 'dg_hrpayrollContext.DgButtonPermissions'  is null.");
          }
            _context.DgButtonPermissions.Add(dgButtonPermission);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgButtonPermission", new { id = dgButtonPermission.BSl }, dgButtonPermission);
        }

        // DELETE: api/ButtonPermissions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgButtonPermission(int id)
        {
            if (_context.DgButtonPermissions == null)
            {
                return NotFound();
            }
            var dgButtonPermission = await _context.DgButtonPermissions.FindAsync(id);
            if (dgButtonPermission == null)
            {
                return NotFound();
            }

            _context.DgButtonPermissions.Remove(dgButtonPermission);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgButtonPermissionExists(int id)
        {
            return (_context.DgButtonPermissions?.Any(e => e.BSl == id)).GetValueOrDefault();
        }
    }
}
