using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SmoothboardStylers.Data;
using SmoothboardStylers.Models;
using Microsoft.AspNetCore.Authorization;

namespace SmoothboardStylers.Controllers
{
    [Authorize]
    public class MaterialenController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MaterialenController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Materialen
        public async Task<IActionResult> Index()
        {
            return View(await _context.Materiaal.ToListAsync());
        }

        // GET: Materialen/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materiaal = await _context.Materiaal
                .FirstOrDefaultAsync(m => m.Id == id);
            if (materiaal == null)
            {
                return NotFound();
            }

            return View(materiaal);
        }

        // GET: Materialen/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Materialen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naam")] Materiaal materiaal)
        {
            if (ModelState.IsValid)
            {
                _context.Add(materiaal);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(materiaal);
        }

        // GET: Materialen/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materiaal = await _context.Materiaal.FindAsync(id);
            if (materiaal == null)
            {
                return NotFound();
            }
            return View(materiaal);
        }

        // POST: Materialen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naam")] Materiaal materiaal)
        {
            if (id != materiaal.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(materiaal);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MateriaalExists(materiaal.Id))
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
            return View(materiaal);
        }

        // GET: Materialen/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var materiaal = await _context.Materiaal
                .FirstOrDefaultAsync(m => m.Id == id);
            if (materiaal == null)
            {
                return NotFound();
            }

            return View(materiaal);
        }

        // POST: Materialen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var materiaal = await _context.Materiaal.FindAsync(id);
            _context.Materiaal.Remove(materiaal);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MateriaalExists(int id)
        {
            return _context.Materiaal.Any(e => e.Id == id);
        }
    }
}
