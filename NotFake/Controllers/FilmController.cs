using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace NotFake.Controllers
{
    public class FilmController : Controller
    {

        [Route("Film/Watch", Name="WatchFilm")]
        public IActionResult Index(int filmId, int? episodeId)
        {
            ViewBag.FilmId = filmId;
            if(episodeId != null)
            {
                ViewBag.EpisodeId = episodeId;
            }
            return View();
        }
    }
}