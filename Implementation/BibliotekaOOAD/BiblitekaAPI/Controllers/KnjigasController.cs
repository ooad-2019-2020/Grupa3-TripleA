using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BiblitekaAPI;

namespace BiblitekaAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KnjigasController : ControllerBase
    {
        private readonly BibliotekaDBContext _context;

        public KnjigasController(BibliotekaDBContext context)
        {
            _context = context;
        }

        // GET: api/Knjigas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Knjiga>>> GetKnjiga()
        {
            return await _context.Knjiga.ToListAsync();
        }

        // GET: api/Knjigas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Knjiga>> GetKnjiga(int id)
        {
            var knjiga = await _context.Knjiga.FindAsync(id);

            if (knjiga == null)
            {
                return NotFound();
            }

            return knjiga;
        }

        // PUT: api/Knjigas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutKnjiga(int id, Knjiga knjiga)
        {
            if (id != knjiga.Id)
            {
                return BadRequest();
            }

            _context.Entry(knjiga).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!KnjigaExists(id))
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

        // POST: api/Knjigas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Knjiga>> PostKnjiga(Knjiga knjiga)
        {
            _context.Knjiga.Add(knjiga);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetKnjiga", new { id = knjiga.Id }, knjiga);
        }

        // DELETE: api/Knjigas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Knjiga>> DeleteKnjiga(int id)
        {
            var knjiga = await _context.Knjiga.FindAsync(id);
            if (knjiga == null)
            {
                return NotFound();
            }

            _context.Knjiga.Remove(knjiga);
            await _context.SaveChangesAsync();

            return knjiga;
        }

        private bool KnjigaExists(int id)
        {
            return _context.Knjiga.Any(e => e.Id == id);
        }
    }
}
