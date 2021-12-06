using finalProject_wsad_bradyk4.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Linq;

namespace finalProject_wsad_bradyk4.Controllers
{
    public class HomeController : Controller
    {
        private MedalContext context { get; set; }

        public HomeController(MedalContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var medals = context.Medals.OrderBy(m => m.Event).ToList();
            return View(medals);
        }

        public IActionResult BackSurgery()
        {
            return View();
        }
        public IActionResult AthleticCareer()
        {
            return View();
        }
        public IActionResult AcademicCareer()
        {
            return View();
        }
        public IActionResult Impact()
        {
            return View();
        }
    }
}
