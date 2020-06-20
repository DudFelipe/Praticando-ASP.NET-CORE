using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GestaoClientes.Data;
using GestaoClientes.Domain.Models;

namespace GestaoClientes.MVC.Controllers
{
    public class TiposDeClientesController : Controller
    {
        private readonly DatabaseContext _context;

        public TiposDeClientesController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: TiposDeClientes
        public async Task<IActionResult> Index()
        {
            return View(await _context.TiposDeClientes.ToListAsync());
        }

        // GET: TiposDeClientes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposDeClientes = await _context.TiposDeClientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tiposDeClientes == null)
            {
                return NotFound();
            }

            return View(tiposDeClientes);
        }

        // GET: TiposDeClientes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TiposDeClientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Descricao,Id")] TiposDeClientes tiposDeClientes)
        {
            if (ModelState.IsValid)
            {
                tiposDeClientes.Id = Guid.NewGuid();
                _context.Add(tiposDeClientes);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tiposDeClientes);
        }

        // GET: TiposDeClientes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposDeClientes = await _context.TiposDeClientes.FindAsync(id);
            if (tiposDeClientes == null)
            {
                return NotFound();
            }
            return View(tiposDeClientes);
        }

        // POST: TiposDeClientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Descricao,Id")] TiposDeClientes tiposDeClientes)
        {
            if (id != tiposDeClientes.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tiposDeClientes);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TiposDeClientesExists(tiposDeClientes.Id))
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
            return View(tiposDeClientes);
        }

        // GET: TiposDeClientes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tiposDeClientes = await _context.TiposDeClientes
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tiposDeClientes == null)
            {
                return NotFound();
            }

            return View(tiposDeClientes);
        }

        // POST: TiposDeClientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var tiposDeClientes = await _context.TiposDeClientes.FindAsync(id);
            _context.TiposDeClientes.Remove(tiposDeClientes);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TiposDeClientesExists(Guid id)
        {
            return _context.TiposDeClientes.Any(e => e.Id == id);
        }
    }
}
