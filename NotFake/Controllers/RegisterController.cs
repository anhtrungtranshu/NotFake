using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAO;
using DAO.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotFake.Models;

namespace NotFake.Controllers
{
    public class RegisterController : Controller
    {
        //private INotFakeService service;

        //public RegisterController(INotFakeService _service)
        //{
        //    service = _service;
        //}

        private NotFakeContext db;

        public RegisterController(NotFakeContext db)
        {
            this.db = db;
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

                if (!Utility.IsEmailValid(user.Email))
                {
                    ViewData["message"] = "Enter Email";
                }
                else
                {

                    var isEmailAlreadyExists = db.User.Any(x => x.Email == model.Email);
                    if (isEmailAlreadyExists)
                    {
                        ModelState.AddModelError("Email", "User with this email already exists");
                        return View(model);
                    }
                }
                user.Email = model.Email;
                user.Fullname = model.Fullname;
                user.Password = model.Password;
                user.Role = UserRoles.User;

                db.User.Add(user);
                db.SaveChanges();

                ViewData["message"] = "User created successfully!";
                return RedirectToAction("Index");
            }
            else
            {
                ViewData["message"] = "Something went wrong";
            }
            return View(model);
        }

        // GET: Register
        public ActionResult Index()
        {
            return View();
        }

        // GET: Register/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Register/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Register/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Register/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Register/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Register/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Register/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}