using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;

namespace Lab_11._2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() // Creates Page. Right click method and select add view to create the page
        {
            return View(); // Renders Page
        }

        public ActionResult Registration()
        {
            ViewBag.Message = "Please fill the form to register!"; // Display Message
            ViewData["AnotherMessage"] = "Hello World"; // Another way to display a message

            //Regex entry = new Regex(@"^(?=.*[a - z])(?=.*[A - Z])(?=.*\d)(?=.*[$@$!% *? &])[A - Za - z\d$@$!% *? &]{ 8,10}"); //(Minimum 8 and Maximum 10 characters at least 1 Uppercase Alphabet, 1 Lowercase Alphabet, 1 Number and 1 Special Character)

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Here is how to contact me.";

            return View();
        }

        public ActionResult ThankYou(string firstname, string lastname, string state)
        {
            ViewBag.Welcome = $"Welcome, {firstname} {lastname} from {state}. Thank you for registering";
            return View();
        }

    }
}