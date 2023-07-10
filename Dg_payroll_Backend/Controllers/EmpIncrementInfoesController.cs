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
    public class EmpIncrementInfoesController : ControllerBase
    {

        private readonly dg_hrpayrollContext _context;
        SqlConnection con = new SqlConnection("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");

        public EmpIncrementInfoesController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        [HttpGet("get-Increment_list")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgEmpIncrementInfo>>> Increment_list(int Compid)
        {
            SqlCommand com = new SqlCommand("Dg_increment_list", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Compid", Compid);
            //com.Parameters.AddWithValue("@Newshift", Newshift);
            //com.Parameters.AddWithValue("@EffectDate", EffectDate);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
            //const.Database.ExecuteSqlCommand("Insert into Emp_filtering Values({0},{1},{2})", param1, param2, param3)
        }

        // GET: api/EmpIncrementInfoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgEmpIncrementInfo>>> GetDgEmpIncrementInfos()
        {
          if (_context.DgEmpIncrementInfos == null)
          {
              return NotFound();
          }
            return await _context.DgEmpIncrementInfos.ToListAsync();
        }

        // GET: api/EmpIncrementInfoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DgEmpIncrementInfo>> GetDgEmpIncrementInfo(int id)
        {
          if (_context.DgEmpIncrementInfos == null)
          {
              return NotFound();
          }
            var dgEmpIncrementInfo = await _context.DgEmpIncrementInfos.FindAsync(id);

            if (dgEmpIncrementInfo == null)
            {
                return NotFound();
            }

            return dgEmpIncrementInfo;
        }

        // PUT: api/EmpIncrementInfoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgEmpIncrementInfo(int id, DgEmpIncrementInfo dgEmpIncrementInfo)
        {
            if (id != dgEmpIncrementInfo.IncId)
            {
                return BadRequest();
            }

            _context.Entry(dgEmpIncrementInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgEmpIncrementInfoExists(id))
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

        // POST: api/EmpIncrementInfoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgEmpIncrementInfo>> PostDgEmpIncrementInfo(DgEmpIncrementInfo dgEmpIncrementInfo)
        {
          if (_context.DgEmpIncrementInfos == null)
          {
              return Problem("Entity set 'dg_hrpayrollContext.DgEmpIncrementInfos'  is null.");
          }
            _context.DgEmpIncrementInfos.Add(dgEmpIncrementInfo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgEmpIncrementInfo", new { id = dgEmpIncrementInfo.IncId }, dgEmpIncrementInfo);
        }

        // DELETE: api/EmpIncrementInfoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgEmpIncrementInfo(int id)
        {
            if (_context.DgEmpIncrementInfos == null)
            {
                return NotFound();
            }
            var dgEmpIncrementInfo = await _context.DgEmpIncrementInfos.FindAsync(id);
            if (dgEmpIncrementInfo == null)
            {
                return NotFound();
            }

            _context.DgEmpIncrementInfos.Remove(dgEmpIncrementInfo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgEmpIncrementInfoExists(int id)
        {
            return (_context.DgEmpIncrementInfos?.Any(e => e.IncId == id)).GetValueOrDefault();
        }
    }
}
