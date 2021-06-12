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
    public class SlikaNovostiController : Controller
    {
        private readonly ApplicationDbContext _context;

        public SlikaNovostiController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: SlikaNovosti
        public async Task<IActionResult> Index()
        {
            return View(await _context.SlikaNovosti.ToListAsync());
        }

        // GET: SlikaNovosti/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slikaNovosti = await _context.SlikaNovosti
                .FirstOrDefaultAsync(m => m.ID == id);
            if (slikaNovosti == null)
            {
                return NotFound();
            }

            return View(slikaNovosti);
        }

        // GET: SlikaNovosti/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: SlikaNovosti/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,stringSlike,idNovosti")] SlikaNovosti slikaNovosti)
        {
            if (ModelState.IsValid)
            {
                _context.Add(slikaNovosti);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(slikaNovosti);
        }

        // GET: SlikaNovosti/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slikaNovosti = await _context.SlikaNovosti.FindAsync(id);
            if (slikaNovosti == null)
            {
                return NotFound();
            }
            return View(slikaNovosti);
        }

        // POST: SlikaNovosti/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("ID,stringSlike,idNovosti")] SlikaNovosti slikaNovosti)
        {
            if (id != slikaNovosti.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(slikaNovosti);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SlikaNovostiExists(slikaNovosti.ID))
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
            return View(slikaNovosti);
        }

        // GET: SlikaNovosti/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var slikaNovosti = await _context.SlikaNovosti
                .FirstOrDefaultAsync(m => m.ID == id);
            if (slikaNovosti == null)
            {
                return NotFound();
            }

            return View(slikaNovosti);
        }

        // POST: SlikaNovosti/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var slikaNovosti = await _context.SlikaNovosti.FindAsync(id);
            _context.SlikaNovosti.Remove(slikaNovosti);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SlikaNovostiExists(string id)
        {
            return _context.SlikaNovosti.Any(e => e.ID == id);
        }
    }
}
