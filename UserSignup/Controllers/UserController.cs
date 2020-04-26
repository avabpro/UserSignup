using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/User/Add")]
        public IActionResult Add(User user, string verify)
        {
            if(string.Equals(user.Password, verify))
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

        }
    }
}
