using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using UserSignup.Models;
using UserSignup.ViewModel;

namespace UserSignup.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.users = UserData.GetAll();
            return View();
        }


        public IActionResult Add()
        {
            AddUserViewModel userViewModel = new AddUserViewModel();

            return View(userViewModel);
        }

        [HttpPost]
        public IActionResult Add(AddUserViewModel userFromView)
        {
            if (ModelState.IsValid)
            {
                User newUser = userFromView.CreateUser();
                UserData.Add(newUser);
                return Redirect("/User");
            }
            return View(userFromView);
        }

        /*
        [HttpPost]
        public IActionResult Add(User user, string verify)
        {
            ViewBag.username = user.Username;
            ViewBag.email = user.Email;

            if (user.Username == null)
            {
                ViewBag.usernameError = "The username cannot be empty";
            }
            else if(!((5<=user.Username.Length && user.Username.Length<=15) && Regex.IsMatch(user.Username, "^[a-zA-Z]+$")))
            {
                ViewBag.usernameError = "The username must be between 5 and 15 alphabetic characters";
            }
            if (user.Email == null)
            {
                ViewBag.emailError = "The email cannot be empty";
            }

            if (user.Password == null || verify == null){
                ViewBag.error = "The password fields cannot be empty";
            }
            else if (user.Password == verify)
            {
                UserData.Add(user);
                return Redirect("/User");
            }
            else
            {
                ViewBag.error = "The passwords do not match. Please try again";
            }            
            return View();
        }
        */
        
        public IActionResult Detail(int userId)
        {
            ViewBag.user = UserData.GetById(userId);
            return View();
        }
    }
}