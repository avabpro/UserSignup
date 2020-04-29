using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;
using UserSignup.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            string userName = UserData.GetUser().Username;
            return View((object)userName);
        }
            

        public IActionResult Add()
        {
            AddUserViewModel newModel = new AddUserViewModel();
            return View(newModel);
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel newUser)
        {
            if (ModelState.IsValid)
            {
                UserData.SetValues(newUser.Username, newUser.Email, newUser.Password);

                return Redirect("/User");
            }
            else
            {
                return View(newUser);
            }

            /*
            if (string.Equals(user.Password, verify))
            {
                TempData["Name"] = user.Username;
                return Redirect("/User");
            }
            else
            {
                ViewBag.message = "Uh oh! Passwords did not match. Please try again.";
                ViewBag.name = user.Username;
                ViewBag.email = user.Email;

                return View();
            }
            */

        }
    }
}
