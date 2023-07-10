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
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using Microsoft.AspNetCore.Authorization;

namespace Dg_payroll.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ShiftChangesController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;
        SqlConnection con = new SqlConnection("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");
        
        public ShiftChangesController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/ShiftChanges
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayShiftChange>>> GetDgPayShiftChanges()
        {
            return await _context.DgPayShiftChanges.ToListAsync();
        }
        //
        [HttpGet("get_shift_info")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayShiftChange>>> ShiftChanges_Batch(int CompID, int emp_no)
        {
            SqlCommand com = new SqlCommand("D_ShiftChange", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CompID", CompID);
            com.Parameters.AddWithValue("@emp_no", emp_no);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }


        [HttpGet("get_ShiftSearch")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayShiftChange>>> ShiftSearch(int compid, DateTime s_date, DateTime E_date)
        {
            SqlCommand com = new SqlCommand("D_ShiftChange_search", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@compid", compid);
            com.Parameters.AddWithValue("@s_date", s_date);
            com.Parameters.AddWithValue("@E_date", E_date);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds); 
            return Ok(ds);
        }

        //Shift
       [HttpGet("get-Shift-list")]
       [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayEmployee>>> GetShift(int compid)
        {
            SqlCommand com = new SqlCommand("D_Shift", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CompID", compid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }

        // Shift Change individual
        [HttpGet("get-ShiftChanges_individual")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayShiftChange>>> ShiftChanges_Batch(int emp_serial, int oi_shift_OLD, int oi_shift, DateTime effectDate, String User,DateTime Udate)
        {
            SqlCommand com = new SqlCommand("dg_pay_Emp_Change_Shift", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@emp_serial", emp_serial);
            com.Parameters.AddWithValue("@oi_shift_OLD", oi_shift_OLD);
            com.Parameters.AddWithValue("@oi_shift", oi_shift);
            com.Parameters.AddWithValue("@effectDate", effectDate);
            com.Parameters.AddWithValue("@User", User);
            com.Parameters.AddWithValue("@Udate", Udate);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
        }

        //remove
        //mm
        [HttpGet("get-ShiftChanges_Batch")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayShiftChange>>> ShiftChanges_Batch(int oi_shift, DateTime effectDate, string User, DateTime Udate, int comid)
        {
            SqlCommand com = new SqlCommand("dg_pay_Emp_Change_Shift_Batch", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@oi_shift", oi_shift);
            com.Parameters.AddWithValue("@effectDate", effectDate);
            com.Parameters.AddWithValue("@User", User);
            com.Parameters.AddWithValue("@Udate", Udate);
            com.Parameters.AddWithValue("@comid", comid);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
        }

        [HttpGet("get-FilterBase_employee")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<DgPayShiftChange>>> employee_Info(int? Compid = null,  int? Department = null, int? section = null, int? Building = null, int? Floor = null, int? Line = null, int? Shift = null, int? Grade = null, int? salcat = null, int? Newshift = null, DateTime? EffectDate = null)
        {
            SqlCommand com = new SqlCommand("Emp_filtering", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@Compid", Compid);
            com.Parameters.AddWithValue("@Department", Department);
            com.Parameters.AddWithValue("@section", section);
            com.Parameters.AddWithValue("@Building", Building);
            com.Parameters.AddWithValue("@Floor", Floor);
            com.Parameters.AddWithValue("@Line", Line);
            com.Parameters.AddWithValue("@Shift", Shift);
            com.Parameters.AddWithValue("@Grade", Grade);
            com.Parameters.AddWithValue("@salcat", salcat);
            com.Parameters.AddWithValue("@Newshift", Newshift);
            com.Parameters.AddWithValue("@EffectDate", EffectDate);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return Ok(ds);
            //const.Database.ExecuteSqlCommand("Insert into Emp_filtering Values({0},{1},{2})", param1, param2, param3)
        }
         //mm
         // GET: api/ShiftChanges/5
         [HttpGet("{id}")]
        public async Task<ActionResult<DgPayShiftChange>> GetDgPayShiftChange(int id)
        {
            var dgPayShiftChange = await _context.DgPayShiftChanges.FindAsync(id);

            if (dgPayShiftChange == null)
            {
                return NotFound();
            }

            return dgPayShiftChange;
        }

        // PUT: api/ShiftChanges/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDgPayShiftChange(int id, DgPayShiftChange dgPayShiftChange)
        {
            //if (id != dgPayShiftChange.ScSerial)
            //{
            //    return BadRequest();
            //}

            _context.Entry(dgPayShiftChange).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DgPayShiftChangeExists(id))
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

        // POST: api/ShiftChanges
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<DgPayShiftChange>> PostDgPayShiftChange(DgPayShiftChange dgPayShiftChange)
        {
            _context.DgPayShiftChanges.Add(dgPayShiftChange);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDgPayShiftChange", new { id = dgPayShiftChange.ScSerial }, dgPayShiftChange);
        }

        // DELETE: api/ShiftChanges/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDgPayShiftChange(int id)
        {
            var dgPayShiftChange = await _context.DgPayShiftChanges.FindAsync(id);
            if (dgPayShiftChange == null)
            {
                return NotFound();
            }

            _context.DgPayShiftChanges.Remove(dgPayShiftChange);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DgPayShiftChangeExists(int id)
        {
            return _context.DgPayShiftChanges.Any(e => e.ScSerial == id);
        }
    }
}

