using Microsoft.EntityFrameworkCore;

namespace SiteReceitas.Models
{
    public class AppDBContext:DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }
 
    }
}
