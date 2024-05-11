using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
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

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(usuarioTeste usuario)
        {
            var dados = await _context.UsuariosTeste.FirstOrDefaultAsync(u => u.Email == usuario.Email);

            if (dados == null)
            {
               ViewBag.Message = "Email e/ou senha inválidos";
               return View();
            }
            bool senhaValida = BCrypt.Net.BCrypt.Verify(usuario.Senha, dados.Senha);

            if (senhaValida)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, dados.Nome),
                    new Claim(ClaimTypes.Email, dados.Email.ToString()),
                    new Claim(ClaimTypes.Role, dados.Perfil.ToString())
                };

                var identidade = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(identidade);

                var propriedades = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.AddHours(8),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, propriedades);

                return Redirect("/");
            }
            else
            {
                ViewBag.Mensagem = "Email e/ou senha inválidos";
            }

            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return Redirect("/");
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
                usuarioTeste.Senha = BCrypt.Net.BCrypt.HashPassword(usuarioTeste.Senha);
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
                    usuarioTeste.Senha = BCrypt.Net.BCrypt.HashPassword(usuarioTeste.Senha);
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
