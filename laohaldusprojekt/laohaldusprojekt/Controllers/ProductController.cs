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
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductCreateViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var product = new Models.Product
                {
                    TooteNimi = vm.TooteNimi,
                    Kogus = vm.Kogus,
                    Hind = vm.Hind,
                    Kategooria = vm.Kategooria
                };
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(vm);
        }

       
        

    }
}
