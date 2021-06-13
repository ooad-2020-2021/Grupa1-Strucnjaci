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
    public class UtisakMackaController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UtisakMackaController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: UtisakMacka
        public async Task<IActionResult> Index()
        {
            return View(await _context.UtisakMacka.ToListAsync());
        }

        // GET: UtisakMacka/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utisakMacka = await _context.UtisakMacka
                .FirstOrDefaultAsync(m => m.ID == id);
            if (utisakMacka == null)
            {
                return NotFound();
            }

            return View(utisakMacka);
        }

        // GET: UtisakMacka/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UtisakMacka/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ImeMacke,Slika,OdabranaRanije,Text,Ocjena")] UtisakMacka utisakMacka)
        {
            if (ModelState.IsValid)
            {
                _context.Add(utisakMacka);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(utisakMacka);
        }

        // GET: UtisakMacka/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utisakMacka = await _context.UtisakMacka.FindAsync(id);
            if (utisakMacka == null)
            {
                return NotFound();
            }
            return View(utisakMacka);
        }

        // POST: UtisakMacka/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ImeMacke,Slika,OdabranaRanije,Text,Ocjena")] UtisakMacka utisakMacka)
        {
            if (id != utisakMacka.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(utisakMacka);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UtisakMackaExists(utisakMacka.ID))
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
            return View(utisakMacka);
        }

        // GET: UtisakMacka/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var utisakMacka = await _context.UtisakMacka
                .FirstOrDefaultAsync(m => m.ID == id);
            if (utisakMacka == null)
            {
                return NotFound();
            }

            return View(utisakMacka);
        }

        // POST: UtisakMacka/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var utisakMacka = await _context.UtisakMacka.FindAsync(id);
            _context.UtisakMacka.Remove(utisakMacka);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UtisakMackaExists(int id)
        {
            return _context.UtisakMacka.Any(e => e.ID == id);
        }
    }
}
