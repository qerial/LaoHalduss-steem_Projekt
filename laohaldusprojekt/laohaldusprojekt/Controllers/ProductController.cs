using laohaldusprojekt.Data;
using laohaldusprojekt.Models;
using laohaldusprojekt.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System.Data.Entity.Infrastructure;
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

        public async Task<IActionResult> Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            var model = new ProductDeleteViewModel
            {
                Id = product.Id,
                TooteNimi = product.TooteNimi,
                Kogus = product.Kogus,
                Hind = product.Hind,
                Kategooria = product.Kategooria
            };
            return View(model);
        }

        public async Task<IActionResult> DeletePost(int id)
        {
            try
            {
                Product delete = new Product()
                {
                    Id = id,
                };

                _context.Products.Remove(delete);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch (DbUpdateException)
            {
                return RedirectToAction(nameof(Delete), new { id = id, saveChangesError = true });
                throw;
            }

            return RedirectToAction(nameof(Delete));
        }




    }
}
