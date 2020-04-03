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
        public VideoController(INotFakeService _service, IHostingEnvironment env)
        {
            _env = env;
            service = _service;
        }

        [HttpGet("{filmId}/{episodeId:int?}")]
        public async Task<IActionResult> GetVideo([FromRoute] int filmId, [FromRoute] int? episodeId)
        {
            return PhysicalFile(Path.Combine(_env.WebRootPath, "Films/Popeye_forPresident_512kb.mp4"), "video/mp4", true);

            // var stream = await service.FilmData.GetVideoByFilmId(filmId, episodeId != null ? episodeId.GetValueOrDefault() : 1);
            // var FSR = new FileStreamResult(stream, "video/mp4");
            // FSR.EnableRangeProcessing = true;
            // return FSR;
        }
    }
}