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
    public class DSPhimController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DSPhimController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: DSPhim
        public async Task<IActionResult> Index()
        {
              return View(await _context.DSPhims.ToListAsync());
        }

        // GET: DSPhim/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.DSPhims == null)
            {
                return NotFound();
            }

            var dSPhim = await _context.DSPhims
                .FirstOrDefaultAsync(m => m.PhimId == id);
            if (dSPhim == null)
            {
                return NotFound();
            }

            return View(dSPhim);
        }

        // GET: DSPhim/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: DSPhim/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PhimId,TenPhim,ThoiLuong,Type")] DSPhim dSPhim)
        {
            if (ModelState.IsValid)
            {
                _context.Add(dSPhim);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(dSPhim);
        }

        // GET: DSPhim/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.DSPhims == null)
            {
                return NotFound();
            }

            var dSPhim = await _context.DSPhims.FindAsync(id);
            if (dSPhim == null)
            {
                return NotFound();
            }
            return View(dSPhim);
        }

        // POST: DSPhim/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PhimId,TenPhim,ThoiLuong,Type")] DSPhim dSPhim)
        {
            if (id != dSPhim.PhimId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(dSPhim);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DSPhimExists(dSPhim.PhimId))
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
            return View(dSPhim);
        }

        // GET: DSPhim/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.DSPhims == null)
            {
                return NotFound();
            }

            var dSPhim = await _context.DSPhims
                .FirstOrDefaultAsync(m => m.PhimId == id);
            if (dSPhim == null)
            {
                return NotFound();
            }

            return View(dSPhim);
        }

        // POST: DSPhim/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.DSPhims == null)
            {
                return Problem("Entity set 'ApplicationDbContext.DSPhims'  is null.");
            }
            var dSPhim = await _context.DSPhims.FindAsync(id);
            if (dSPhim != null)
            {
                _context.DSPhims.Remove(dSPhim);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DSPhimExists(int id)
        {
          return _context.DSPhims.Any(e => e.PhimId == id);
        }
    }
}
