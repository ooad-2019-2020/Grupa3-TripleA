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
    public class VipKorisnikController : Controller
    {
        private readonly TripleContext _context;

        public VipKorisnikController(TripleContext context)
        {
            _context = context;
        }

        // GET: VipKorisnik
        public async Task<IActionResult> Index()
        {
            return View(await _context.VipKorisnik.ToListAsync());
        }

        public async Task<IActionResult> ZahtjevVipClanstva()
        {
            return View(await _context.VipKorisnik.ToListAsync());
        }

        // GET: VipKorisnik/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vipKorisnik = await _context.VipKorisnik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vipKorisnik == null)
            {
                return NotFound();
            }

            return View(vipKorisnik);
        }

        // GET: VipKorisnik/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: VipKorisnik/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OstvareniPopust,KorisnickoIme,DatumRodjenja,KrajVazenjaClanarine,Id,Lozinka,Ime,Prezime,Email")] VipKorisnik vipKorisnik)
        {
            if (ModelState.IsValid)
            {
                _context.Add(vipKorisnik);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vipKorisnik);
        }

        // GET: VipKorisnik/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vipKorisnik = await _context.VipKorisnik.FindAsync(id);
            if (vipKorisnik == null)
            {
                return NotFound();
            }
            return View(vipKorisnik);
        }

        // POST: VipKorisnik/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OstvareniPopust,KorisnickoIme,DatumRodjenja,KrajVazenjaClanarine,Id,Lozinka,Ime,Prezime,Email")] VipKorisnik vipKorisnik)
        {
            if (id != vipKorisnik.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vipKorisnik);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VipKorisnikExists(vipKorisnik.Id))
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
            return View(vipKorisnik);
        }

        // GET: VipKorisnik/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vipKorisnik = await _context.VipKorisnik
                .FirstOrDefaultAsync(m => m.Id == id);
            if (vipKorisnik == null)
            {
                return NotFound();
            }

            return View(vipKorisnik);
        }

        // POST: VipKorisnik/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vipKorisnik = await _context.VipKorisnik.FindAsync(id);
            _context.VipKorisnik.Remove(vipKorisnik);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VipKorisnikExists(int id)
        {
            return _context.VipKorisnik.Any(e => e.Id == id);
        }
    }
}
