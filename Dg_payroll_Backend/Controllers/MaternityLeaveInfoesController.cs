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
using Microsoft.AspNetCore.Authorization;

namespace Dg_payroll.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class MaternityLeaveInfoesController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;
        SqlConnection con = new SqlConnection("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");

        public MaternityLeaveInfoesController(dg_hrpayrollContext context)
        {
            _context = context;
        }


        [HttpGet("get-MaternityLeaveInfo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayMaternityLeaveInfo>>> GetMaternityLeaveInfo(int CompID, DateTime Startdate, DateTime Enddate)
        {
            SqlCommand com = new SqlCommand("D_Maternityleave_SdateToEdate", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@ComID", CompID);
            com.Parameters.AddWithValue("@Startdate", Startdate);
            com.Parameters.AddWithValue("@Enddate", Enddate);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        // GET: api/MaternityLeaveInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayMaternityLeaveInfo>>> GetDgPayMaternityLeaveInfos()
        {
            return await _context.DgPayMaternityLeaveInfos.ToListAsync();
        }

        // GET: api/MaternityLeaveInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgPayMaternityLeaveInfo>> GetDgPayMaternityLeaveInfo(int id)
        {
            var dgPayMaternityLeaveInfo = await _context.DgPayMaternityLeaveInfos.FindAsync(id);

            if (dgPayMaternityLeaveInfo == null)
            {
                return NotFound();
            }

            return dgPayMaternityLeaveInfo;
        }

        // PUT: api/MaternityLeaveInfoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayMaternityLeaveInfo(int id, DgPayMaternityLeaveInfo dgPayMaternityLeaveInfo)
        {
            //if (id != dgPayMaternityLeaveInfo.SerialNo)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayMaternityLeaveInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayMaternityLeaveInfoExists(id))
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

        // POST: api/MaternityLeaveInfoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayMaternityLeaveInfo>> PostDgPayMaternityLeaveInfo(DgPayMaternityLeaveInfo dgPayMaternityLeaveInfo)
        {
            _context.DgPayMaternityLeaveInfos.Add(dgPayMaternityLeaveInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayMaternityLeaveInfo", new { id = dgPayMaternityLeaveInfo.SerialNo }, dgPayMaternityLeaveInfo);
        }

        // DELETE: api/MaternityLeaveInfoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayMaternityLeaveInfo(int id)
        {
            var dgPayMaternityLeaveInfo = await _context.DgPayMaternityLeaveInfos.FindAsync(id);
            if (dgPayMaternityLeaveInfo == null)
            {
                return NotFound();
            }

            _context.DgPayMaternityLeaveInfos.Remove(dgPayMaternityLeaveInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayMaternityLeaveInfoExists(int id)
        {
            return _context.DgPayMaternityLeaveInfos.Any(e => e.SerialNo == id);
        }
    }
}
