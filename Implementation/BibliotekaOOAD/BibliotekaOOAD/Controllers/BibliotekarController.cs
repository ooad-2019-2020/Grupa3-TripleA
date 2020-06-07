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
    public class BibliotekarController : Controller
    {
        private readonly TripleContext _context;

        public BibliotekarController(TripleContext context)
        {
            _context = context;
        }

        // GET: Bibliotekar
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bibliotekar.ToListAsync());
        }

        public IActionResult BibliotekarWorkspace()
        {
            return View();
        }

        // GET: Bibliotekar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bibliotekar = await _context.Bibliotekar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bibliotekar == null)
            {
                return NotFound();
            }

            return View(bibliotekar);
        }

        // GET: Bibliotekar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bibliotekar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Lozinka,Ime,Prezime,Email")] Bibliotekar bibliotekar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bibliotekar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bibliotekar);
        }

        // GET: Bibliotekar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bibliotekar = await _context.Bibliotekar.FindAsync(id);
            if (bibliotekar == null)
            {
                return NotFound();
            }
            return View(bibliotekar);
        }

        // POST: Bibliotekar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Lozinka,Ime,Prezime,Email")] Bibliotekar bibliotekar)
        {
            if (id != bibliotekar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bibliotekar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BibliotekarExists(bibliotekar.Id))
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
            return View(bibliotekar);
        }

        // GET: Bibliotekar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bibliotekar = await _context.Bibliotekar
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bibliotekar == null)
            {
                return NotFound();
            }

            return View(bibliotekar);
        }

        // POST: Bibliotekar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bibliotekar = await _context.Bibliotekar.FindAsync(id);
            _context.Bibliotekar.Remove(bibliotekar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BibliotekarExists(int id)
        {
            return _context.Bibliotekar.Any(e => e.Id == id);
        }
    }
}
