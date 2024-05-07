using SiteReceitas.Models;
using Microsoft.AspNetCore.Mvc;

namespace SiteReceitas.Controllers
{
    public class ReceitasController : Controller
    {
        private readonly AppDBContext _context;

        public ReceitasController(AppDBContext context)
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

        public async Task<IActionResult> Create(Receita receita, IFormFile image)
        {
             if (ModelState.IsValid)
            {

                if (image != null && image.Length > 0)
                {

                    using (var memoryStream = new MemoryStream())
                    {
                        await image.CopyToAsync(memoryStream);
                        receita.Imagem = memoryStream.ToArray();
                    }
                }

                _context.Receitas.Add(receita);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View();
        }
        
    }
}
