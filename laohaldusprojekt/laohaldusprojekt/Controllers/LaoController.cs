using laohaldusprojekt.Data;
using Microsoft.AspNetCore.Mvc;

namespace laohaldusprojekt.Controllers
{
    public class LaoController
    {

        private readonly LaohaldusContext _context;

        public LaoController
            (
                LaohaldusContext context
            )
        {
            _context = context;
        }
    }
}
