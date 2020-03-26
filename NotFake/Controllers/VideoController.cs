using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using DAO.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace NotFake.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VideoController : ControllerBase
    {
        private INotFakeService service;
        private IHostingEnvironment _env;
        public VideoController(INotFakeService _service,IHostingEnvironment env)
        {
            _env = env;
            service = _service;
        }
        [HttpGet("{id}")]
        public async Task<FileStreamResult> GetVideo([FromRoute] int id)
        {
            var stream = await service.Film.GetVideoByFilmId(id);
            return new FileStreamResult(stream, "video/mp4");
        }

        [HttpGet("FromFile/{id}")]
        public IActionResult GetVideoFromFile([FromRoute] int id)
        {
            Film film = service.Film.Get(id);
            string webRoot = _env.WebRootPath;
            return PhysicalFile(System.IO.Path.Combine(webRoot, film.FilmAddress), "application/octet-stream");
        }
    }
}