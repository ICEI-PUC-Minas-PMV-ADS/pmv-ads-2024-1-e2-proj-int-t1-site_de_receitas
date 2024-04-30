using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using SiteReceitas.Models;
using System.Security.Claims;

namespace SiteReceitas.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly AppDBContext _context;

        public UsuarioController(AppDBContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Usuarios.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(usuario);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = await _context.Usuarios.FindAsync(id);

            return View(user);
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userData = await _context.Usuarios.FindAsync(id);

            if (userData == null)
            {
                return NotFound();
            }

             _context.Usuarios.Remove(userData);
            await _context.SaveChangesAsync();

            return View(userData);
        }


        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
       
        public async Task<IActionResult> Login(Usuario user)
        {
            var userData = await _context.Usuarios.FindAsync(user.Email);

            if (userData == null) {
                ViewBag.Message = "Usuário e/ou senha inválidos";
            }

            var isPasswordValid = BCrypt.Net.BCrypt.Verify(user.Senha, userData.Senha);

            if (isPasswordValid)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, userData.Email),
                    new Claim(ClaimTypes.Name, userData.Nome),
                    new Claim(ClaimTypes.NameIdentifier, userData.Id.ToString())
                };

                var userIdentity = new ClaimsIdentity(claims, "login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);

                var authProperties = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.UtcNow.ToLocalTime().AddHours(8),
                    IsPersistent = true,
                };

                await HttpContext.SignInAsync(principal, authProperties);

                Redirect("/");

            } else
            {
                ViewBag.Message = "Usuário e/ou senha inválidos";
            }

            return View();
        }



    }
}
