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
    public class AnketaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public AnketaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Anketa
        public async Task<IActionResult> Index()
        {
            return View(await _context.Anketa.ToListAsync());
        }

        // GET: Anketa/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anketa = await _context.Anketa
                .FirstOrDefaultAsync(m => m.ID == id);
            if (anketa == null)
            {
                return NotFound();
            }

            return View(anketa);
        }

        // GET: Anketa/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Anketa/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Text,mackeKojeSuUcestvovale")] Anketa anketa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(anketa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(anketa);
        }

        // GET: Anketa/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anketa = await _context.Anketa.FindAsync(id);
            if (anketa == null)
            {
                return NotFound();
            }
            return View(anketa);
        }

        // POST: Anketa/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Text,mackeKojeSuUcestvovale")] Anketa anketa)
        {
            if (id != anketa.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(anketa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AnketaExists(anketa.ID))
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
            return View(anketa);
        }

        // GET: Anketa/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var anketa = await _context.Anketa
                .FirstOrDefaultAsync(m => m.ID == id);
            if (anketa == null)
            {
                return NotFound();
            }

            return View(anketa);
        }

        // POST: Anketa/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var anketa = await _context.Anketa.FindAsync(id);
            _context.Anketa.Remove(anketa);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AnketaExists(int id)
        {
            return _context.Anketa.Any(e => e.ID == id);
        }
    }
}
