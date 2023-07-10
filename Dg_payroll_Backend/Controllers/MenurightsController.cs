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
    public class MenurightsController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;
        SqlConnection con = new SqlConnection("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");
        public MenurightsController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        [HttpGet("Company-wise-userlist")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgMenuright>>> GetCompanywiseuserlist(int compid)
        {
            SqlCommand com = new SqlCommand("UserList_comp_wise", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@compid", compid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        [HttpGet("userwise_menulist")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgMenuright>>> Getuserwisemenulist(string m_user)
        {
            SqlCommand com = new SqlCommand("user_wise_menulist", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@m_user", m_user);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        // GET: api/Menurights
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgMenuright>>> GetDgMenurights()
        {
          if (_context.DgMenurights == null)
          {
              return NotFound();
          }
            return await _context.DgMenurights.ToListAsync();
        }

        // GET: api/Menurights/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgMenuright>> GetDgMenuright(int id)
        {
          if (_context.DgMenurights == null)
          {
              return NotFound();
          }
            var dgMenuright = await _context.DgMenurights.FindAsync(id);

            if (dgMenuright == null)
            {
                return NotFound();
            }

            return dgMenuright;
        }

        // PUT: api/Menurights/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgMenuright(int id, DgMenuright dgMenuright)
        {
            if (id != dgMenuright.MSl)
            {
                return BadRequest();
            }

            _context.Entry(dgMenuright).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgMenurightExists(id))
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

        // POST: api/Menurights
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgMenuright>> PostDgMenuright(DgMenuright dgMenuright)
        {
          if (_context.DgMenurights == null)
          {
              return Problem("Entity set 'dg_hrpayrollContext.DgMenurights'  is null.");
          }
            _context.DgMenurights.Add(dgMenuright);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgMenuright", new { id = dgMenuright.MSl }, dgMenuright);
        }

        // DELETE: api/Menurights/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgMenuright(int id)
        {
            if (_context.DgMenurights == null)
            {
                return NotFound();
            }
            var dgMenuright = await _context.DgMenurights.FindAsync(id);
            if (dgMenuright == null)
            {
                return NotFound();
            }

            _context.DgMenurights.Remove(dgMenuright);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgMenurightExists(int id)
        {
            return (_context.DgMenurights?.Any(e => e.MSl == id)).GetValueOrDefault();
        }
    }
}
