using laohaldusprojekt.Models;
using Microsoft.EntityFrameworkCore;

namespace laohaldusprojekt.Data
{
    public class LaohaldusContext : DbContext
    {
        public LaohaldusContext(DbContextOptions<LaohaldusContext> options) : base(options)
        { }
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().ToTable("Product");

            // Seed initial data so Update-Database (EF migrations) will insert these rows
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, TooteNimi = "Lihapihvid, MAKS&MOORITS", Kogus = 4, Hind = 3.55, Kategooria = "Liha- ja kalatooted" },
                new Product { Id = 2, TooteNimi = "Kodune šašlõkk", Kogus = 2, Hind = 5.0, Kategooria = "Liha- ja kalatooted" },
                new Product { Id = 3, TooteNimi = "Juustupulgad Pik-Nik", Kogus = 5, Hind = 3.19, Kategooria = "Piimatooted" }
            );
        }
    }
}
