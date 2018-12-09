using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SignUpMVC.Models;

namespace SignUpMVC.Controllers
{
    public class UserController : Controller
    {
        static private readonly List<User> users = new List<User>();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {

            return View();
        }

        [HttpPost]
        // [Route("/User/Add")]
        public IActionResult Add(User user, string verify)
        {
            users.Add(user);
            if (user.Password == verify)
            {
                return Redirect("/User");
            }

            if (user.Password == null || verify == null)
            {

            }

            /* If the passwords don't match, render the form again 
            with the username and email fields already populated, 
            along with a message indicating what went wrong. */
            else
            {

            }

            return Redirect("/User");
        }
    }
}
