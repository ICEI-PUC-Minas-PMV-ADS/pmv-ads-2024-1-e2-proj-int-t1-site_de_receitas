using Microsoft.EntityFrameworkCore;

namespace SiteReceitas.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Ingrediente> Ingredientes { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Ingrediente_Receita> IngredientesReceita { get; set; }
    }
}
