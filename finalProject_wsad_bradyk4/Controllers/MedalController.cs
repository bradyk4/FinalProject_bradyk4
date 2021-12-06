using finalProject_wsad_bradyk4.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalProject_wsad_bradyk4.Controllers
{
    public class MedalController : Controller
    {
        private MedalContext context { get; set; }
        public MedalController(MedalContext ctx)
        {
            context = ctx;
        }
        public IActionResult Home()
        {
            var medals = context.Medals.OrderBy(m => m.Event).ToList();
            return View(medals);
        }
        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add"; return View("Edit", new Medal());
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit"; var movie = context.Medals.Find(id); return View(movie);
        }
        [HttpPost]
        public IActionResult Edit(Medal medal)
        {
            if (ModelState.IsValid)
            {
                if (medal.MedalId == 0) context.Medals.Add(medal);
                else
                    context.Medals.Update(medal); context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (medal.MedalId == 0) ? "Add" : "Edit"; return View(medal);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var movie = context.Medals.Find(id); return View(movie);
        }
        [HttpPost]
        public IActionResult Delete(Medal movie)
        {
            context.Medals.Remove(movie); context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
