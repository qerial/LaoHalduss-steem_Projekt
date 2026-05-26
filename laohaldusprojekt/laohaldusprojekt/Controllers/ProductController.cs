using laohaldusprojekt.Data;
using laohaldusprojekt.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace laohaldusprojekt.Controllers
{
    public class ProductController : Controller
    {
        private readonly LaohaldusContext _context;

        public ProductController(LaohaldusContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var model = _context.Products
                .Select(p => new ProductIndexViewModel
                {
                    Id = p.Id,
                    TooteNimi = p.TooteNimi,
                    Kogus = p.Kogus,
                    Hind = p.Hind,
                    Kategooria = p.Kategooria
                })
                .ToList();

            return View(model);
        }
    }
}
