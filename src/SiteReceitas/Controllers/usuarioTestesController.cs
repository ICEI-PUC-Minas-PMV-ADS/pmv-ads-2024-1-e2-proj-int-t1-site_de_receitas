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
    public class usuarioTestesController : Controller
    {
        private readonly AppDBContext _context;

        public usuarioTestesController(AppDBContext context)
        {
            _context = context;
        }

        // GET: usuarioTestes
        public async Task<IActionResult> Index()
        {
            return View(await _context.UsuariosTeste.ToListAsync());
        }

        // GET: usuarioTestes/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioTeste = await _context.UsuariosTeste
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuarioTeste == null)
            {
                return NotFound();
            }

            return View(usuarioTeste);
        }

        // GET: usuarioTestes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: usuarioTestes/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Email,Senha,Perfil")] usuarioTeste usuarioTeste)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuarioTeste);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuarioTeste);
        }

        // GET: usuarioTestes/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioTeste = await _context.UsuariosTeste.FindAsync(id);
            if (usuarioTeste == null)
            {
                return NotFound();
            }
            return View(usuarioTeste);
        }

        // POST: usuarioTestes/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Email,Senha,Perfil")] usuarioTeste usuarioTeste)
        {
            if (id != usuarioTeste.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuarioTeste);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!usuarioTesteExists(usuarioTeste.Id))
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
            return View(usuarioTeste);
        }

        // GET: usuarioTestes/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var usuarioTeste = await _context.UsuariosTeste
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuarioTeste == null)
            {
                return NotFound();
            }

            return View(usuarioTeste);
        }

        // POST: usuarioTestes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuarioTeste = await _context.UsuariosTeste.FindAsync(id);
            if (usuarioTeste != null)
            {
                _context.UsuariosTeste.Remove(usuarioTeste);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool usuarioTesteExists(int id)
        {
            return _context.UsuariosTeste.Any(e => e.Id == id);
        }
    }
}
