using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BiblitekaAPI;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
        public async Task<ActionResult<List<Knjiga>>> GetKnjiga()
        {
            string apiUrl = "https://api.nytimes.com/";
            List<Knjiga> knjige = new List<Knjiga>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage Res = await client.GetAsync("/svc/books/v3/lists.json?list-name=hardcover-fiction&api-key=ywXWXpAo14Rj2Xc9GYZifOIqhVt7hzDy");

                //Provjera da li je rezultat uspješan
                if (Res.IsSuccessStatusCode)
                {
                    var response = Res.Content.ReadAsStringAsync().Result; //string svega napravljen
                    JObject joResponse = JObject.Parse(response);
                    JArray results = (JArray)joResponse["results"];
                    for(int i=0; i< results.Count; i++) {
                        JArray array = (JArray)results[i]["book_details"];
                        Knjiga knjiga = new Knjiga();
                        knjiga.Naslov = (string)(array[0]["title"].ToString());
                        knjiga.Autor = (string)(array[0]["author"].ToString());
                        knjiga.Opis = (string)(array[0]["description"].ToString());
                        knjige.Add(knjiga);
                    }

                    foreach(Knjiga k in knjige) {
                        _context.Add(k);
                        await _context.SaveChangesAsync();
                    }
                }
                return await _context.Knjiga.ToListAsync();
            }
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
