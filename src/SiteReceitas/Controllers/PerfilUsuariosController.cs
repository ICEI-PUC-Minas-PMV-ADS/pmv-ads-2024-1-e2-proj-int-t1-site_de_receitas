using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SiteReceitas.Models;

namespace SiteReceitas.Controllers
{
    public class PerfilUsuariosController : Controller
    {
        private readonly AppDBContext _context;

        public PerfilUsuariosController(AppDBContext context)
        {
            _context = context;
        }

        // GET: PerfilUsuarios
        public async Task<IActionResult> Index()
        {
            return View(await _context.PerfilUsuario.ToListAsync());
        }

        // GET: PerfilUsuarios/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perfilUsuario = await _context.PerfilUsuario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (perfilUsuario == null)
            {
                return NotFound();
            }

            return View(perfilUsuario);
        }

        // GET: PerfilUsuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PerfilUsuarios/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,SobreNome,Email,Senha,TipoPerfil")] PerfilUsuario perfilUsuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(perfilUsuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(perfilUsuario);
        }

        // GET: PerfilUsuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perfilUsuario = await _context.PerfilUsuario.FindAsync(id);
            if (perfilUsuario == null)
            {
                return NotFound();
            }
            return View(perfilUsuario);
        }

        // POST: PerfilUsuarios/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,SobreNome,Email,Senha,TipoPerfil")] PerfilUsuario perfilUsuario)
        {
            if (id != perfilUsuario.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(perfilUsuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PerfilUsuarioExists(perfilUsuario.Id))
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
            return View(perfilUsuario);
        }

        // GET: PerfilUsuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perfilUsuario = await _context.PerfilUsuario
                .FirstOrDefaultAsync(m => m.Id == id);
            if (perfilUsuario == null)
            {
                return NotFound();
            }

            return View(perfilUsuario);
        }

        // POST: PerfilUsuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var perfilUsuario = await _context.PerfilUsuario.FindAsync(id);
            if (perfilUsuario != null)
            {
                _context.PerfilUsuario.Remove(perfilUsuario);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PerfilUsuarioExists(int id)
        {
            return _context.PerfilUsuario.Any(e => e.Id == id);
        }
    }
}
