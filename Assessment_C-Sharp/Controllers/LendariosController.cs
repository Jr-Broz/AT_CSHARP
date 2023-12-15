using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assessment_C_Sharp.Data;
using Assessment_C_Sharp.Models;

namespace Assessment_C_Sharp.Controllers
{
    public class LendariosController : Controller
    {
        private readonly PokemonDBContext _context;

        public LendariosController(PokemonDBContext context)
        {
            _context = context;
        }

        // GET: Lendarios
        public async Task<IActionResult> Index()
        {
              return _context.Lendarios != null ? 
                          View(await _context.Lendarios.ToListAsync()) :
                          Problem("Entity set 'PokemonDBContext.Lendarios'  is null.");
        }

        // GET: Lendarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Lendarios == null)
            {
                return NotFound();
            }

            var lendarios = await _context.Lendarios
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lendarios == null)
            {
                return NotFound();
            }

            return View(lendarios);
        }

        // GET: Lendarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Lendarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Nome,Tipo")] Lendarios lendarios)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lendarios);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lendarios);
        }

        // GET: Lendarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Lendarios == null)
            {
                return NotFound();
            }

            var lendarios = await _context.Lendarios.FindAsync(id);
            if (lendarios == null)
            {
                return NotFound();
            }
            return View(lendarios);
        }

        // POST: Lendarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Nome,Tipo")] Lendarios lendarios)
        {
            if (id != lendarios.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lendarios);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LendariosExists(lendarios.ID))
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
            return View(lendarios);
        }

        // GET: Lendarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Lendarios == null)
            {
                return NotFound();
            }

            var lendarios = await _context.Lendarios
                .FirstOrDefaultAsync(m => m.ID == id);
            if (lendarios == null)
            {
                return NotFound();
            }

            return View(lendarios);
        }

        // POST: Lendarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Lendarios == null)
            {
                return Problem("Entity set 'PokemonDBContext.Lendarios'  is null.");
            }
            var lendarios = await _context.Lendarios.FindAsync(id);
            if (lendarios != null)
            {
                _context.Lendarios.Remove(lendarios);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LendariosExists(int id)
        {
          return (_context.Lendarios?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
