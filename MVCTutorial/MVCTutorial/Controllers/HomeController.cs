using MVCTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTutorial.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Log text to a file when a user visits home page
            //string text = "Hello";
            //System.IO.File.WriteAllText(@"C:\Users\danie\Logs\mvcTutorialLog.txt", text);
            //return Content("Hello");
            User user = new User();
            user.Id = 1;
            user.FirstName = "Dan";
            user.LastName = "McWilliams";
            user.Age = 29;

            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            throw new Exception("Invalid page");

            return View();
        }

        public ActionResult Contact(int id=0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}