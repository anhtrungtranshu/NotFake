using System;
using NotFake.Models;
using Service;
using Service.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DAO.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;

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
        public IActionResult Index()
        {
            return View();
        }
        
        private async Task<IActionResult> SignInUser(User user)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Email.ToString()),
                new Claim(ClaimTypes.Name, user.Fullname),
                new Claim (ClaimTypes.Role, user.Role.ToString()),
            };


            var authProperties = new AuthenticationProperties
            {
                //AllowRefresh = <bool>,
                // Refreshing the authentication session should be allowed.

                ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(1440)
                // The time at which the authentication ticket expires. A 
                // value set here overrides the ExpireTimeSpan option of 
                // CookieAuthenticationOptions set with AddCookie.

                //IsPersistent = true,
                // Whether the authentication session is persisted across 
                // multiple requests. When used with cookies, controls
                // whether the cookie's lifetime is absolute (matching the
                // lifetime of the authentication ticket) or session-based.

                //IssuedUtc = <DateTimeOffset>,
                // The time at which the authentication ticket was issued.

                //RedirectUri = <string>
                // The full path or absolute URI to be used as an http 
                // redirect response value.
            };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);
            await HttpContext.SignInAsync(principal, authProperties);

            return RedirectToAction("Index", "Home");
        }

       
        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);

            return RedirectToAction("Index", "Home");//change this to Log in once completed
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {

                User user = new User();

                if (!Utility.IsEmailValid(model.Email))
                {
                    ViewData["message"] = "Enter correct Email";
                }
                else
                {

                    User existingUser =  service.User.GetByEmail(model.Email);
                    if (existingUser != null)
                    {
                        ModelState.AddModelError("Email", "User with this email already exists");
                        return View(model);
                    }
                }
                user.Email = model.Email;
                user.Fullname = model.Fullname;
                user.Password = Crypto.HashPassword(user.Password);
                user.Password= model.Password;
                user.Role = UserRoles.User;

                service.User.Add(user);

                ViewData["message"] = "User created successfully!";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewData["message"] = "Something went wrong";
            }
            return View(model);
        }

    }
}