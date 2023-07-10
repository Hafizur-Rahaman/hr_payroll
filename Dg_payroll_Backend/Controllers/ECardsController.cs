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
using Microsoft.VisualBasic;
using Microsoft.AspNetCore.Authorization;

namespace Dg_payroll.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ECardsController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;
        SqlConnection con = new SqlConnection("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");
        //SqlConnection con = new SqlConnection("ApplicationDbContetConnection");
        public ECardsController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/ECards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ECard>>> GetECards()
        {
            return await _context.ECards.ToListAsync();
        }

        //////////////////////////////////////////  DateTime monthdate ,              com.Parameters.AddWithValue("@date", monthdate);
        ///[HttpGet("get-ECard/{comID}/{emp_id}/{date}/{uID}")]
        [HttpGet("get-ECardddddddd")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ECard>>> GeECardddddddd(int comID, int emp_id, DateTime monthdate )
        {
            SqlCommand com = new SqlCommand("Ecard_Worker_C", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@comID", comID);
            com.Parameters.AddWithValue("@emp_id", emp_id);
            com.Parameters.AddWithValue("@date", monthdate);
            //com.Parameters.AddWithValue("@uID", uID);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }
        ///[HttpGet("get-ECard/{comID}/{emp_id}/{date}/{uID}")]
        [HttpGet("get-ECarsum")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<IEnumerable<ECard>>> GeECarsum(string CompId, int Empid, DateTime EDate)
        {
            SqlCommand com = new SqlCommand("E_card_Sum", con);
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.AddWithValue("@CompId", CompId);
            com.Parameters.AddWithValue("@Empid", Empid);
            com.Parameters.AddWithValue("@EDate", EDate);
            //com.Parameters.AddWithValue("@uID", uID);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();
            da.Fill(ds);

            return Ok(ds);
        }
        // GET: api/ECards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ECard>> GetECard(int id)
        {
            var eCard = await _context.ECards.FindAsync(id);

            if (eCard == null)
            {
                return NotFound();
            }

            return eCard;
        }

        // PUT: api/ECards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutECard(int id, ECard eCard)
        {
            if (id != eCard.Id)
            {
                return BadRequest();
            }

            _context.Entry(eCard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ECardExists(id))
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

        // POST: api/ECards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<ECard>> PostECard(ECard eCard)
        {
            _context.ECards.Add(eCard);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (ECardExists(eCard.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetECard", new { id = eCard.Id }, eCard);
        }

        // DELETE: api/ECards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteECard(int id)
        {
            var eCard = await _context.ECards.FindAsync(id);
            if (eCard == null)
            {
                return NotFound();
            }

            _context.ECards.Remove(eCard);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ECardExists(int id)
        {
            return _context.ECards.Any(e => e.Id == id);
        }
    }
}
