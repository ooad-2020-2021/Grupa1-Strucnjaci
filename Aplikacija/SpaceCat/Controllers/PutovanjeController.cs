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
    public class PutovanjeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PutovanjeController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Putovanje
        public async Task<IActionResult> Index()
        {
            return View(await _context.Putovanje.ToListAsync());
        }

        // GET: Putovanje/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var putovanje = await _context.Putovanje
                .FirstOrDefaultAsync(m => m.ID == id);
            if (putovanje == null)
            {
                return NotFound();
            }

            return View(putovanje);
        }

        // GET: Putovanje/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Putovanje/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,VrijemePolaska,KrajPutovanja,mackeZaPutovanje")] Putovanje putovanje)
        {
            if (ModelState.IsValid)
            {
                _context.Add(putovanje);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(putovanje);
        }

        // GET: Putovanje/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var putovanje = await _context.Putovanje.FindAsync(id);
            if (putovanje == null)
            {
                return NotFound();
            }
            return View(putovanje);
        }

        // POST: Putovanje/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,VrijemePolaska,KrajPutovanja,mackeZaPutovanje")] Putovanje putovanje)
        {
            if (id != putovanje.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(putovanje);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PutovanjeExists(putovanje.ID))
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
            return View(putovanje);
        }

        // GET: Putovanje/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var putovanje = await _context.Putovanje
                .FirstOrDefaultAsync(m => m.ID == id);
            if (putovanje == null)
            {
                return NotFound();
            }

            return View(putovanje);
        }

        // POST: Putovanje/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var putovanje = await _context.Putovanje.FindAsync(id);
            _context.Putovanje.Remove(putovanje);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PutovanjeExists(int id)
        {
            return _context.Putovanje.Any(e => e.ID == id);
        }
    }
}
