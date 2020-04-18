using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using DAO.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using NotFake.Models;
using Service;

namespace NotFake.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FriendshipController : Controller
    {
        private INotFakeService service;
        public FriendshipController(INotFakeService _service)
        {
            service = _service;
        }

        [Authorize]
        [HttpPost("{FriendRequestAction }")]
        public IActionResult FriendRequestAction([FromForm] FriendRequestAction data)
        {
            User invitedUser = service.User.GetByEmail(data.invitedUserEmail);
            User invitingUser = service.User.GetByEmail(data.invitingUserEmail);
            service.Friendship.ChangeFriendship(invitingUser, invitedUser, data.isAccepted);
            return Json(new
            {
                success = true
            });
        }
    }

}