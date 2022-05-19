using Entities.Domain;
using Microsoft.EntityFrameworkCore;

namespace Entities.DataContext
{
    public class WebApiDbContext : DbContext
    {
        public WebApiDbContext() { }

        public WebApiDbContext(DbContextOptions<WebApiDbContext> options)
            :base(options)
        {
        }

        public DbSet<Auto> Autos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseInMemoryDatabase("Autos_DB");
        }
    }
}
