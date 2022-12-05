using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExpenseTracker.Models;

namespace ExpenseTracker.Controllers
{
    public class LichController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LichController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Lich
        public async Task<IActionResult> Index()
        {
              return View(await _context.Lichs.ToListAsync());
        }

        // GET: Lich/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Lichs == null)
            {
                return NotFound();
            }

            var lich = await _context.Lichs
                .FirstOrDefaultAsync(m => m.LichId == id);
            if (lich == null)
            {
                return NotFound();
            }

            return View(lich);
        }

        // GET: Lich/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lich/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("LichId,TenPhim,TenRap,Giocongchieu,Type")] Lich lich)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lich);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lich);
        }

        // GET: Lich/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Lichs == null)
            {
                return NotFound();
            }

            var lich = await _context.Lichs.FindAsync(id);
            if (lich == null)
            {
                return NotFound();
            }
            return View(lich);
        }

        // POST: Lich/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LichId,TenPhim,TenRap,Giocongchieu,Type")] Lich lich)
        {
            if (id != lich.LichId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lich);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LichExists(lich.LichId))
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
            return View(lich);
        }

        // GET: Lich/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Lichs == null)
            {
                return NotFound();
            }

            var lich = await _context.Lichs
                .FirstOrDefaultAsync(m => m.LichId == id);
            if (lich == null)
            {
                return NotFound();
            }

            return View(lich);
        }

        // POST: Lich/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Lichs == null)
            {
                return Problem("Entity set 'ApplicationDbContext.Lichs'  is null.");
            }
            var lich = await _context.Lichs.FindAsync(id);
            if (lich != null)
            {
                _context.Lichs.Remove(lich);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LichExists(int id)
        {
          return _context.Lichs.Any(e => e.LichId == id);
        }
    }
}
