using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Dg_payroll.Data;
using Dg_payroll.Models;
using Microsoft.AspNetCore.StaticFiles;
using Microsoft.Reporting.Map.WebForms.BingMaps;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using Microsoft.AspNetCore.Authorization;
using Dg_payroll.AppModel;

namespace Dg_payroll.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttdataImportsetupsController : ControllerBase
    {
        private readonly dg_hrpayrollContext _context;
        SqlConnection con = new SqlConnection("Data Source=192.168.1.42;Initial Catalog=dg_hrpayroll;Persist Security Info=true; User ID=sa; Password=dg@2022");
        public AttdataImportsetupsController(dg_hrpayrollContext context)
        {
            _context = context;
        }

        // GET: api/AttdataImportsetups
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DgPayAttdataImportsetup>>> GetDgPayAttdataImportsetups()
        {
            return await _context.DgPayAttdataImportsetups.ToListAsync();
            
        }

        //string hash = con.Database.SqlQuery<string>("Select PasswordHash From Users where Username = @username").FirstOrDefault<string>();

        

        //// GET: api/AttdataImportsetups/5
        //[HttpGet("{id}")]
        //public async Task<ActionResult<DgPayAttdataImportsetup>> GetDgPayAttdataImportsetup(int id)
        //{
        //    var dgPayAttdataImportsetup = await _context.DgPayAttdataImportsetups.FindAsync(id);

        //    if (dgPayAttdataImportsetup == null)
        //    {
        //        return NotFound();
        //    }

        //    return dgPayAttdataImportsetup;
        //}

        //// PUT: api/AttdataImportsetups/5
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutDgPayAttdataImportsetup(int id, DgPayAttdataImportsetup dgPayAttdataImportsetup)
        //{
        //    if (id != dgPayAttdataImportsetup.Sl)
        //    {
        //        return BadRequest();
        //    }

        //    _context.Entry(dgPayAttdataImportsetup).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!DgPayAttdataImportsetupExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/AttdataImportsetups
        //// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        //[HttpPost]
        //public async Task<ActionResult<DgPayAttdataImportsetup>> PostDgPayAttdataImportsetup(DgPayAttdataImportsetup dgPayAttdataImportsetup)
        //{
        //    _context.DgPayAttdataImportsetups.Add(dgPayAttdataImportsetup);
        //    await _context.SaveChangesAsync();

        //    return CreatedAtAction("GetDgPayAttdataImportsetup", new { id = dgPayAttdataImportsetup.Sl }, dgPayAttdataImportsetup);
        //}

        //// DELETE: api/AttdataImportsetups/5
        //[HttpDelete("{id}")]
        //public async Task<IActionResult> DeleteDgPayAttdataImportsetup(int id)
        //{
        //    var dgPayAttdataImportsetup = await _context.DgPayAttdataImportsetups.FindAsync(id);
        //    if (dgPayAttdataImportsetup == null)
        //    {
        //        return NotFound();
        //    }

        //    _context.DgPayAttdataImportsetups.Remove(dgPayAttdataImportsetup);
        //    await _context.SaveChangesAsync();

        //    return NoContent();
        //}

        //private bool DgPayAttdataImportsetupExists(int id)
        //{
        //    return _context.DgPayAttdataImportsetups.Any(e => e.Sl == id);
        //}

        private async Task<string> WriteFile(IFormFile file)
        {
            string filename = "";
            try
            {
                var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
                filename = file.FileName;
                //filename = DateTime.Now.Ticks.ToString() + extension;

                var filepath = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\Files");

                if (!Directory.Exists(filepath))
                {
                    Directory.CreateDirectory(filepath);
                }

                

                var exactpath = Path.Combine(Directory.GetCurrentDirectory(), "Upload\\Files", filename);
                using (var stream = new FileStream(exactpath, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            catch (Exception ex)
            {
            }
            return filename;
        }
    }
}
