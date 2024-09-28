using Microsoft.AspNetCore.Mvc;
using Healing_Hands.Data; // Add this using directive
using Healing_Hands.Models; // Add this using directive

namespace Healing_Hands.Controllers
{
    public class DonationsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public DonationsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var donations = _context.Donations.ToList();
            return View(donations);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Donation donation)
        {
            if (ModelState.IsValid)
            {
                _context.Donations.Add(donation);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View(donation);
        }
    }
}
