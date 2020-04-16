using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using DAO.Models;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace NotFake.Controllers
{
    public class UserController : Controller
    {
        private INotFakeService service;
        public UserController(INotFakeService _service)
        {
            service = _service;
        }

        public IActionResult Index()
        {
            IList<User> userList = service.User.ListAll();

            return View(userList);
        }
    }
}