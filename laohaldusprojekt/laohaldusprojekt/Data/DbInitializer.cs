using laohaldusprojekt.Models;

namespace laohaldusprojekt.Data
{
    public class DbInitializer
    {
        public static void Initialize(LaohaldusContext context)
        {
            context.Database.EnsureCreated();
            if (context.Students.Any())
            {
                return;   
            }
            var products = new Product[]
            {
            new Product { TooteNimi="Lihapihvid, MAKS&MOORITS", Kogus=4, Hind=3.55, Kategooria="Liha- ja kalatooted" },
            new Product { TooteNimi="Kodune šašlõkk", Kogus=2, Hind=5, Kategooria="Liha- ja kalatooted" },
            new Product { TooteNimi="Juustupulgad Pik-Nik", Kogus=5, Hind=3.19, Kategooria="Piimatooted" }
            };
            foreach (Product s in products)
            {
                context.Students.Add(s);
            }
            context.SaveChanges();
        }
    }
}
