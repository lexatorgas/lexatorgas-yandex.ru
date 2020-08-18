using Microsoft.AspNetCore.Mvc;

namespace Millenium.Controllers
{
    public class ObjectController : Controller
    {
        public IActionResult DruzhbaLager()
        {
            return View();
        }

        public IActionResult OzdoroviteliiCenter()
        {
            return View();
        }

        public IActionResult Irbit()
        {
            return View();
        }
    }
}
