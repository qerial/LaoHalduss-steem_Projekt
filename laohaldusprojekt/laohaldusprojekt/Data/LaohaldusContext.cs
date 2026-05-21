using laohaldusprojekt.Models;
using Microsoft.EntityFrameworkCore;

namespace laohaldusprojekt.Data
{
    public class LaohaldusContext : DbContext
    {
        public LaohaldusContext(DbContextOptions<LaohaldusContext> options) : base(options)
        { }
        public DbSet<Product> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");
        }
    }
}
