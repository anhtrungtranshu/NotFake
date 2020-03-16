using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO.Models;
using Microsoft.AspNetCore.Mvc;
using NotFake.Models;
using Service;
using Service.Utilities;

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

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Login(LoginViewModel loginData)
        {
            User _user = service.User.GetByEmail(loginData.Email);
            if (_user == null)
            {
                return NotFound();
            }
            else
            {
                bool isPasswordCorrect = Crypto.VerifyHashedPassword(_user.Password, loginData.Password);
                if (isPasswordCorrect)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    return NotFound();
                }
            }
        }
    }
}