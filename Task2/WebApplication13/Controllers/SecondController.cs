using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication13.Controllers
{
    public class SecondController : Controller
    {
        // GET: Second
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SubmitData(string data)
        {
            ViewBag.ReceivedData = data;
            return View("DisplayData");
        }

        public ActionResult DisplayData()
        {
            return View();
        }
    }
}