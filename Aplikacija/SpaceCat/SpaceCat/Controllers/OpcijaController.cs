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
    public class OpcijaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public OpcijaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Opcija
        public async Task<IActionResult> Index()
        {
            return View(await _context.Opcija.ToListAsync());
        }

        // GET: Opcija/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcija = await _context.Opcija
                .FirstOrDefaultAsync(m => m.IdOpcije == id);
            if (opcija == null)
            {
                return NotFound();
            }

            return View(opcija);
        }

        // GET: Opcija/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Opcija/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdOpcije,TextOpcije,GlasoviOpcije,IdAnkete")] Opcija opcija)
        {
            if (ModelState.IsValid)
            {
                _context.Add(opcija);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(opcija);
        }

        // GET: Opcija/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcija = await _context.Opcija.FindAsync(id);
            if (opcija == null)
            {
                return NotFound();
            }
            return View(opcija);
        }

        // POST: Opcija/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("IdOpcije,TextOpcije,GlasoviOpcije,IdAnkete")] Opcija opcija)
        {
            if (id != opcija.IdOpcije)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(opcija);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OpcijaExists(opcija.IdOpcije))
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
            return View(opcija);
        }

        // GET: Opcija/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var opcija = await _context.Opcija
                .FirstOrDefaultAsync(m => m.IdOpcije == id);
            if (opcija == null)
            {
                return NotFound();
            }

            return View(opcija);
        }

        // POST: Opcija/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var opcija = await _context.Opcija.FindAsync(id);
            _context.Opcija.Remove(opcija);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OpcijaExists(string id)
        {
            return _context.Opcija.Any(e => e.IdOpcije == id);
        }
    }
}
