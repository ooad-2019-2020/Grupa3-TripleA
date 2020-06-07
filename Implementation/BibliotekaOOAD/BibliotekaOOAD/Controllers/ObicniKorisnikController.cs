using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AspNetCoreMVC.Models;
using BibliotekaOOAD.Models;

namespace BibliotekaOOAD.Controllers
{
    public class ObicniKorisnikController : Controller
    {
        private readonly TripleContext _context;

        public ObicniKorisnikController(TripleContext context)
        {
            _context = context;
        }

        // GET: ObicniKorisnik
        public async Task<IActionResult> Index()
        {
            return View(await _context.ObicniKorisnik.ToListAsync());
        }

        public async Task<IActionResult> ZahtjevObicnogClanstva()
        {
            return View(await _context.ObicniKorisnik.ToListAsync());
        }

        // GET: ObicniKorisnik/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obicniKorisnik = await _context.ObicniKorisnik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (obicniKorisnik == null)
            {
                return NotFound();
            }

            return View(obicniKorisnik);
        }

        // GET: ObicniKorisnik/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ObicniKorisnik/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("KorisnickoIme,DatumRodjenja,KrajVazenjaClanarine,Id,Lozinka,Ime,Prezime,Email")] ObicniKorisnik obicniKorisnik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(obicniKorisnik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(obicniKorisnik);
        }

        // GET: ObicniKorisnik/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obicniKorisnik = await _context.ObicniKorisnik.FindAsync(id);
            if (obicniKorisnik == null)
            {
                return NotFound();
            }
            return View(obicniKorisnik);
        }

        // POST: ObicniKorisnik/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("KorisnickoIme,DatumRodjenja,KrajVazenjaClanarine,Id,Lozinka,Ime,Prezime,Email")] ObicniKorisnik obicniKorisnik)
        {
            if (id != obicniKorisnik.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(obicniKorisnik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ObicniKorisnikExists(obicniKorisnik.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(obicniKorisnik);
        }

        // GET: ObicniKorisnik/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obicniKorisnik = await _context.ObicniKorisnik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (obicniKorisnik == null)
            {
                return NotFound();
            }

            return View(obicniKorisnik);
        }

        // POST: ObicniKorisnik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var obicniKorisnik = await _context.ObicniKorisnik.FindAsync(id);
            _context.ObicniKorisnik.Remove(obicniKorisnik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ObicniKorisnikExists(int id)
        {
            return _context.ObicniKorisnik.Any(e => e.Id == id);
        }
    }
}
