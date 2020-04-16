using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.Models;
using NotFake.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;
using Microsoft.AspNetCore.Authorization;

namespace NotFake.Controllers
{
    public class GenreController : Controller
    {
        private INotFakeService service;
        public GenreController(INotFakeService _service)
        {
            service = _service;
        }
        public IActionResult GetGenres()
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
        }
        public IActionResult GetFilmsInGenre(int id)
        {

            IList<Film> filmlist = service.Genre.FilmsInGenre(id);
            return View("GetFilmsInGenre", filmlist);

        }
        // GET: Genre
        public ActionResult Index()
        {
            return View();
        }

        // GET: Genre/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Genre/Create
        
        [Authorize(Policy="Admin")]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Genre/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy="Admin")]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Genre/Edit/5
        [Authorize(Policy="Admin")]
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Genre/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy="Admin")]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Genre/Delete/5
        [Authorize(Policy="Admin")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Genre/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Policy="Admin")]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}