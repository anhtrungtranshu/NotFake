using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return View();
        }
    }
}