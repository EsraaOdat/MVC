using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Catalogue()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



      



        public ActionResult NewArrivals()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



        public ActionResult Shop()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }



    }
}