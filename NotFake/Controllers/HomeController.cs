﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DAO.Models;
using Microsoft.AspNetCore.Mvc;
using NotFake.Models;
using Service;
using Service.Repository;

namespace NotFake.Controllers
{
    public class HomeController : Controller
    {
        private INotFakeService service;
        public HomeController(INotFakeService _service)
        {
            service = _service;
        }
        public IActionResult Index()
        {
            IList<Genre> genrelist = service.Genre.ListAll();
            return View(genrelist);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
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
