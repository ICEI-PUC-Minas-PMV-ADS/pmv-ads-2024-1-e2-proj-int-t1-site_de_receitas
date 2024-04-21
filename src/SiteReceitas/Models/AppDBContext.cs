using Microsoft.EntityFrameworkCore;

namespace SiteReceitas.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        // TIRAR os // conforme cada classe for criada
        //public DbSet<Ingrediente> Ingredientes { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Ingrediente_Receita> Ingredientes_Receita { get; set; }
    }
}
