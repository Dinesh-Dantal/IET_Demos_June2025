﻿using _15Sessions.Models;
using Microsoft.AspNetCore.Mvc;

namespace _15Sessions.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SignIn(SBUser user)
        {
            if (user.UserName == "mahesh" && user.Password == "mahesh@123")
            {
                HttpContext.Session.SetString("Token", user.UserName);
                return Redirect("/Home/Index");
            }
            else
            {
                ViewBag.message = "Invalid Credentials!";
                return View();
            }
        }

        public IActionResult Signout()
        {
            HttpContext.Session.Remove("Token");
            return Redirect("/Login/SignIn");
        }

    }
}
