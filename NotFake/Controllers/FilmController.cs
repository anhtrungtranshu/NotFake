using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NotFake.Controllers
{
    public class FilmController : Controller
    {
        public IActionResult Index(int id)
        {
            ViewBag.FilmId = id;
            return View();
        }

        public IActionResult Chat()
        {
            return View("Chat");
        }
    }
}