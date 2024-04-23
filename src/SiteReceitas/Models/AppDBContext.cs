using Microsoft.EntityFrameworkCore;
using SiteReceitas.Models;

namespace SiteReceitas.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
        public DbSet<SiteReceitas.Models.Receita> Receita { get; set; }
 
    }
}
