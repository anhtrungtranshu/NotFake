using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace NotFake.Controllers
{
    public class FilmController : Controller
    {

        private readonly IHttpContextAccessor _httpContextAccessor;
        public string userName { get; set; }

        public FilmController(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                userName = _httpContextAccessor.HttpContext.User.Identity.Name;
            }
        }

        [Route("Film/Watch", Name = "WatchFilm")]
        public IActionResult Index(int filmId, int? episodeId)
        {
            ViewBag.FilmId = filmId;
            ViewBag.UserId = userName;

            if (episodeId != null)
            {
                ViewBag.EpisodeId = episodeId;
            }
            return View();
        }

        public IActionResult Chat()
        {

            return View("Chat");
        }
    }
}