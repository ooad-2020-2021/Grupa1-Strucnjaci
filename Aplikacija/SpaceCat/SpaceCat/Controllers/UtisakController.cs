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
    public class UtisakController : Controller
    {
        private readonly SpaceCatContext _context;

        public UtisakController(SpaceCatContext context)
        {
            _context = context;
        }

        // GET: Utisak
        public async Task<IActionResult> Index()
        {
            return View(await _context.Utisak.ToListAsync());
        }

        // GET: Utisak/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utisak = await _context.Utisak
                .FirstOrDefaultAsync(m => m.ID == id);
            if (utisak == null)
            {
                return NotFound();
            }

            return View(utisak);
        }

        // GET: Utisak/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Utisak/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID")] Utisak utisak)
        {
            if (ModelState.IsValid)
            {
                _context.Add(utisak);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(utisak);
        }

        // GET: Utisak/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utisak = await _context.Utisak.FindAsync(id);
            if (utisak == null)
            {
                return NotFound();
            }
            return View(utisak);
        }

        // POST: Utisak/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID")] Utisak utisak)
        {
            if (id != utisak.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(utisak);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UtisakExists(utisak.ID))
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
            return View(utisak);
        }

        // GET: Utisak/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utisak = await _context.Utisak
                .FirstOrDefaultAsync(m => m.ID == id);
            if (utisak == null)
            {
                return NotFound();
            }

            return View(utisak);
        }

        // POST: Utisak/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var utisak = await _context.Utisak.FindAsync(id);
            _context.Utisak.Remove(utisak);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UtisakExists(int id)
        {
            return _context.Utisak.Any(e => e.ID == id);
        }
    }
}
