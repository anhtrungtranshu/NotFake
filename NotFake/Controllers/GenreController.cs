using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service;

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
            IList<Genre> genrelist = service.Genre.ListAll();
            IList<Film> filmListForGenre = service.Genre.FilmsInGenre(1);
            List<string> filmnames = new List<string>();
            for (int i = 0; i < filmListForGenre.Count; i++)
            {
                filmnames.Add(filmListForGenre[i].Name);
            }
            ViewData["FilmNames"] = filmnames;        

            //for(int id = 0 ; id< genrelist.Count; id++)
            //{
            //    IList<Film> filmlist = service.Genre.FilmsInGenre(id);
            //}
            return View(genrelist);
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
        public ActionResult Create()
        {
            return View();
        }

        // POST: Genre/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
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
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Genre/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
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
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Genre/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
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