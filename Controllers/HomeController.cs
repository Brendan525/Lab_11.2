using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Text.RegularExpressions;
using Lab_11._2.Models;

namespace Lab_11._2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() // Creates Page. Right click method and select add view to create the page
        {
            return View(); // Renders Page
        }

        //[HttpGet]
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

        //[HttpPost]
        public ActionResult ThankYou(string firstname, string lastname, string gender, DateTime birthday, string state, string email, string phone, string password, string starter)
        {
            User user = new User()
            {
                FirstName = firstname,
                LastName = lastname,
                Gender = gender,
                Birthday = birthday,
                State = state,
                Email = email,
                PhoneNumber = phone,
                Password = password,
                Starter = starter
            };

            //ViewBag.Welcome = $"Welcome, {firstname} {lastname} from {state}. Thank you for registering";
            //ViewData["Name"] = firstname + " " + lastname;
            ViewBag.ThankYou = "Thank you for registering with us.";
            return View(user);
        }


        [HttpGet]
        public ActionResult OrderMenu() 
        {       
            return View();
        }

        [HttpPost]
        public ActionResult Order(string firstname, string lastname, string streetAddress1, string streetAddress2, string city, string state, string zipCode, string country)
        {
            WebOrder webOrder1 = new WebOrder()
            {
                FirstName = firstname,
                LastName = lastname,
                StreetAddress1 = streetAddress1,
                StreetAddress2 = streetAddress2,
                City = city,
                State = state,
                ZipCode = zipCode,
                Country = country
            };
            return View();
        }

        
        public ActionResult Test(string firstname, string lastname, string streetAddress1, string streetAddress2, string city, string state, string zipCode, string country)
        {
            WebOrder webOrder1 = new WebOrder()
            {
                FirstName = firstname,
                LastName = lastname,
                StreetAddress1 = streetAddress1,
                StreetAddress2 = streetAddress2,
                City = city,
                State = state,
                ZipCode = zipCode,
                Country = country
            };
            return View(webOrder1);
           
        }


    }
}