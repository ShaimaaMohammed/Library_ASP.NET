﻿using Microsoft.AspNetCore.Mvc;

namespace Library.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
