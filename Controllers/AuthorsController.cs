using Library.Data;
using Library.Models;
using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class AuthorsController : Controller
    {
        ApplicationDbContext _context;
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LogInView()
        {
            return View("LogIn");
        }
        public IActionResult LogIn(LogIn user)
        {
            if (ModelState.IsValid == true)
            {
                Author author = _context.Authors.FirstOrDefault(A => A.Email == user.Email);

                if (author.Email == user.Email && author.Password == user.Password)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View("LogIn", user);
                }
                
            }
            else
            {
                //ViewBag.AllDepartments = _context.Departments.ToList();
                return View("LogIn", user);
            }
        }
    }
}
