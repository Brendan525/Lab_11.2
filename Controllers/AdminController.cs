using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNetCore.Mvc;
using Lab_11._2.Models;

namespace Lab_11._2.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            List<CoffeeTable> prod = CoffeeTable.Read();
            return View(prod);
        }

        //public IActionResult Index()
        //{
        //    List<CoffeeTable> prod = CoffeeTable.Read();
        //    return View(prod);
        //}

        public ActionResult Test()
        {
            List<CoffeeTable> prod = CoffeeTable.Read();
            return View(prod);
        }


    }
}