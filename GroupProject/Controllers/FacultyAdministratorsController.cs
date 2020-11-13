using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GroupProject.Models;

namespace GroupProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacultyAdministratorsController : ControllerBase
    {
        private readonly ObeDbContext _context;

        public FacultyAdministratorsController(ObeDbContext context)
        {
            _context = context;
        }

        // GET: api/FacultyAdministrators
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FacultyAdministrator>>> GetAdmins()
        {
            return await _context.Admins.ToListAsync();
        }

        // GET: api/FacultyAdministrators/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FacultyAdministrator>> GetFacultyAdministrator(string id)
        {
            var facultyAdministrator = await _context.Admins.FindAsync(id);

            if (facultyAdministrator == null)
            {
                return NotFound();
            }

            return facultyAdministrator;
        }

        // PUT: api/FacultyAdministrators/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFacultyAdministrator(string id, FacultyAdministrator facultyAdministrator)
        {
            if (id != facultyAdministrator.AdminId)
            {
                return BadRequest();
            }

            _context.Entry(facultyAdministrator).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacultyAdministratorExists(id))
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

        // POST: api/FacultyAdministrators
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<FacultyAdministrator>> PostFacultyAdministrator(FacultyAdministrator facultyAdministrator)
        {
            _context.Admins.Add(facultyAdministrator);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (FacultyAdministratorExists(facultyAdministrator.AdminId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetFacultyAdministrator", new { id = facultyAdministrator.AdminId }, facultyAdministrator);
        }

        // DELETE: api/FacultyAdministrators/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<FacultyAdministrator>> DeleteFacultyAdministrator(string id)
        {
            var facultyAdministrator = await _context.Admins.FindAsync(id);
            if (facultyAdministrator == null)
            {
                return NotFound();
            }

            _context.Admins.Remove(facultyAdministrator);
            await _context.SaveChangesAsync();

            return facultyAdministrator;
        }

        private bool FacultyAdministratorExists(string id)
        {
            return _context.Admins.Any(e => e.AdminId == id);
        }
    }
}
