﻿using Microsoft.AspNetCore.Mvc;

namespace Millenium.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contacts()
        {
            return View();
        }

        public IActionResult Vacancies()
        {
            return View();
        }
    }
}