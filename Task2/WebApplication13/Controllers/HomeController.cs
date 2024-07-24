using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;

namespace WebApplication13.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet] 
        public ActionResult Index()
        {


            //ViewBag.EmployeeName = "Muhammad Hamza";
            //ViewBag.Company = "Web Development Company";
            //ViewBag.Address = "Dubai, United Arab Emirates";
            //return View();



            //TempData["EmployeeName"] = "Muhammad Hamza";
            //TempData["Company"] = "Web Development Company";
            //TempData["Address"] = "Dubai, United Arab Emirates";

            //Session["Message"] = "Hello MVC!";

            return View();



        }

        [HttpPost]
        //public ActionResult SubmitData(string name ,)
        //{
        //    ViewBag.ReceivedData = name;
        //    return View("About");
        //}

      


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DisplayData(FormCollection form)
        {
            ViewBag.Name = form["name"];
            ViewBag.Age = form["age"];
            ViewBag.Gender = form["Gender"];
            ViewBag.Department = form["department"];
            ViewBag.Skills = form.GetValues("skills");

            return View();
        }
       














    }
}