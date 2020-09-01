using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab_11._2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Registration()
        {
            ViewBag.Message = "Welcome to the registration page.";

            return View();
        }

        public ActionResult ThankYou(string firstname, string lastname)
        {
            ViewBag.Welcome = $"Welcome, {firstname} {lastname}. Thank you for registrating";
            return View();
        }

    }
}