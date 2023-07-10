using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dg_payroll.Data;
using Dg_payroll.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using Microsoft.AspNetCore.Authorization;

namespace Dg_payroll.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveInforsController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;
        SqlConnection con = new SqlConnection("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");

        [HttpGet("get-LeaveInfo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayLeaveInfor>>> GetCompanyName(int CompID,int EmpNO, int year)
        {
            SqlCommand com = new SqlCommand("D_leave_info", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CompID", CompID);
            com.Parameters.AddWithValue("@EmpNO", EmpNO);
            com.Parameters.AddWithValue("@year", year);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        public LeaveInforsController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/LeaveInfors
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayLeaveInfor>>> GetDgPayLeaveInfors()
        {
            return await _context.DgPayLeaveInfors.ToListAsync();
        }

        // GET: api/LeaveInfors/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayLeaveInfor>> GetDgPayLeaveInfor(int id)
        {
            var dgPayLeaveInfor = await _context.DgPayLeaveInfors.FindAsync(id);

            if (dgPayLeaveInfor == null)
            {
                return NotFound();
            }

            return dgPayLeaveInfor;
        }

        // PUT: api/LeaveInfors/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayLeaveInfor(int id, DgPayLeaveInfor dgPayLeaveInfor)
        {
            //if (id != dgPayLeaveInfor.LevYear)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayLeaveInfor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayLeaveInforExists(id))
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

        // POST: api/LeaveInfors
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayLeaveInfor>> PostDgPayLeaveInfor(DgPayLeaveInfor dgPayLeaveInfor)
        {
            _context.DgPayLeaveInfors.Add(dgPayLeaveInfor);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DgPayLeaveInforExists(dgPayLeaveInfor.LevYear))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDgPayLeaveInfor", new { id = dgPayLeaveInfor.LevYear }, dgPayLeaveInfor);
        }

        // DELETE: api/LeaveInfors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayLeaveInfor(int id)
        {
            var dgPayLeaveInfor = await _context.DgPayLeaveInfors.FindAsync(id);
            if (dgPayLeaveInfor == null)
            {
                return NotFound();
            }

            _context.DgPayLeaveInfors.Remove(dgPayLeaveInfor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayLeaveInforExists(int id)
        {
            return _context.DgPayLeaveInfors.Any(e => e.LevYear == id);
        }
    }
}
