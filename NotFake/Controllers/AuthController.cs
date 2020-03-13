using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.Models;
using Microsoft.AspNetCore.Mvc;
using Service;

namespace NotFake.Controllers
{
    public class AuthController : Controller
    {
        private INotFakeService service;
        public AuthController(INotFakeService _service)
        {
            service = _service;
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}