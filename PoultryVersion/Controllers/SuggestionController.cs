/*using Microsoft.AspNetCore.Mvc;
using PoultryVersion.Models;

namespace PoultryVersion.Controllers
{
    public class SuggestionController : Controller
    {
        private readonly PoultryUpdatedContext _context;

        public SuggestionController(PoultryUpdatedContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var Entity = _context.Suggestions.ToList();
            return View(Entity);
        }
    }
}
*/