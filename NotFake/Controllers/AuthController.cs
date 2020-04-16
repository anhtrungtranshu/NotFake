using System;
using NotFake.Models;
using Service;
using DAO.Utilities;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DAO.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;

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
        public async Task<IActionResult> Login(LoginViewModel loginData)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    User _user = service.User.GetByEmail(loginData.Email);
                    if (_user == null)
                    {
                        ModelState.AddModelError("Email", "User does not exist");
                        return View(loginData);
                    }
                    else
                    {
                        bool isPasswordCorrect = Crypto.VerifyHashedPassword(_user.Password, loginData.Password);
                        if (isPasswordCorrect)
                        {
                            return await SignInUser(_user);
                        }
                        else
                        {
                            ModelState.AddModelError("Password", "Wrong Password");
                            return View(loginData);
                        }
                    }
                }
                catch
                {
                    ViewBag["LoginError"] = "Something went wrong, please try again later";
                    return View(loginData);
                }

            }

            return View(loginData);
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
                new Claim(ClaimTypes.Role, user.Role.ToString()),
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

                    User existingUser = service.User.GetByEmail(model.Email);
                    if (existingUser != null)
                    {
                        ModelState.AddModelError("Email", "User with this email already exists");
                        return View(model);
                    }
                }
                user.Email = model.Email;
                user.Fullname = model.Fullname;
                user.Password = Crypto.HashPassword(model.Password);
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


        [HttpGet]
        public IActionResult Profile()
        {
            string Email = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            User user = service.User.GetByEmail(Email);
            List<Friendship> userFriends = service.Friendship.GetFriendships(user);
            HubUser profile = new HubUser()
            {
                UserEmail = user.Email,
                UserName = user.Fullname,
                Friends = userFriends.ConvertAll(uf => new HubUser()
                {
                    UserName = uf.InvitedUser == user ? uf.InvitingUser.Fullname : uf.InvitedUser.Fullname,
                    UserEmail = uf.InvitedUser == user ? uf.InvitingUser.Email : uf.InvitedUser.Email
                })
            };
            ViewBag.ReturnUrl = "/Auth/Profile";
            return View(profile);
        }

        [Authorize]
        public IActionResult ChangePassword(string returnUrl)
        {
            ViewBag.returnUrl = returnUrl;
            return View();
        }

        [Authorize]
        [HttpPost]
        public IActionResult ChangePassword(ChangePasswordViewModel model, string returnurl)
        {
            if (ModelState.IsValid)
            {
                string Email = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
                if (service.User.IsCorrectPassword(Email, model.Password))
                {
                    service.User.UpdatePassword(Email, model.NewPassword);
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.ErrorMessage = "Password is incorrect!";
                    return View(model);
                }
            }
            else
            {
                ViewBag.ErrorMessage = "Something went wrong";
            }
            return View(model);

        }

        public void AddFriendRequest(User user, User friendUser)
        {
            var friendRequest = new Friendship()
            {
                InvitingUser = user,
                InvitedUser = friendUser,
                Status = FriendShipStatus.Pending
            };

            //user.SentFriendRequests.Add(friendRequest);

        }
    }
}