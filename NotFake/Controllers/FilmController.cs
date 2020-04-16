using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Service;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;

namespace NotFake.Controllers
{
    public class FilmController : Controller
    {

        private readonly IHttpContextAccessor _httpContextAccessor;
        private INotFakeService service;
        public string userName { get; set; }

        public FilmController(INotFakeService _service, IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
            if (_httpContextAccessor.HttpContext.User.Identity.IsAuthenticated)
            {
                // userName = _httpContextAccessor.HttpContext.User.Identity.Name;
                userName = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            }

            service = _service;
        }

        [Authorize(Policy = "Admin")]
        [Route("Film/Watch", Name = "WatchFilm")]
        public IActionResult WatchFilm(int filmId, int? episodeId)
        {
            ViewBag.FilmId = filmId;
            ViewBag.UserName = userName;

            if (episodeId != null)
            {
                ViewBag.EpisodeId = episodeId;
            }
            return View("Index");
        }
        [Route("Film/WatchWithGroup", Name = "WatchFilmWithGroup")]
        public IActionResult WatchFilmWithGroup(int filmId, string groupName, int? episodeId)
        {
            ViewBag.FilmId = filmId;
            ViewBag.GroupName = groupName;

            if (episodeId != null)
            {
                ViewBag.EpisodeId = episodeId;
            }
            return View("Index");
        }
        public IActionResult Chat()
        {

            return View("Chat");
        }
    }
}