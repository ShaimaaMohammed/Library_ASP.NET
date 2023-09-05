using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Library.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context,  ILogger<HomeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        public IActionResult Index(string? search)
        {
            ViewBag.Search = search;
            if (string.IsNullOrEmpty(search))
            {
                return View("Index", _context.Books.ToList());
            }
            else
            {

                return View("Index", _context.Books.Where(d => d.Title.Contains(search)).ToList());
            }
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}