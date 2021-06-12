using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SpaceCat;
using SpaceCat.Data;

namespace SpaceCat.Controllers
{
    public class DestinacijaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DestinacijaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Destinacija
        public async Task<IActionResult> Index()
        {
            return View(await _context.Destinacija.ToListAsync());
        }

        // GET: Destinacija/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destinacija = await _context.Destinacija
                .FirstOrDefaultAsync(m => m.ID == id);
            if (destinacija == null)
            {
                return NotFound();
            }

            return View(destinacija);
        }

        // GET: Destinacija/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Destinacija/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Paket,Naziv,Slika")] Destinacija destinacija)
        {
            if (ModelState.IsValid)
            {
                _context.Add(destinacija);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(destinacija);
        }

        // GET: Destinacija/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destinacija = await _context.Destinacija.FindAsync(id);
            if (destinacija == null)
            {
                return NotFound();
            }
            return View(destinacija);
        }

        // POST: Destinacija/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Paket,Naziv,Slika")] Destinacija destinacija)
        {
            if (id != destinacija.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(destinacija);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DestinacijaExists(destinacija.ID))
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
            return View(destinacija);
        }

        // GET: Destinacija/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var destinacija = await _context.Destinacija
                .FirstOrDefaultAsync(m => m.ID == id);
            if (destinacija == null)
            {
                return NotFound();
            }

            return View(destinacija);
        }

        // POST: Destinacija/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var destinacija = await _context.Destinacija.FindAsync(id);
            _context.Destinacija.Remove(destinacija);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DestinacijaExists(int id)
        {
            return _context.Destinacija.Any(e => e.ID == id);
        }
    }
}
