using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Seminari.Models;

namespace Seminari.Controllers
{
    public class SeminarsController : Controller
    {
        private readonly Baza_SeminariContext _context;

        public SeminarsController(Baza_SeminariContext context)
        {
            _context = context;
        }

        // GET: Seminars
        public async Task<IActionResult> Index()
        {
            var baza_SeminariContext = _context.Seminars.Include(s => s.IdZaposlenikNavigation);
            return View(await baza_SeminariContext.ToListAsync());
        }

        // GET: Seminars/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seminar = await _context.Seminars
                .Include(s => s.IdZaposlenikNavigation)
                .FirstOrDefaultAsync(m => m.IdSeminar == id);
            if (seminar == null)
            {
                return NotFound();
            }

            return View(seminar);
        }

        // GET: Seminars/Create
        public IActionResult Create()
        {
            ViewData["IdZaposlenik"] = new SelectList(_context.Zaposleniks, "IdZaposlenik", "ImePrezime", "Prezime");
            return View();
        }

        // POST: Seminars/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdSeminar,Naziv,Opis,Datum,Popunjen,IdZaposlenik")] Seminar seminar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(seminar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdZaposlenik"] = new SelectList(_context.Zaposleniks, "IdZaposlenik", "ImePrezime", seminar.IdZaposlenik);
            return View(seminar);
        }

        // GET: Seminars/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seminar = await _context.Seminars.FindAsync(id);
            if (seminar == null)
            {
                return NotFound();
            }
            ViewData["IdZaposlenik"] = new SelectList(_context.Zaposleniks, "IdZaposlenik", "ImePrezime", seminar.IdZaposlenik);
            return View(seminar);
        }

        // POST: Seminars/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdSeminar,Naziv,Opis,Datum,Popunjen,IdZaposlenik")] Seminar seminar)
        {
            if (id != seminar.IdSeminar)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(seminar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SeminarExists(seminar.IdSeminar))
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
            ViewData["IdZaposlenik"] = new SelectList(_context.Zaposleniks, "IdZaposlenik", "ImePrezime", seminar.IdZaposlenik);
            return View(seminar);
        }

        // GET: Seminars/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var seminar = await _context.Seminars
                .Include(s => s.IdZaposlenikNavigation)
                .FirstOrDefaultAsync(m => m.IdSeminar == id);
            if (seminar == null)
            {
                return NotFound();
            }

            return View(seminar);
        }

        // POST: Seminars/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var seminar = await _context.Seminars.FindAsync(id);
            _context.Seminars.Remove(seminar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SeminarExists(int id)
        {
            return _context.Seminars.Any(e => e.IdSeminar == id);
        }
    }
}
