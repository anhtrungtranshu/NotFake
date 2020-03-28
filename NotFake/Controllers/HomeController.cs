using System;
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
            List<Genre> _genres = service.Genre.ListAll().ToList();
            // List<Film> _films = service.Film.ListAll().ToList();

            List<MainPageViewModel> viewModel = _genres
            .ConvertAll(g => new MainPageViewModel()
            {
               Genre = g,
               Films = service.Genre.FilmsInGenre(g.GenreId).ToList()
            });

            return View(viewModel);
            // return View();
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
