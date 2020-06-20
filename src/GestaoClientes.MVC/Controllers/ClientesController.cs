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
    public class ClientesController : Controller
    {
        private readonly DatabaseContext _context;

        public ClientesController(DatabaseContext context)
        {
            _context = context;
        }

        // GET: Clientes
        public async Task<IActionResult> Index()
        {
            //return View(await _context.Cliente.ToListAsync());
            var clientes = await (from x in _context.Cliente where x.Ativo == true select x).Include(x => x.TipoDeCliente).AsNoTracking().ToListAsync();

            return View(clientes);
        }

        // GET: Clientes/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente.Include(x => x.TipoDeCliente).AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // GET: Clientes/Create
        public IActionResult Create()
        {
            ViewBag.TipoDoCliente = new SelectList(_context.TiposDeClientes, "Id", "Descricao");

            return View();
        }

        // POST: Clientes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Sexo,Telefone,DataNascimento,Idade,CPF,Endereco,DataCadastro,Id")] Cliente cliente)
        {
            if (ModelState.IsValid)
            {
                var idade = DateTime.Now.Year - cliente.DataNascimento.Year;

                if(DateTime.Now.DayOfYear < cliente.DataNascimento.DayOfYear)
                {
                    idade--;
                }

                cliente.Idade = idade;

                _context.Add(cliente);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewBag.TipoDoCliente = new SelectList(_context.TiposDeClientes, "Id", "Descricao");

            return View(cliente);
        }

        // GET: Clientes/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente.FindAsync(id);
            if (cliente == null)
            {
                return NotFound();
            }

            ViewBag.TipoDoCliente = new SelectList(_context.TiposDeClientes, "Id", "Descricao");

            return View(cliente);
        }

        // POST: Clientes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Nome,Sexo,Telefone,DataNascimento,Idade,CPF,Endereco,DataCadastro,Id")] Cliente cliente)
        {
            if (id != cliente.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cliente);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClienteExists(cliente.Id))
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

            ViewBag.TipoDoCliente = new SelectList(_context.TiposDeClientes, "Id", "Descricao");

            return View(cliente);
        }

        // GET: Clientes/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cliente = await _context.Cliente.Include(x => x.TipoDeCliente).AsNoTracking()
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cliente == null)
            {
                return NotFound();
            }

            return View(cliente);
        }

        // POST: Clientes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var cliente = await _context.Cliente.FindAsync(id);
            cliente.Ativo = false;

            await _context.SaveChangesAsync();
            
            return RedirectToAction(nameof(Index));
        }

        private bool ClienteExists(Guid id)
        {
            return _context.Cliente.Any(e => e.Id == id);
        }
    }
}
